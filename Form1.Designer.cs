namespace ADO_NET_ПЗ_Модуль_02_Частина_1_Ua
{
    partial class Form1
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
            ButtonConnect = new Button();
            ButtonDisconnect = new Button();
            dataGridView1 = new DataGridView();
            AllInfo = new RadioButton();
            AllType = new RadioButton();
            AllMan = new RadioButton();
            MaxQuantity = new RadioButton();
            MinQuantity = new RadioButton();
            MaxCP = new RadioButton();
            MinCP = new RadioButton();
            WareHouseByCategory = new RadioButton();
            comboBoxType = new ComboBox();
            WareHouseByMan = new RadioButton();
            comboBoxMan = new ComboBox();
            Old = new RadioButton();
            AvarageByType = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ButtonConnect
            // 
            ButtonConnect.Location = new Point(12, 12);
            ButtonConnect.Name = "ButtonConnect";
            ButtonConnect.Size = new Size(78, 23);
            ButtonConnect.TabIndex = 0;
            ButtonConnect.Text = "Connect DB";
            ButtonConnect.UseVisualStyleBackColor = true;
            ButtonConnect.Click += ButtonConnect_Click;
            // 
            // ButtonDisconnect
            // 
            ButtonDisconnect.Location = new Point(96, 12);
            ButtonDisconnect.Name = "ButtonDisconnect";
            ButtonDisconnect.Size = new Size(94, 23);
            ButtonDisconnect.TabIndex = 1;
            ButtonDisconnect.Text = "Disconnect DB";
            ButtonDisconnect.UseVisualStyleBackColor = true;
            ButtonDisconnect.Click += ButtonDisconnect_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 204);
            dataGridView1.TabIndex = 2;
            // 
            // AllInfo
            // 
            AllInfo.AutoSize = true;
            AllInfo.Location = new Point(196, 12);
            AllInfo.Name = "AllInfo";
            AllInfo.Size = new Size(87, 19);
            AllInfo.TabIndex = 3;
            AllInfo.TabStop = true;
            AllInfo.Text = "AllDataBase";
            AllInfo.UseVisualStyleBackColor = true;
            AllInfo.CheckedChanged += AllInfo_CheckedChanged;
            // 
            // AllType
            // 
            AllType.AutoSize = true;
            AllType.Location = new Point(196, 37);
            AllType.Name = "AllType";
            AllType.Size = new Size(63, 19);
            AllType.TabIndex = 4;
            AllType.TabStop = true;
            AllType.Text = "AllType";
            AllType.UseVisualStyleBackColor = true;
            AllType.CheckedChanged += AllType_CheckedChanged;
            // 
            // AllMan
            // 
            AllMan.AutoSize = true;
            AllMan.Location = new Point(196, 62);
            AllMan.Name = "AllMan";
            AllMan.Size = new Size(111, 19);
            AllMan.TabIndex = 5;
            AllMan.TabStop = true;
            AllMan.Text = "AllManufacturer";
            AllMan.UseVisualStyleBackColor = true;
            AllMan.CheckedChanged += AllMan_CheckedChanged;
            // 
            // MaxQuantity
            // 
            MaxQuantity.AutoSize = true;
            MaxQuantity.Location = new Point(196, 84);
            MaxQuantity.Name = "MaxQuantity";
            MaxQuantity.Size = new Size(94, 19);
            MaxQuantity.TabIndex = 6;
            MaxQuantity.TabStop = true;
            MaxQuantity.Text = "MaxQuantity";
            MaxQuantity.UseVisualStyleBackColor = true;
            MaxQuantity.CheckedChanged += MaxQuantity_CheckedChanged;
            // 
            // MinQuantity
            // 
            MinQuantity.AutoSize = true;
            MinQuantity.Location = new Point(196, 109);
            MinQuantity.Name = "MinQuantity";
            MinQuantity.Size = new Size(92, 19);
            MinQuantity.TabIndex = 7;
            MinQuantity.TabStop = true;
            MinQuantity.Text = "MinQuantity";
            MinQuantity.UseVisualStyleBackColor = true;
            MinQuantity.CheckedChanged += MinQuantity_CheckedChanged;
            // 
            // MaxCP
            // 
            MaxCP.AutoSize = true;
            MaxCP.Location = new Point(196, 134);
            MaxCP.Name = "MaxCP";
            MaxCP.Size = new Size(98, 19);
            MaxCP.TabIndex = 8;
            MaxCP.TabStop = true;
            MaxCP.Text = "MaxCostPrice";
            MaxCP.UseVisualStyleBackColor = true;
            MaxCP.CheckedChanged += MaxCP_CheckedChanged;
            // 
            // MinCP
            // 
            MinCP.AutoSize = true;
            MinCP.Location = new Point(196, 159);
            MinCP.Name = "MinCP";
            MinCP.Size = new Size(96, 19);
            MinCP.TabIndex = 9;
            MinCP.TabStop = true;
            MinCP.Text = "MinCostPrice";
            MinCP.UseVisualStyleBackColor = true;
            MinCP.CheckedChanged += MinCP_CheckedChanged;
            // 
            // WareHouseByCategory
            // 
            WareHouseByCategory.AutoSize = true;
            WareHouseByCategory.Location = new Point(319, 12);
            WareHouseByCategory.Name = "WareHouseByCategory";
            WareHouseByCategory.Size = new Size(147, 19);
            WareHouseByCategory.TabIndex = 10;
            WareHouseByCategory.TabStop = true;
            WareHouseByCategory.Text = "WareHouseByCategory";
            WareHouseByCategory.UseVisualStyleBackColor = true;
            WareHouseByCategory.CheckedChanged += WareHouseByCategory_CheckedChanged_1;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Блок живлення", "Процесор", "Материнська плата", "Відеокарта", "Оперативна память", "Накопичувач", "Охолодження", "Термопаста", "Корпус" });
            comboBoxType.Location = new Point(472, 12);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(121, 23);
            comboBoxType.TabIndex = 11;
            comboBoxType.SelectedIndexChanged += WareHouseByCategory_CheckedChanged;
            // 
            // WareHouseByMan
            // 
            WareHouseByMan.AutoSize = true;
            WareHouseByMan.Location = new Point(319, 37);
            WareHouseByMan.Name = "WareHouseByMan";
            WareHouseByMan.Size = new Size(123, 19);
            WareHouseByMan.TabIndex = 12;
            WareHouseByMan.TabStop = true;
            WareHouseByMan.Text = "WareHouseByMan";
            WareHouseByMan.UseVisualStyleBackColor = true;
            WareHouseByMan.CheckedChanged += WareHouseByMan_CheckedChanged;
            // 
            // comboBoxMan
            // 
            comboBoxMan.FormattingEnabled = true;
            comboBoxMan.Items.AddRange(new object[] { "Cooler Master", "ASUS", "Intel", "AMD", "MSI", "Gigabyte", "Kingston Fury", "Samsung", "Grizzly", "Corsair" });
            comboBoxMan.Location = new Point(472, 41);
            comboBoxMan.Name = "comboBoxMan";
            comboBoxMan.Size = new Size(121, 23);
            comboBoxMan.TabIndex = 13;
            comboBoxMan.SelectedIndexChanged += WareHouseByMan_CheckedChanged;
            // 
            // Old
            // 
            Old.AutoSize = true;
            Old.Location = new Point(319, 62);
            Old.Name = "Old";
            Old.Size = new Size(44, 19);
            Old.TabIndex = 14;
            Old.TabStop = true;
            Old.Text = "Old";
            Old.UseVisualStyleBackColor = true;
            Old.CheckedChanged += Old_CheckedChanged;
            // 
            // AvarageByType
            // 
            AvarageByType.AutoSize = true;
            AvarageByType.Location = new Point(319, 84);
            AvarageByType.Name = "AvarageByType";
            AvarageByType.Size = new Size(105, 19);
            AvarageByType.TabIndex = 15;
            AvarageByType.TabStop = true;
            AvarageByType.Text = "AvarageByType";
            AvarageByType.UseVisualStyleBackColor = true;
            AvarageByType.CheckedChanged += AvarageByType_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AvarageByType);
            Controls.Add(Old);
            Controls.Add(comboBoxMan);
            Controls.Add(WareHouseByMan);
            Controls.Add(comboBoxType);
            Controls.Add(WareHouseByCategory);
            Controls.Add(MinCP);
            Controls.Add(MaxCP);
            Controls.Add(MinQuantity);
            Controls.Add(MaxQuantity);
            Controls.Add(AllMan);
            Controls.Add(AllType);
            Controls.Add(AllInfo);
            Controls.Add(dataGridView1);
            Controls.Add(ButtonDisconnect);
            Controls.Add(ButtonConnect);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonConnect;
        private Button ButtonDisconnect;
        private DataGridView dataGridView1;
        private RadioButton AllInfo;
        private RadioButton AllType;
        private RadioButton AllMan;
        private RadioButton MaxQuantity;
        private RadioButton MinQuantity;
        private RadioButton MaxCP;
        private RadioButton MinCP;
        private RadioButton WareHouseByCategory;
        private ComboBox comboBoxType;
        private RadioButton WareHouseByMan;
        private ComboBox comboBoxMan;
        private RadioButton Old;
        private RadioButton AvarageByType;
    }
}