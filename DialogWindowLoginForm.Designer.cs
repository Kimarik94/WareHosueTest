namespace WarehouseApplication
{
    partial class DialogWindowLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DialogLoginLabel = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // DialogLoginLabel
            // 
            DialogLoginLabel.AutoSize = true;
            DialogLoginLabel.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DialogLoginLabel.Location = new Point(11, 9);
            DialogLoginLabel.Margin = new Padding(0);
            DialogLoginLabel.MaximumSize = new Size(500, 500);
            DialogLoginLabel.Name = "DialogLoginLabel";
            DialogLoginLabel.Size = new Size(407, 32);
            DialogLoginLabel.TabIndex = 0;
            DialogLoginLabel.Text = "Something Incorrect! Try Again.";
            DialogLoginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            btnOk.Dock = DockStyle.Bottom;
            btnOk.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOk.Location = new Point(0, 97);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(427, 43);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // DialogWindowLoginForm
            // 
            AutoScaleDimensions = new SizeF(22F, 42F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(427, 140);
            Controls.Add(btnOk);
            Controls.Add(DialogLoginLabel);
            Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(9, 8, 9, 8);
            MinimizeBox = false;
            Name = "DialogWindowLoginForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DialogWindowLoginForm";
            Load += DialogWindowLoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DialogLoginLabel;
        private Button btnOk;
    }
}