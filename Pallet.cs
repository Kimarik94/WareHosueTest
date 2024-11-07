using System;
using WarehouseApplication;
public class Pallet : AbstractWarehouseItem
{
    internal int BoxesCount => boxes.Count;

    public DateOnly ExpirationDate => PalletExpirationDate();

    public List<Box> boxes = new List<Box>();

    public Pallet(float width, float height, float depth, float weight, List<Box> boxes)
    {
        Id = Program.palletsCount++;
        this.Width = width;
        this.Height = height;
        this.Depth = depth;
        this.Weight = weight+30;
        this.boxes = boxes;
    }

    public float PalletVolume()
    {
        float palletVolume = Width * Height * Depth;
        
        foreach (Box box in boxes)
        {
            palletVolume += box.FindBoxVolume();
        }

        return palletVolume;
    }

    public DateOnly PalletExpirationDate()
    {
        if(boxes.Count > 0)
        {
            DateOnly palletExpirationDateTemp = boxes[0].ExpirationDate;

            foreach (var box in boxes)
            {
                if (box.ExpirationDate < palletExpirationDateTemp)
                    palletExpirationDateTemp = box.ExpirationDate;
            }

            return palletExpirationDateTemp;
        }
        else
        {
            return new DateOnly(1900, 1, 1);
        }
        
    }
}
