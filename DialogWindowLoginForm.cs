namespace WarehouseApplication
{
    public partial class DialogWindowLoginForm : Form
    {
        public DialogWindowLoginForm(string message)
        {
            InitializeComponent();
            DialogLoginLabel.Text = message;
        }

        private void DialogWindowLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
