namespace WarehouseApplication
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            this.FormClosed += MainWindowClosed;
        }

        private void MainWindowLoaded(object sender, EventArgs e)
        {
            PalletsCountInt.Text = Program.palletsCount.ToString();
        }

        private void MainWindowClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PalletsCountInt_Click(object sender, EventArgs e)
        {

        }

        private void SortPallets_Click(object sender, EventArgs e)
        {
            var groupedPallets = Program.pallets
        .OrderBy(p => p.ExpirationDate) // Сортировка по сроку годности
        .ThenBy(p => p.Weight) // Внутри группы сортировка по весу
        .ToList();

            // Очистка DataGridView и добавление отсортированных данных
            SortPalletsGrid.Rows.Clear();

            foreach (var pallet in groupedPallets)
            {
                SortPalletsGrid.Rows.Add(
                    pallet.Id,
                    pallet.ExpirationDate.ToString("dd.MM.yyyy"),
                    pallet.Weight,
                    pallet.boxes.Count
                );
            }
        }

        private void AddBoxToPallet_Click(object sender, EventArgs e)
        {
            AddBoxToPalletForm addBox = new AddBoxToPalletForm();
            addBox.Show();
        }

        private void AddEpmtyPalletBtn_Click(object sender, EventArgs e)
        {
            Program.pallets.Add(new Pallet(120f, 100f, 100f, 0f, new List<Box>()));
            Program.palletsCount++;
            PalletsCountInt.Text = (int.Parse(PalletsCountInt.Text)+1).ToString();
        }
    }
}
