using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WarehouseApplication
{
    public partial class LoginForm : Form
    {
        private static string login = "admin";
        private static string password = "admin";

        public LoginForm()
        {
            InitializeComponent();
            this.FormClosed += LoginWindowClosed;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginInputBox.Text) || string.IsNullOrWhiteSpace(PasswordInputBox.Text))
            {
                ShowErrorMessage("Fields cannot be empty.");
            }
            else if (LoginInputBox.Text == login && PasswordInputBox.Text == password)
            {
                MainWindow mainForm = new MainWindow();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                ShowErrorMessage("Invalid login or password.");
            }
        }

        private void LoginWindowClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ShowErrorMessage(string message)
        {
            DialogWindowLoginForm messageBox = new DialogWindowLoginForm(message);
            messageBox.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
