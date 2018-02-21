namespace AvitaPharmacy
{
    partial class AdminSaleForm
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cartDataView = new System.Windows.Forms.DataGridView();
            this.Finish = new System.Windows.Forms.Button();
            this.addSelectedMedicine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.amountWanted = new System.Windows.Forms.TextBox();
            this.availableAmount = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amountTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.avitaDataSet8 = new AvitaPharmacy.AvitaDataSet8();
            this.medicineTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicineTableTableAdapter = new AvitaPharmacy.AvitaDataSet8TableAdapters.MedicineTableTableAdapter();
            this.medicineNameComboBox = new System.Windows.Forms.ComboBox();
            this.quantityError = new System.Windows.Forms.Label();
            this.removeSelectedMedicine = new System.Windows.Forms.Button();
            this.tax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buyer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.subTotalBox = new System.Windows.Forms.TextBox();
            this.Rest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avitaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(331, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(126, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Choose Medicine ID";
            // 
            // cartDataView
            // 
            this.cartDataView.AllowUserToAddRows = false;
            this.cartDataView.AllowUserToDeleteRows = false;
            this.cartDataView.BackgroundColor = System.Drawing.Color.White;
            this.cartDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataView.Location = new System.Drawing.Point(23, 160);
            this.cartDataView.Name = "cartDataView";
            this.cartDataView.ReadOnly = true;
            this.cartDataView.Size = new System.Drawing.Size(743, 438);
            this.cartDataView.TabIndex = 40;
            // 
            // Finish
            // 
            this.Finish.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Finish.Enabled = false;
            this.Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finish.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Finish.Location = new System.Drawing.Point(964, 363);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(75, 29);
            this.Finish.TabIndex = 43;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // addSelectedMedicine
            // 
            this.addSelectedMedicine.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedMedicine.Enabled = false;
            this.addSelectedMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSelectedMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSelectedMedicine.ForeColor = System.Drawing.Color.White;
            this.addSelectedMedicine.Location = new System.Drawing.Point(692, 90);
            this.addSelectedMedicine.Name = "addSelectedMedicine";
            this.addSelectedMedicine.Size = new System.Drawing.Size(100, 31);
            this.addSelectedMedicine.TabIndex = 45;
            this.addSelectedMedicine.Text = "Add Medicine";
            this.addSelectedMedicine.UseVisualStyleBackColor = false;
            this.addSelectedMedicine.Click += new System.EventHandler(this.addSelectedMedicine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Available";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountWanted
            // 
            this.amountWanted.Location = new System.Drawing.Point(341, 99);
            this.amountWanted.Name = "amountWanted";
            this.amountWanted.Size = new System.Drawing.Size(53, 20);
            this.amountWanted.TabIndex = 47;
            this.amountWanted.TextChanged += new System.EventHandler(this.amountWanted_TextChanged);
            this.amountWanted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountWanted_KeyPress);
            // 
            // availableAmount
            // 
            this.availableAmount.Location = new System.Drawing.Point(415, 99);
            this.availableAmount.Name = "availableAmount";
            this.availableAmount.ReadOnly = true;
            this.availableAmount.Size = new System.Drawing.Size(53, 20);
            this.availableAmount.TabIndex = 48;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(493, 99);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(53, 20);
            this.price.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Price";
            // 
            // amountTotal
            // 
            this.amountTotal.Location = new System.Drawing.Point(568, 99);
            this.amountTotal.Name = "amountTotal";
            this.amountTotal.ReadOnly = true;
            this.amountTotal.Size = new System.Drawing.Size(100, 20);
            this.amountTotal.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Amount Total";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(909, 318);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(151, 20);
            this.total.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(839, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Total";
            // 
            // avitaDataSet8
            // 
            this.avitaDataSet8.DataSetName = "AvitaDataSet8";
            this.avitaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicineTableBindingSource
            // 
            this.medicineTableBindingSource.DataMember = "MedicineTable";
            this.medicineTableBindingSource.DataSource = this.avitaDataSet8;
            // 
            // medicineTableTableAdapter
            // 
            this.medicineTableTableAdapter.ClearBeforeFill = true;
            // 
            // medicineNameComboBox
            // 
            this.medicineNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicineNameComboBox.FormattingEnabled = true;
            this.medicineNameComboBox.Items.AddRange(new object[] {
            ""});
            this.medicineNameComboBox.Location = new System.Drawing.Point(130, 98);
            this.medicineNameComboBox.Name = "medicineNameComboBox";
            this.medicineNameComboBox.Size = new System.Drawing.Size(169, 21);
            this.medicineNameComboBox.Sorted = true;
            this.medicineNameComboBox.TabIndex = 55;
            this.medicineNameComboBox.SelectedValueChanged += new System.EventHandler(this.medicineNameComboBox_SelectedValueChanged);
            // 
            // quantityError
            // 
            this.quantityError.AutoSize = true;
            this.quantityError.BackColor = System.Drawing.SystemColors.Window;
            this.quantityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityError.ForeColor = System.Drawing.Color.Red;
            this.quantityError.Location = new System.Drawing.Point(323, 126);
            this.quantityError.Name = "quantityError";
            this.quantityError.Size = new System.Drawing.Size(0, 17);
            this.quantityError.TabIndex = 56;
            // 
            // removeSelectedMedicine
            // 
            this.removeSelectedMedicine.BackColor = System.Drawing.Color.Red;
            this.removeSelectedMedicine.Enabled = false;
            this.removeSelectedMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedMedicine.ForeColor = System.Drawing.Color.White;
            this.removeSelectedMedicine.Location = new System.Drawing.Point(804, 90);
            this.removeSelectedMedicine.Name = "removeSelectedMedicine";
            this.removeSelectedMedicine.Size = new System.Drawing.Size(145, 32);
            this.removeSelectedMedicine.TabIndex = 57;
            this.removeSelectedMedicine.Text = "Remove Medicine";
            this.removeSelectedMedicine.UseVisualStyleBackColor = false;
            this.removeSelectedMedicine.Click += new System.EventHandler(this.removeSelectedMedicine_Click);
            // 
            // tax
            // 
            this.tax.Location = new System.Drawing.Point(909, 282);
            this.tax.Name = "tax";
            this.tax.ReadOnly = true;
            this.tax.Size = new System.Drawing.Size(151, 20);
            this.tax.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(839, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(822, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Buyer\'s Name or Tin Number";
            // 
            // buyer
            // 
            this.buyer.Location = new System.Drawing.Point(824, 202);
            this.buyer.Name = "buyer";
            this.buyer.Size = new System.Drawing.Size(236, 20);
            this.buyer.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(822, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = "Sub Total";
            // 
            // subTotalBox
            // 
            this.subTotalBox.Location = new System.Drawing.Point(909, 245);
            this.subTotalBox.Name = "subTotalBox";
            this.subTotalBox.ReadOnly = true;
            this.subTotalBox.Size = new System.Drawing.Size(151, 20);
            this.subTotalBox.TabIndex = 63;
            // 
            // Rest
            // 
            this.Rest.BackColor = System.Drawing.Color.Red;
            this.Rest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rest.ForeColor = System.Drawing.SystemColors.Control;
            this.Rest.Location = new System.Drawing.Point(865, 363);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(75, 29);
            this.Rest.TabIndex = 42;
            this.Rest.Text = "Reset";
            this.Rest.UseVisualStyleBackColor = false;
            this.Rest.Click += new System.EventHandler(this.Rest_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AvitaPharmacy.Properties.Resources.back2;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(35, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.ControlBox = false;
            this.Controls.Add(this.subTotalBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buyer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.removeSelectedMedicine);
            this.Controls.Add(this.quantityError);
            this.Controls.Add(this.medicineNameComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.availableAmount);
            this.Controls.Add(this.amountWanted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSelectedMedicine);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.Rest);
            this.Controls.Add(this.cartDataView);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.AdminSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avitaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView cartDataView;
        private System.Windows.Forms.Button Rest;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button addSelectedMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountWanted;
        private System.Windows.Forms.TextBox availableAmount;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label4;
        private AvitaDataSet8 avitaDataSet8;
        private System.Windows.Forms.BindingSource medicineTableBindingSource;
        private AvitaDataSet8TableAdapters.MedicineTableTableAdapter medicineTableTableAdapter;
        private System.Windows.Forms.ComboBox medicineNameComboBox;
        private System.Windows.Forms.Label quantityError;
        private System.Windows.Forms.Button removeSelectedMedicine;
        private System.Windows.Forms.TextBox tax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox buyer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox subTotalBox;
    }
}