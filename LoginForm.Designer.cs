namespace WarehouseApplication
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            GreetingLabel = new Label();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            LoginInputBox = new TextBox();
            PasswordInputBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // GreetingLabel
            // 
            GreetingLabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GreetingLabel.Location = new Point(12, 9);
            GreetingLabel.Name = "GreetingLabel";
            GreetingLabel.Size = new Size(357, 29);
            GreetingLabel.TabIndex = 7;
            GreetingLabel.Text = "Hello Tester! Input data from ReadMe.txt";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginLabel.Location = new Point(12, 38);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(52, 19);
            LoginLabel.TabIndex = 2;
            LoginLabel.Text = "Login:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PasswordLabel.Location = new Point(12, 88);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(77, 19);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password:";
            // 
            // LoginInputBox
            // 
            LoginInputBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginInputBox.Location = new Point(12, 110);
            LoginInputBox.Name = "LoginInputBox";
            LoginInputBox.PasswordChar = '*';
            LoginInputBox.Size = new Size(192, 26);
            LoginInputBox.TabIndex = 8;
            // 
            // PasswordInputBox
            // 
            PasswordInputBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordInputBox.Location = new Point(12, 60);
            PasswordInputBox.Name = "PasswordInputBox";
            PasswordInputBox.Size = new Size(192, 26);
            PasswordInputBox.TabIndex = 7;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginButton.Location = new Point(259, 88);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(91, 48);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(362, 153);
            Controls.Add(LoginButton);
            Controls.Add(PasswordInputBox);
            Controls.Add(LoginInputBox);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(GreetingLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Warehouse";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GreetingLabel;
        private Label LoginLabel;
        private Label PasswordLabel;
        private TextBox LoginInputBox;
        private TextBox PasswordInputBox;
        private Button LoginButton;
    }
}
