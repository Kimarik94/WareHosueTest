using WarehouseApplication;
public class Box : AbstractWarehouseItem
{
    public DateOnly ProductionDate { get; set; }
    public DateOnly ExpirationDate { get; set; }

    public Box(float width, float height, float depth, float weight, DateOnly productionDate, DateOnly? expirationDate = null)
    {
        Width = width;
        Height = height;
        Depth = depth;
        Weight = weight;
        ProductionDate = productionDate;

        ExpirationDate = expirationDate ?? productionDate.AddDays(100);
    }

    public float FindBoxVolume()
    {
        return Width * Height * Depth;
    }
}
