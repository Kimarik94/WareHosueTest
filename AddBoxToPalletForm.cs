using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseApplication
{
    public partial class AddBoxToPalletForm : Form
    {
        private bool palletWidthChanged = false;
        private bool palletHeightChanged = false;
        private bool palletDepthChanged = false;

        private DateOnly currentAddBoxDateExp;
        private DateOnly currentAddBoxDateProd;

        public AddBoxToPalletForm()
        {
            InitializeComponent();
        }

        private void AddBoxToPalletForm_Load(object sender, EventArgs e)
        {
            foreach (var pallet in Program.pallets)
            {
                palletsId.Items.Add(pallet.Id + 1);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void palletsId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pallet temp = Program.pallets[int.Parse(palletsId.SelectedItem.ToString()) - 1];
            PalletWidthTextBox.Text = temp.Width.ToString();
            PalletHeightTextBox.Text = temp.Height.ToString();
            PalletDepthTextBox.Text = temp.Depth.ToString();
            PalletWeightLabelCalc.Text = temp.Weight.ToString();
            PalletVolumeCalcLabel.Text = temp.PalletVolume().ToString();
            PalletBoxes.Text = temp.boxes.Count.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (palletsId.SelectedItem == null)
            {
                ShowErrorMessage("First, Choose pallet!");
            }
            else if (float.Parse(BoxWidthTBox.Text) > float.Parse(PalletWidthTextBox.Text) ||
                    float.Parse(BoxDepthTBox.Text) > float.Parse(PalletDepthTextBox.Text))
            {
                ShowErrorMessage("Box Width/Depth params can`t be greater than Pallet Params");
            }
            else if (string.IsNullOrWhiteSpace(BoxWidthLabel.Text) ||
                     string.IsNullOrWhiteSpace(BoxHeightTBox.Text) ||
                     string.IsNullOrWhiteSpace(BoxDepthTBox.Text) ||
                     string.IsNullOrWhiteSpace(BoxWeightTBox.Text))
            {
                ShowErrorMessage("Check Box Fields");
            }
            else if (currentAddBoxDateExp.Day < currentAddBoxDateProd.Day)
            {
                ShowErrorMessage("Exp.Date can`t be lower than Prod.Date");
            }
            else
            {
                currentAddBoxDateExp = currentAddBoxDateProd.AddDays(100);
                Program.pallets[int.Parse(palletsId.SelectedItem.ToString()) - 1].boxes.Add(
                    new Box(float.Parse(BoxWidthTBox.Text),
                            float.Parse(BoxHeightTBox.Text),
                            float.Parse(BoxDepthTBox.Text),
                            float.Parse(BoxWeightTBox.Text),
                            currentAddBoxDateProd, currentAddBoxDateExp));

                Program.pallets[int.Parse(palletsId.SelectedItem.ToString()) - 1].Weight += float.Parse(BoxWeightTBox.Text);

                this.Close();
            }
        }

        private void BoxWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            palletWidthChanged = true;

        }

        private void BoxHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            palletHeightChanged = true;
        }

        private void BoxDepthTextBox_TextChanged(object sender, EventArgs e)
        {
            palletDepthChanged = true;
        }

        private void RefreshData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PalletWidthTextBox.Text) ||
                string.IsNullOrWhiteSpace(PalletHeightTextBox.Text) ||
                string.IsNullOrWhiteSpace(PalletDepthTextBox.Text))
            {
                ShowErrorMessage("Fields cannot be empty.");
            }
            else if (float.Parse(PalletWidthTextBox.Text) < 100.0f ||
                     float.Parse(PalletHeightTextBox.Text) < 100.0f ||
                     float.Parse(PalletDepthTextBox.Text) < 100.0f)
            {
                ShowErrorMessage("Base Pallet Params can`r be lower 100");
            }
            else
            {
                Program.pallets[int.Parse(palletsId.SelectedItem.ToString()) - 1].Width = float.Parse(PalletWidthTextBox.Text);
                Program.pallets[int.Parse(palletsId.SelectedItem.ToString()) - 1].Height = float.Parse(PalletHeightTextBox.Text);
                Program.pallets[int.Parse(palletsId.SelectedItem.ToString()) - 1].Depth = float.Parse(PalletDepthTextBox.Text);
                palletWidthChanged = false;
                palletHeightChanged = false;
                palletDepthChanged = false;
            }
        }

        private void ShowErrorMessage(string v)
        {
            DialogWindowLoginForm messageBox = new DialogWindowLoginForm(v);
            messageBox.ShowDialog();
        }

        private void BoxExpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedExpDate = BoxExpDate.Value;
            currentAddBoxDateExp = DateOnly.FromDateTime(selectedExpDate);

            DateTime selectedDate = BoxProdDate.Value;
            currentAddBoxDateProd = DateOnly.FromDateTime(selectedDate);
        }

        private void BoxProdDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = BoxProdDate.Value;
            currentAddBoxDateProd = DateOnly.FromDateTime(selectedDate);

            DateTime selectedExpDate = BoxExpDate.Value;
            currentAddBoxDateExp = DateOnly.FromDateTime(selectedExpDate);
        }
    }
}

