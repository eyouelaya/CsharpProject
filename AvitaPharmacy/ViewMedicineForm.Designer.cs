namespace AvitaPharmacy
{
    partial class ViewMedicineForm
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
            this.viewMedicineGridView = new System.Windows.Forms.DataGridView();
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
            this.avitaDataSet = new AvitaPharmacy.AvitaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.searchKey = new System.Windows.Forms.TextBox();
            this.medicineTableTableAdapter = new AvitaPharmacy.AvitaDataSetTableAdapters.MedicineTableTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.searchMedicine = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewMedicineGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avitaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // viewMedicineGridView
            // 
            this.viewMedicineGridView.AutoGenerateColumns = false;
            this.viewMedicineGridView.BackgroundColor = System.Drawing.Color.White;
            this.viewMedicineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewMedicineGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.viewMedicineGridView.DataSource = this.medicineTableBindingSource;
            this.viewMedicineGridView.Location = new System.Drawing.Point(30, 157);
            this.viewMedicineGridView.Name = "viewMedicineGridView";
            this.viewMedicineGridView.RowHeadersWidth = 40;
            this.viewMedicineGridView.Size = new System.Drawing.Size(1043, 485);
            this.viewMedicineGridView.TabIndex = 0;
            // 
            // medicineIDDataGridViewTextBoxColumn
            // 
            this.medicineIDDataGridViewTextBoxColumn.DataPropertyName = "MedicineID";
            this.medicineIDDataGridViewTextBoxColumn.HeaderText = "MedicineID";
            this.medicineIDDataGridViewTextBoxColumn.Name = "medicineIDDataGridViewTextBoxColumn";
            // 
            // medicineNameDataGridViewTextBoxColumn
            // 
            this.medicineNameDataGridViewTextBoxColumn.DataPropertyName = "Medicine_Name";
            this.medicineNameDataGridViewTextBoxColumn.HeaderText = "Medicine_Name";
            this.medicineNameDataGridViewTextBoxColumn.Name = "medicineNameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "Entry_Date";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "Entry_Date";
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "Production_Date";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "Production_Date";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            // 
            // expiringDateDataGridViewTextBoxColumn
            // 
            this.expiringDateDataGridViewTextBoxColumn.DataPropertyName = "Expiring_Date";
            this.expiringDateDataGridViewTextBoxColumn.HeaderText = "Expiring_Date";
            this.expiringDateDataGridViewTextBoxColumn.Name = "expiringDateDataGridViewTextBoxColumn";
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "Selling_Price";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling_Price";
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            // 
            // buyingPriceDataGridViewTextBoxColumn
            // 
            this.buyingPriceDataGridViewTextBoxColumn.DataPropertyName = "Buying_Price";
            this.buyingPriceDataGridViewTextBoxColumn.HeaderText = "Buying_Price";
            this.buyingPriceDataGridViewTextBoxColumn.Name = "buyingPriceDataGridViewTextBoxColumn";
            // 
            // medicineTableBindingSource
            // 
            this.medicineTableBindingSource.DataMember = "MedicineTable";
            this.medicineTableBindingSource.DataSource = this.avitaDataSet;
            // 
            // avitaDataSet
            // 
            this.avitaDataSet.DataSetName = "AvitaDataSet";
            this.avitaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // searchKey
            // 
            this.searchKey.Location = new System.Drawing.Point(291, 95);
            this.searchKey.Name = "searchKey";
            this.searchKey.Size = new System.Drawing.Size(191, 20);
            this.searchKey.TabIndex = 2;
            // 
            // medicineTableTableAdapter
            // 
            this.medicineTableTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "None"});
            this.categoryComboBox.Location = new System.Drawing.Point(581, 95);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 3;
            this.categoryComboBox.Text = "None";
            // 
            // searchMedicine
            // 
            this.searchMedicine.BackgroundImage = global::AvitaPharmacy.Properties.Resources.search1;
            this.searchMedicine.FlatAppearance.BorderSize = 0;
            this.searchMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchMedicine.Location = new System.Drawing.Point(728, 82);
            this.searchMedicine.Name = "searchMedicine";
            this.searchMedicine.Size = new System.Drawing.Size(53, 45);
            this.searchMedicine.TabIndex = 6;
            this.searchMedicine.UseVisualStyleBackColor = true;
            this.searchMedicine.Click += new System.EventHandler(this.searchMedicine_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AvitaPharmacy.Properties.Resources.back2;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(54, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.BackgroundImage = global::AvitaPharmacy.Properties.Resources.green_back;
            this.clearSearchButton.FlatAppearance.BorderSize = 0;
            this.clearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchButton.Location = new System.Drawing.Point(800, 88);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(30, 30);
            this.clearSearchButton.TabIndex = 42;
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // ViewMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.ControlBox = false;
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.searchMedicine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.searchKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewMedicineGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewMedicineGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avitaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewMedicineGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchKey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button searchMedicine;
        private AvitaDataSet avitaDataSet;
        private System.Windows.Forms.BindingSource medicineTableBindingSource;
        private AvitaDataSetTableAdapters.MedicineTableTableAdapter medicineTableTableAdapter;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button clearSearchButton;

    }
}