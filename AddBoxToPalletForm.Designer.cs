namespace WarehouseApplication
{
    partial class AddBoxToPalletForm
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
            PalletIdLabel = new Label();
            PalletWidthTextBox = new TextBox();
            PalletWidthLabel = new Label();
            PalletHeightTextBox = new TextBox();
            PalletHeightLabel = new Label();
            PalletDepthTextBox = new TextBox();
            PalletDepthLabel = new Label();
            PalletWeightLabel = new Label();
            PalletVolumeLabel = new Label();
            AddBtn = new Button();
            CloseBtn = new Button();
            PalletVolumeCalcLabel = new Label();
            palletsId = new ComboBox();
            PalletWeightLabelCalc = new Label();
            PalletBoxes = new Label();
            PalletBoxesLabel = new Label();
            RefreshData = new Button();
            BoxVolumeLblCalc = new Label();
            BoxVolumeLabel = new Label();
            BoxWeightLabel = new Label();
            BoxDepthTBox = new TextBox();
            BoxDepthLabel = new Label();
            BoxHeightTBox = new TextBox();
            BoxHeightLabel = new Label();
            BoxWidthTBox = new TextBox();
            BoxWidthLabel = new Label();
            BoxWeightTBox = new TextBox();
            BoxExpirationDate = new Label();
            BoxExpDate = new DateTimePicker();
            BoxProdDate = new DateTimePicker();
            BoxProdLabelDate = new Label();
            SuspendLayout();
            // 
            // PalletIdLabel
            // 
            PalletIdLabel.AutoSize = true;
            PalletIdLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PalletIdLabel.Location = new Point(16, 16);
            PalletIdLabel.Name = "PalletIdLabel";
            PalletIdLabel.Size = new Size(74, 19);
            PalletIdLabel.TabIndex = 0;
            PalletIdLabel.Text = "Pallet ID:";
            // 
            // PalletWidthTextBox
            // 
            PalletWidthTextBox.Location = new Point(116, 41);
            PalletWidthTextBox.Name = "PalletWidthTextBox";
            PalletWidthTextBox.Size = new Size(112, 23);
            PalletWidthTextBox.TabIndex = 3;
            PalletWidthTextBox.TextChanged += BoxWidthTextBox_TextChanged;
            // 
            // PalletWidthLabel
            // 
            PalletWidthLabel.AutoSize = true;
            PalletWidthLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PalletWidthLabel.Location = new Point(16, 45);
            PalletWidthLabel.Name = "PalletWidthLabel";
            PalletWidthLabel.Size = new Size(96, 19);
            PalletWidthLabel.TabIndex = 2;
            PalletWidthLabel.Text = "Pallet Width:";
            // 
            // PalletHeightTextBox
            // 
            PalletHeightTextBox.Location = new Point(116, 70);
            PalletHeightTextBox.Name = "PalletHeightTextBox";
            PalletHeightTextBox.Size = new Size(111, 23);
            PalletHeightTextBox.TabIndex = 5;
            PalletHeightTextBox.TextChanged += BoxHeightTextBox_TextChanged;
            // 
            // PalletHeightLabel
            // 
            PalletHeightLabel.AutoSize = true;
            PalletHeightLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PalletHeightLabel.Location = new Point(16, 74);
            PalletHeightLabel.Name = "PalletHeightLabel";
            PalletHeightLabel.Size = new Size(101, 19);
            PalletHeightLabel.TabIndex = 4;
            PalletHeightLabel.Text = "Pallet Height:";
            // 
            // PalletDepthTextBox
            // 
            PalletDepthTextBox.Location = new Point(116, 99);
            PalletDepthTextBox.Name = "PalletDepthTextBox";
            PalletDepthTextBox.Size = new Size(111, 23);
            PalletDepthTextBox.TabIndex = 7;
            PalletDepthTextBox.TextChanged += BoxDepthTextBox_TextChanged;
            // 
            // PalletDepthLabel
            // 
            PalletDepthLabel.AutoSize = true;
            PalletDepthLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PalletDepthLabel.Location = new Point(16, 103);
            PalletDepthLabel.Name = "PalletDepthLabel";
            PalletDepthLabel.Size = new Size(97, 19);
            PalletDepthLabel.TabIndex = 6;
            PalletDepthLabel.Text = "Pallet Depth:";
            // 
            // PalletWeightLabel
            // 
            PalletWeightLabel.AutoSize = true;
            PalletWeightLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PalletWeightLabel.Location = new Point(16, 132);
            PalletWeightLabel.Name = "PalletWeightLabel";
            PalletWeightLabel.Size = new Size(103, 19);
            PalletWeightLabel.TabIndex = 8;
            PalletWeightLabel.Text = "Pallet Weight:";
            // 
            // PalletVolumeLabel
            // 
            PalletVolumeLabel.AutoSize = true;
            PalletVolumeLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PalletVolumeLabel.Location = new Point(16, 159);
            PalletVolumeLabel.Name = "PalletVolumeLabel";
            PalletVolumeLabel.Size = new Size(106, 19);
            PalletVolumeLabel.TabIndex = 10;
            PalletVolumeLabel.Text = "Pallet Volume:";
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Times New Roman", 12.25F, FontStyle.Bold);
            AddBtn.Location = new Point(355, 221);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(112, 28);
            AddBtn.TabIndex = 12;
            AddBtn.Text = "Add Box";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseBtn.Location = new Point(16, 221);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(60, 28);
            CloseBtn.TabIndex = 13;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // PalletVolumeCalcLabel
            // 
            PalletVolumeCalcLabel.AutoSize = true;
            PalletVolumeCalcLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PalletVolumeCalcLabel.Location = new Point(125, 159);
            PalletVolumeCalcLabel.Name = "PalletVolumeCalcLabel";
            PalletVolumeCalcLabel.Size = new Size(17, 19);
            PalletVolumeCalcLabel.TabIndex = 14;
            PalletVolumeCalcLabel.Text = "0";
            // 
            // palletsId
            // 
            palletsId.Location = new Point(116, 12);
            palletsId.Name = "palletsId";
            palletsId.Size = new Size(112, 23);
            palletsId.TabIndex = 0;
            palletsId.SelectedIndexChanged += palletsId_SelectedIndexChanged;
            // 
            // PalletWeightLabelCalc
            // 
            PalletWeightLabelCalc.AutoSize = true;
            PalletWeightLabelCalc.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PalletWeightLabelCalc.Location = new Point(125, 132);
            PalletWeightLabelCalc.Name = "PalletWeightLabelCalc";
            PalletWeightLabelCalc.Size = new Size(17, 19);
            PalletWeightLabelCalc.TabIndex = 15;
            PalletWeightLabelCalc.Text = "0";
            // 
            // PalletBoxes
            // 
            PalletBoxes.AutoSize = true;
            PalletBoxes.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PalletBoxes.Location = new Point(94, 187);
            PalletBoxes.Name = "PalletBoxes";
            PalletBoxes.Size = new Size(17, 19);
            PalletBoxes.TabIndex = 17;
            PalletBoxes.Text = "0";
            // 
            // PalletBoxesLabel
            // 
            PalletBoxesLabel.AutoSize = true;
            PalletBoxesLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PalletBoxesLabel.Location = new Point(16, 187);
            PalletBoxesLabel.Name = "PalletBoxesLabel";
            PalletBoxesLabel.Size = new Size(72, 19);
            PalletBoxesLabel.TabIndex = 16;
            PalletBoxesLabel.Text = "Boxes in:";
            // 
            // RefreshData
            // 
            RefreshData.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RefreshData.Location = new Point(99, 221);
            RefreshData.Name = "RefreshData";
            RefreshData.Size = new Size(129, 28);
            RefreshData.TabIndex = 18;
            RefreshData.Text = "Refrersh Data";
            RefreshData.UseVisualStyleBackColor = true;
            RefreshData.Click += RefreshData_Click;
            // 
            // BoxVolumeLblCalc
            // 
            BoxVolumeLblCalc.AutoSize = true;
            BoxVolumeLblCalc.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BoxVolumeLblCalc.Location = new Point(356, 130);
            BoxVolumeLblCalc.Name = "BoxVolumeLblCalc";
            BoxVolumeLblCalc.Size = new Size(17, 19);
            BoxVolumeLblCalc.TabIndex = 27;
            BoxVolumeLblCalc.Text = "0";
            // 
            // BoxVolumeLabel
            // 
            BoxVolumeLabel.AutoSize = true;
            BoxVolumeLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BoxVolumeLabel.Location = new Point(247, 130);
            BoxVolumeLabel.Name = "BoxVolumeLabel";
            BoxVolumeLabel.Size = new Size(95, 19);
            BoxVolumeLabel.TabIndex = 26;
            BoxVolumeLabel.Text = "Box Volume:";
            // 
            // BoxWeightLabel
            // 
            BoxWeightLabel.AutoSize = true;
            BoxWeightLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BoxWeightLabel.Location = new Point(247, 103);
            BoxWeightLabel.Name = "BoxWeightLabel";
            BoxWeightLabel.Size = new Size(92, 19);
            BoxWeightLabel.TabIndex = 25;
            BoxWeightLabel.Text = "Box Weight:";
            // 
            // BoxDepthTBox
            // 
            BoxDepthTBox.Location = new Point(356, 70);
            BoxDepthTBox.Name = "BoxDepthTBox";
            BoxDepthTBox.Size = new Size(111, 23);
            BoxDepthTBox.TabIndex = 24;
            // 
            // BoxDepthLabel
            // 
            BoxDepthLabel.AutoSize = true;
            BoxDepthLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BoxDepthLabel.Location = new Point(247, 74);
            BoxDepthLabel.Name = "BoxDepthLabel";
            BoxDepthLabel.Size = new Size(86, 19);
            BoxDepthLabel.TabIndex = 23;
            BoxDepthLabel.Text = "Box Depth:";
            // 
            // BoxHeightTBox
            // 
            BoxHeightTBox.Location = new Point(356, 41);
            BoxHeightTBox.Name = "BoxHeightTBox";
            BoxHeightTBox.Size = new Size(111, 23);
            BoxHeightTBox.TabIndex = 22;
            // 
            // BoxHeightLabel
            // 
            BoxHeightLabel.AutoSize = true;
            BoxHeightLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BoxHeightLabel.Location = new Point(247, 45);
            BoxHeightLabel.Name = "BoxHeightLabel";
            BoxHeightLabel.Size = new Size(90, 19);
            BoxHeightLabel.TabIndex = 21;
            BoxHeightLabel.Text = "Box Height:";
            // 
            // BoxWidthTBox
            // 
            BoxWidthTBox.Location = new Point(356, 12);
            BoxWidthTBox.Name = "BoxWidthTBox";
            BoxWidthTBox.Size = new Size(111, 23);
            BoxWidthTBox.TabIndex = 20;
            // 
            // BoxWidthLabel
            // 
            BoxWidthLabel.AutoSize = true;
            BoxWidthLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BoxWidthLabel.Location = new Point(247, 16);
            BoxWidthLabel.Name = "BoxWidthLabel";
            BoxWidthLabel.Size = new Size(85, 19);
            BoxWidthLabel.TabIndex = 19;
            BoxWidthLabel.Text = "Box Width:";
            // 
            // BoxWeightTBox
            // 
            BoxWeightTBox.Location = new Point(356, 99);
            BoxWeightTBox.Name = "BoxWeightTBox";
            BoxWeightTBox.Size = new Size(111, 23);
            BoxWeightTBox.TabIndex = 28;
            // 
            // BoxExpirationDate
            // 
            BoxExpirationDate.AutoSize = true;
            BoxExpirationDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BoxExpirationDate.Location = new Point(247, 159);
            BoxExpirationDate.Name = "BoxExpirationDate";
            BoxExpirationDate.Size = new Size(108, 19);
            BoxExpirationDate.TabIndex = 29;
            BoxExpirationDate.Text = "Box Exp.Date:";
            // 
            // BoxExpDate
            // 
            BoxExpDate.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BoxExpDate.Format = DateTimePickerFormat.Custom;
            BoxExpDate.Location = new Point(361, 158);
            BoxExpDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            BoxExpDate.Name = "BoxExpDate";
            BoxExpDate.Size = new Size(106, 22);
            BoxExpDate.TabIndex = 30;
            BoxExpDate.ValueChanged += BoxExpDate_ValueChanged;
            // 
            // BoxProdDate
            // 
            BoxProdDate.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BoxProdDate.Format = DateTimePickerFormat.Custom;
            BoxProdDate.Location = new Point(361, 186);
            BoxProdDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            BoxProdDate.Name = "BoxProdDate";
            BoxProdDate.Size = new Size(106, 22);
            BoxProdDate.TabIndex = 32;
            BoxProdDate.ValueChanged += BoxProdDate_ValueChanged;
            // 
            // BoxProdLabelDate
            // 
            BoxProdLabelDate.AutoSize = true;
            BoxProdLabelDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BoxProdLabelDate.Location = new Point(247, 187);
            BoxProdLabelDate.Name = "BoxProdLabelDate";
            BoxProdLabelDate.Size = new Size(113, 19);
            BoxProdLabelDate.TabIndex = 31;
            BoxProdLabelDate.Text = "Box Prod.Date:";
            // 
            // AddBoxToPalletForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(BoxProdDate);
            Controls.Add(BoxProdLabelDate);
            Controls.Add(BoxExpDate);
            Controls.Add(BoxExpirationDate);
            Controls.Add(BoxWeightTBox);
            Controls.Add(BoxVolumeLblCalc);
            Controls.Add(BoxVolumeLabel);
            Controls.Add(BoxWeightLabel);
            Controls.Add(BoxDepthTBox);
            Controls.Add(BoxDepthLabel);
            Controls.Add(BoxHeightTBox);
            Controls.Add(BoxHeightLabel);
            Controls.Add(BoxWidthTBox);
            Controls.Add(BoxWidthLabel);
            Controls.Add(RefreshData);
            Controls.Add(PalletBoxes);
            Controls.Add(PalletBoxesLabel);
            Controls.Add(PalletWeightLabelCalc);
            Controls.Add(palletsId);
            Controls.Add(PalletVolumeCalcLabel);
            Controls.Add(CloseBtn);
            Controls.Add(AddBtn);
            Controls.Add(PalletVolumeLabel);
            Controls.Add(PalletWeightLabel);
            Controls.Add(PalletDepthTextBox);
            Controls.Add(PalletDepthLabel);
            Controls.Add(PalletHeightTextBox);
            Controls.Add(PalletHeightLabel);
            Controls.Add(PalletWidthTextBox);
            Controls.Add(PalletWidthLabel);
            Controls.Add(PalletIdLabel);
            MaximumSize = new Size(500, 300);
            MinimumSize = new Size(500, 300);
            Name = "AddBoxToPalletForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBoxToPalletForm";
            Load += AddBoxToPalletForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PalletIdLabel;
        private TextBox PalletWidthTextBox;
        private Label PalletWidthLabel;
        private TextBox PalletHeightTextBox;
        private Label PalletHeightLabel;
        private TextBox PalletDepthTextBox;
        private Label PalletDepthLabel;
        private Label PalletWeightLabel;
        private Label PalletVolumeLabel;
        private Button AddBtn;
        private Button CloseBtn;
        private Label PalletVolumeCalcLabel;
        private ComboBox palletsId;
        private Label PalletWeightLabelCalc;
        private Label PalletBoxes;
        private Label PalletBoxesLabel;
        private Button RefreshData;
        private Label BoxVolumeLblCalc;
        private Label BoxVolumeLabel;
        private Label BoxWeightLabel;
        private TextBox BoxDepthTBox;
        private Label BoxDepthLabel;
        private TextBox BoxHeightTBox;
        private Label BoxHeightLabel;
        private TextBox BoxWidthTBox;
        private Label BoxWidthLabel;
        private TextBox BoxWeightTBox;
        private Label BoxExpirationDate;
        private DateTimePicker BoxExpDate;
        private DateTimePicker BoxProdDate;
        private Label BoxProdLabelDate;
    }
}