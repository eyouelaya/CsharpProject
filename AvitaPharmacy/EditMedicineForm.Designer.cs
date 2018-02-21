namespace AvitaPharmacy
{
    partial class EditMedicineForm
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.editQuantity = new System.Windows.Forms.TextBox();
            this.editSellingPrice = new System.Windows.Forms.TextBox();
            this.editManufacturer = new System.Windows.Forms.TextBox();
            this.editMedicineName = new System.Windows.Forms.TextBox();
            this.editCategory = new System.Windows.Forms.TextBox();
            this.editBuyingPrice = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medicineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiringDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avitaDataSet1 = new AvitaPharmacy.AvitaDataSet1();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.searchKey = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.medicineTableTableAdapter = new AvitaPharmacy.AvitaDataSet1TableAdapters.MedicineTableTableAdapter();
            this.editProductionDate = new System.Windows.Forms.DateTimePicker();
            this.editExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.editCategoryError = new System.Windows.Forms.Label();
            this.editManufacturerError = new System.Windows.Forms.Label();
            this.editQuantityError = new System.Windows.Forms.Label();
            this.editProductionDateError = new System.Windows.Forms.Label();
            this.editMedicineNameError = new System.Windows.Forms.Label();
            this.editBuyingPriceError = new System.Windows.Forms.Label();
            this.editSellingPriceError = new System.Windows.Forms.Label();
            this.editMedicine = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avitaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medicine Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Catagory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Manufacturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Expiry Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Production Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 541);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Selling Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Buying Price";
            // 
            // editQuantity
            // 
            this.editQuantity.Location = new System.Drawing.Point(166, 305);
            this.editQuantity.Name = "editQuantity";
            this.editQuantity.Size = new System.Drawing.Size(183, 20);
            this.editQuantity.TabIndex = 13;
            this.editQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editSellingPrice
            // 
            this.editSellingPrice.Location = new System.Drawing.Point(164, 543);
            this.editSellingPrice.Name = "editSellingPrice";
            this.editSellingPrice.Size = new System.Drawing.Size(183, 20);
            this.editSellingPrice.TabIndex = 14;
            this.editSellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editManufacturer
            // 
            this.editManufacturer.Location = new System.Drawing.Point(166, 249);
            this.editManufacturer.Name = "editManufacturer";
            this.editManufacturer.Size = new System.Drawing.Size(183, 20);
            this.editManufacturer.TabIndex = 15;
            this.editManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editMedicineName
            // 
            this.editMedicineName.Location = new System.Drawing.Point(166, 140);
            this.editMedicineName.Name = "editMedicineName";
            this.editMedicineName.Size = new System.Drawing.Size(183, 20);
            this.editMedicineName.TabIndex = 16;
            this.editMedicineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editCategory
            // 
            this.editCategory.Location = new System.Drawing.Point(166, 195);
            this.editCategory.Name = "editCategory";
            this.editCategory.Size = new System.Drawing.Size(183, 20);
            this.editCategory.TabIndex = 17;
            this.editCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editBuyingPrice
            // 
            this.editBuyingPrice.Location = new System.Drawing.Point(166, 488);
            this.editBuyingPrice.Name = "editBuyingPrice";
            this.editBuyingPrice.Size = new System.Drawing.Size(183, 20);
            this.editBuyingPrice.TabIndex = 18;
            this.editBuyingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineIDDataGridViewTextBoxColumn,
            this.medicineNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn,
            this.productionDateDataGridViewTextBoxColumn,
            this.expiringDateDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.buyingPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicineTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(359, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(693, 448);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // medicineIDDataGridViewTextBoxColumn
            // 
            this.medicineIDDataGridViewTextBoxColumn.DataPropertyName = "MedicineID";
            this.medicineIDDataGridViewTextBoxColumn.HeaderText = "MedicineID";
            this.medicineIDDataGridViewTextBoxColumn.Name = "medicineIDDataGridViewTextBoxColumn";
            this.medicineIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicineNameDataGridViewTextBoxColumn
            // 
            this.medicineNameDataGridViewTextBoxColumn.DataPropertyName = "Medicine_Name";
            this.medicineNameDataGridViewTextBoxColumn.HeaderText = "Medicine_Name";
            this.medicineNameDataGridViewTextBoxColumn.Name = "medicineNameDataGridViewTextBoxColumn";
            this.medicineNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "Entry_Date";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "Entry_Date";
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            this.entryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "Production_Date";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "Production_Date";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            this.productionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expiringDateDataGridViewTextBoxColumn
            // 
            this.expiringDateDataGridViewTextBoxColumn.DataPropertyName = "Expiring_Date";
            this.expiringDateDataGridViewTextBoxColumn.HeaderText = "Expiring_Date";
            this.expiringDateDataGridViewTextBoxColumn.Name = "expiringDateDataGridViewTextBoxColumn";
            this.expiringDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "Selling_Price";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling_Price";
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            this.sellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buyingPriceDataGridViewTextBoxColumn
            // 
            this.buyingPriceDataGridViewTextBoxColumn.DataPropertyName = "Buying_Price";
            this.buyingPriceDataGridViewTextBoxColumn.HeaderText = "Buying_Price";
            this.buyingPriceDataGridViewTextBoxColumn.Name = "buyingPriceDataGridViewTextBoxColumn";
            this.buyingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicineTableBindingSource
            // 
            this.medicineTableBindingSource.DataMember = "MedicineTable";
            this.medicineTableBindingSource.DataSource = this.avitaDataSet1;
            // 
            // avitaDataSet1
            // 
            this.avitaDataSet1.DataSetName = "AvitaDataSet1";
            this.avitaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(255, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Search";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(554, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 24);
            this.label12.TabIndex = 26;
            this.label12.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "None"});
            this.categoryComboBox.Location = new System.Drawing.Point(639, 69);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 25;
            this.categoryComboBox.Text = "None";
            // 
            // searchKey
            // 
            this.searchKey.Location = new System.Drawing.Point(349, 69);
            this.searchKey.Name = "searchKey";
            this.searchKey.Size = new System.Drawing.Size(191, 20);
            this.searchKey.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // medicineTableTableAdapter
            // 
            this.medicineTableTableAdapter.ClearBeforeFill = true;
            // 
            // editProductionDate
            // 
            this.editProductionDate.Location = new System.Drawing.Point(164, 364);
            this.editProductionDate.Name = "editProductionDate";
            this.editProductionDate.Size = new System.Drawing.Size(183, 20);
            this.editProductionDate.TabIndex = 29;
            // 
            // editExpiryDate
            // 
            this.editExpiryDate.Location = new System.Drawing.Point(164, 429);
            this.editExpiryDate.Name = "editExpiryDate";
            this.editExpiryDate.Size = new System.Drawing.Size(183, 20);
            this.editExpiryDate.TabIndex = 30;
            // 
            // editCategoryError
            // 
            this.editCategoryError.AutoSize = true;
            this.editCategoryError.BackColor = System.Drawing.Color.Transparent;
            this.editCategoryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCategoryError.ForeColor = System.Drawing.Color.Red;
            this.editCategoryError.Location = new System.Drawing.Point(169, 223);
            this.editCategoryError.Name = "editCategoryError";
            this.editCategoryError.Size = new System.Drawing.Size(0, 17);
            this.editCategoryError.TabIndex = 32;
            // 
            // editManufacturerError
            // 
            this.editManufacturerError.AutoSize = true;
            this.editManufacturerError.BackColor = System.Drawing.Color.Transparent;
            this.editManufacturerError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editManufacturerError.ForeColor = System.Drawing.Color.Red;
            this.editManufacturerError.Location = new System.Drawing.Point(170, 278);
            this.editManufacturerError.Name = "editManufacturerError";
            this.editManufacturerError.Size = new System.Drawing.Size(0, 17);
            this.editManufacturerError.TabIndex = 33;
            // 
            // editQuantityError
            // 
            this.editQuantityError.AutoSize = true;
            this.editQuantityError.BackColor = System.Drawing.Color.Transparent;
            this.editQuantityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editQuantityError.ForeColor = System.Drawing.Color.Red;
            this.editQuantityError.Location = new System.Drawing.Point(167, 333);
            this.editQuantityError.Name = "editQuantityError";
            this.editQuantityError.Size = new System.Drawing.Size(0, 17);
            this.editQuantityError.TabIndex = 34;
            // 
            // editProductionDateError
            // 
            this.editProductionDateError.AutoSize = true;
            this.editProductionDateError.BackColor = System.Drawing.Color.Transparent;
            this.editProductionDateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductionDateError.ForeColor = System.Drawing.Color.Red;
            this.editProductionDateError.Location = new System.Drawing.Point(169, 395);
            this.editProductionDateError.Name = "editProductionDateError";
            this.editProductionDateError.Size = new System.Drawing.Size(0, 17);
            this.editProductionDateError.TabIndex = 35;
            // 
            // editMedicineNameError
            // 
            this.editMedicineNameError.AutoSize = true;
            this.editMedicineNameError.BackColor = System.Drawing.Color.Transparent;
            this.editMedicineNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMedicineNameError.ForeColor = System.Drawing.Color.Red;
            this.editMedicineNameError.Location = new System.Drawing.Point(170, 167);
            this.editMedicineNameError.Name = "editMedicineNameError";
            this.editMedicineNameError.Size = new System.Drawing.Size(0, 17);
            this.editMedicineNameError.TabIndex = 36;
            // 
            // editBuyingPriceError
            // 
            this.editBuyingPriceError.AutoSize = true;
            this.editBuyingPriceError.BackColor = System.Drawing.Color.Transparent;
            this.editBuyingPriceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBuyingPriceError.ForeColor = System.Drawing.Color.Red;
            this.editBuyingPriceError.Location = new System.Drawing.Point(170, 517);
            this.editBuyingPriceError.Name = "editBuyingPriceError";
            this.editBuyingPriceError.Size = new System.Drawing.Size(0, 17);
            this.editBuyingPriceError.TabIndex = 37;
            // 
            // editSellingPriceError
            // 
            this.editSellingPriceError.AutoSize = true;
            this.editSellingPriceError.BackColor = System.Drawing.Color.Transparent;
            this.editSellingPriceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSellingPriceError.ForeColor = System.Drawing.Color.Red;
            this.editSellingPriceError.Location = new System.Drawing.Point(169, 570);
            this.editSellingPriceError.Name = "editSellingPriceError";
            this.editSellingPriceError.Size = new System.Drawing.Size(0, 17);
            this.editSellingPriceError.TabIndex = 38;
            // 
            // editMedicine
            // 
            this.editMedicine.BackgroundImage = global::AvitaPharmacy.Properties.Resources.Save;
            this.editMedicine.FlatAppearance.BorderSize = 0;
            this.editMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editMedicine.Location = new System.Drawing.Point(896, 41);
            this.editMedicine.Name = "editMedicine";
            this.editMedicine.Size = new System.Drawing.Size(75, 75);
            this.editMedicine.TabIndex = 40;
            this.editMedicine.UseVisualStyleBackColor = true;
            this.editMedicine.Click += new System.EventHandler(this.addNewMedicine_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::AvitaPharmacy.Properties.Resources.search;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(777, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 35);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AvitaPharmacy.Properties.Resources.back2;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(68, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.BackgroundImage = global::AvitaPharmacy.Properties.Resources.green_back;
            this.clearSearchButton.FlatAppearance.BorderSize = 0;
            this.clearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchButton.Location = new System.Drawing.Point(833, 58);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(30, 30);
            this.clearSearchButton.TabIndex = 41;
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // EditMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.ControlBox = false;
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.editMedicine);
            this.Controls.Add(this.editSellingPriceError);
            this.Controls.Add(this.editBuyingPriceError);
            this.Controls.Add(this.editMedicineNameError);
            this.Controls.Add(this.editProductionDateError);
            this.Controls.Add(this.editQuantityError);
            this.Controls.Add(this.editManufacturerError);
            this.Controls.Add(this.editCategoryError);
            this.Controls.Add(this.editExpiryDate);
            this.Controls.Add(this.editProductionDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.searchKey);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editBuyingPrice);
            this.Controls.Add(this.editCategory);
            this.Controls.Add(this.editMedicineName);
            this.Controls.Add(this.editManufacturer);
            this.Controls.Add(this.editSellingPrice);
            this.Controls.Add(this.editQuantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditMedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avitaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox editQuantity;
        private System.Windows.Forms.TextBox editSellingPrice;
        private System.Windows.Forms.TextBox editManufacturer;
        private System.Windows.Forms.TextBox editMedicineName;
        private System.Windows.Forms.TextBox editCategory;
        private System.Windows.Forms.TextBox editBuyingPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox searchKey;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private AvitaDataSet1 avitaDataSet1;
        private System.Windows.Forms.BindingSource medicineTableBindingSource;
        private AvitaDataSet1TableAdapters.MedicineTableTableAdapter medicineTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiringDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker editProductionDate;
        private System.Windows.Forms.DateTimePicker editExpiryDate;
        private System.Windows.Forms.Label editCategoryError;
        private System.Windows.Forms.Label editManufacturerError;
        private System.Windows.Forms.Label editQuantityError;
        private System.Windows.Forms.Label editProductionDateError;
        private System.Windows.Forms.Label editMedicineNameError;
        private System.Windows.Forms.Label editBuyingPriceError;
        private System.Windows.Forms.Label editSellingPriceError;
        private System.Windows.Forms.Button editMedicine;
        private System.Windows.Forms.Button clearSearchButton;
    }
}