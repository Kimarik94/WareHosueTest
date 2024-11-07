namespace WarehouseApplication
{
    public static class Program
    {
        public static int palletsCount = 0;
        public static List<Pallet> pallets = new List<Pallet>();

        [STAThread]
        public static void Main()
        {
            InitializeData();
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }

        public static void InitializeData()
        {
            pallets.Add(new Pallet(120f, 100f, 100f, 0f, new List<Box>()));
            pallets.Add(new Pallet(120f, 100f, 100f, 0f, new List<Box>()));
            palletsCount = pallets.Count;
        }

    }
}