namespace WarehouseApplication
{
    partial class MainWindow
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
            PalletsCountLabel = new Label();
            PalletsCountInt = new Label();
            AddBoxToPallet = new Button();
            SortPallets = new Button();
            AddEpmtyPalletBtn = new Button();
            SortPalletsGrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            ExpDate = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            Boxes = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)SortPalletsGrid).BeginInit();
            SuspendLayout();
            // 
            // PalletsCountLabel
            // 
            PalletsCountLabel.AutoSize = true;
            PalletsCountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PalletsCountLabel.Location = new Point(6, 16);
            PalletsCountLabel.Name = "PalletsCountLabel";
            PalletsCountLabel.Size = new Size(81, 15);
            PalletsCountLabel.TabIndex = 0;
            PalletsCountLabel.Text = "Pallets count:";
            // 
            // PalletsCountInt
            // 
            PalletsCountInt.AutoSize = true;
            PalletsCountInt.Location = new Point(87, 16);
            PalletsCountInt.Name = "PalletsCountInt";
            PalletsCountInt.Size = new Size(13, 15);
            PalletsCountInt.TabIndex = 1;
            PalletsCountInt.Text = "0";
            PalletsCountInt.Click += PalletsCountInt_Click;
            // 
            // AddBoxToPallet
            // 
            AddBoxToPallet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddBoxToPallet.Location = new Point(6, 267);
            AddBoxToPallet.Name = "AddBoxToPallet";
            AddBoxToPallet.Size = new Size(242, 23);
            AddBoxToPallet.TabIndex = 3;
            AddBoxToPallet.Text = "Add Box to Pallet / Change Pallet Data";
            AddBoxToPallet.UseVisualStyleBackColor = true;
            AddBoxToPallet.Click += AddBoxToPallet_Click;
            // 
            // SortPallets
            // 
            SortPallets.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SortPallets.Location = new Point(264, 8);
            SortPallets.Name = "SortPallets";
            SortPallets.Size = new Size(65, 23);
            SortPallets.TabIndex = 4;
            SortPallets.Text = "Sort";
            SortPallets.UseVisualStyleBackColor = true;
            SortPallets.Click += SortPallets_Click;
            // 
            // AddEpmtyPalletBtn
            // 
            AddEpmtyPalletBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddEpmtyPalletBtn.Location = new Point(254, 267);
            AddEpmtyPalletBtn.Name = "AddEpmtyPalletBtn";
            AddEpmtyPalletBtn.Size = new Size(75, 23);
            AddEpmtyPalletBtn.TabIndex = 5;
            AddEpmtyPalletBtn.Text = "Add Pallet";
            AddEpmtyPalletBtn.UseVisualStyleBackColor = true;
            AddEpmtyPalletBtn.Click += AddEpmtyPalletBtn_Click;
            // 
            // SortPalletsGrid
            // 
            SortPalletsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SortPalletsGrid.Columns.AddRange(new DataGridViewColumn[] { ID, ExpDate, Weight, Boxes });
            SortPalletsGrid.Location = new Point(7, 40);
            SortPalletsGrid.Name = "SortPalletsGrid";
            SortPalletsGrid.Size = new Size(318, 212);
            SortPalletsGrid.TabIndex = 6;
            // 
            // ID
            // 
            ID.FillWeight = 30F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 20;
            // 
            // ExpDate
            // 
            ExpDate.HeaderText = "ExpDate";
            ExpDate.Name = "ExpDate";
            // 
            // Weight
            // 
            Weight.HeaderText = "Weight";
            Weight.Name = "Weight";
            Weight.Width = 90;
            // 
            // Boxes
            // 
            Boxes.HeaderText = "Boxes";
            Boxes.Name = "Boxes";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(337, 298);
            Controls.Add(SortPalletsGrid);
            Controls.Add(AddEpmtyPalletBtn);
            Controls.Add(SortPallets);
            Controls.Add(AddBoxToPallet);
            Controls.Add(PalletsCountInt);
            Controls.Add(PalletsCountLabel);
            MinimumSize = new Size(353, 239);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pallets and Boxes";
            Load += MainWindowLoaded;
            ((System.ComponentModel.ISupportInitialize)SortPalletsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PalletsCountLabel;
        private Label PalletsCountInt;
        private Button AddBoxToPallet;
        private Button SortPallets;
        private Button AddEpmtyPalletBtn;
        private DataGridView SortPalletsGrid;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ExpDate;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn Boxes;
    }
}
