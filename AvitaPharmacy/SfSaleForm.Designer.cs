namespace AvitaPharmacy
{
    partial class SfSaleForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedMedicine = new System.Windows.Forms.Button();
            this.addSelectedMedicine = new System.Windows.Forms.Button();
            this.subTotalBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buyer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.cartDataView = new System.Windows.Forms.DataGridView();
            this.medicineNameComboBox = new System.Windows.Forms.ComboBox();
            this.amountTotal = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.availableAmount = new System.Windows.Forms.TextBox();
            this.amountWanted = new System.Windows.Forms.TextBox();
            this.quantityError = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.Finish = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Amount Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Available";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(252, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 57;
            this.label12.Text = "Quantity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(62, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 20);
            this.label11.TabIndex = 55;
            this.label11.Text = "Choose Medicine ID";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AvitaPharmacy.Properties.Resources.Settings;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1000, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 72;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem1.Text = "Log Out";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // removeSelectedMedicine
            // 
            this.removeSelectedMedicine.BackColor = System.Drawing.Color.Red;
            this.removeSelectedMedicine.Enabled = false;
            this.removeSelectedMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedMedicine.ForeColor = System.Drawing.Color.White;
            this.removeSelectedMedicine.Location = new System.Drawing.Point(784, 102);
            this.removeSelectedMedicine.Name = "removeSelectedMedicine";
            this.removeSelectedMedicine.Size = new System.Drawing.Size(145, 32);
            this.removeSelectedMedicine.TabIndex = 74;
            this.removeSelectedMedicine.Text = "Remove Medicine";
            this.removeSelectedMedicine.UseVisualStyleBackColor = false;
            this.removeSelectedMedicine.Click += new System.EventHandler(this.removeSelectedMedicine_Click);
            // 
            // addSelectedMedicine
            // 
            this.addSelectedMedicine.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedMedicine.Enabled = false;
            this.addSelectedMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSelectedMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSelectedMedicine.ForeColor = System.Drawing.Color.White;
            this.addSelectedMedicine.Location = new System.Drawing.Point(672, 102);
            this.addSelectedMedicine.Name = "addSelectedMedicine";
            this.addSelectedMedicine.Size = new System.Drawing.Size(100, 31);
            this.addSelectedMedicine.TabIndex = 73;
            this.addSelectedMedicine.Text = "Add Medicine";
            this.addSelectedMedicine.UseVisualStyleBackColor = false;
            this.addSelectedMedicine.Click += new System.EventHandler(this.addSelectedMedicine_Click);
            // 
            // subTotalBox
            // 
            this.subTotalBox.Location = new System.Drawing.Point(884, 267);
            this.subTotalBox.Name = "subTotalBox";
            this.subTotalBox.ReadOnly = true;
            this.subTotalBox.Size = new System.Drawing.Size(151, 20);
            this.subTotalBox.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(797, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 83;
            this.label7.Text = "Sub Total";
            // 
            // buyer
            // 
            this.buyer.Location = new System.Drawing.Point(799, 224);
            this.buyer.Name = "buyer";
            this.buyer.Size = new System.Drawing.Size(236, 20);
            this.buyer.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(797, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 20);
            this.label6.TabIndex = 81;
            this.label6.Text = "Buyer\'s Name or Tin Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(814, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Tax";
            // 
            // tax
            // 
            this.tax.Location = new System.Drawing.Point(884, 304);
            this.tax.Name = "tax";
            this.tax.ReadOnly = true;
            this.tax.Size = new System.Drawing.Size(151, 20);
            this.tax.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(814, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 78;
            this.label8.Text = "Total";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(884, 340);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(151, 20);
            this.total.TabIndex = 77;
            // 
            // cartDataView
            // 
            this.cartDataView.AllowUserToAddRows = false;
            this.cartDataView.AllowUserToDeleteRows = false;
            this.cartDataView.BackgroundColor = System.Drawing.Color.White;
            this.cartDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataView.Location = new System.Drawing.Point(29, 182);
            this.cartDataView.Name = "cartDataView";
            this.cartDataView.ReadOnly = true;
            this.cartDataView.Size = new System.Drawing.Size(743, 438);
            this.cartDataView.TabIndex = 85;
            // 
            // medicineNameComboBox
            // 
            this.medicineNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicineNameComboBox.FormattingEnabled = true;
            this.medicineNameComboBox.Items.AddRange(new object[] {
            ""});
            this.medicineNameComboBox.Location = new System.Drawing.Point(66, 108);
            this.medicineNameComboBox.Name = "medicineNameComboBox";
            this.medicineNameComboBox.Size = new System.Drawing.Size(169, 21);
            this.medicineNameComboBox.Sorted = true;
            this.medicineNameComboBox.TabIndex = 86;
            this.medicineNameComboBox.SelectedValueChanged += new System.EventHandler(this.medicineNameComboBox_SelectedValueChanged);
            // 
            // amountTotal
            // 
            this.amountTotal.Location = new System.Drawing.Point(483, 109);
            this.amountTotal.Name = "amountTotal";
            this.amountTotal.ReadOnly = true;
            this.amountTotal.Size = new System.Drawing.Size(100, 20);
            this.amountTotal.TabIndex = 90;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(408, 109);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(53, 20);
            this.price.TabIndex = 89;
            // 
            // availableAmount
            // 
            this.availableAmount.Location = new System.Drawing.Point(330, 109);
            this.availableAmount.Name = "availableAmount";
            this.availableAmount.ReadOnly = true;
            this.availableAmount.Size = new System.Drawing.Size(53, 20);
            this.availableAmount.TabIndex = 88;
            // 
            // amountWanted
            // 
            this.amountWanted.Location = new System.Drawing.Point(256, 109);
            this.amountWanted.Name = "amountWanted";
            this.amountWanted.Size = new System.Drawing.Size(53, 20);
            this.amountWanted.TabIndex = 87;
            this.amountWanted.TextChanged += new System.EventHandler(this.amountWanted_TextChanged);
            this.amountWanted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountWanted_KeyPress);
            // 
            // quantityError
            // 
            this.quantityError.AutoSize = true;
            this.quantityError.BackColor = System.Drawing.SystemColors.Window;
            this.quantityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityError.ForeColor = System.Drawing.Color.Red;
            this.quantityError.Location = new System.Drawing.Point(253, 132);
            this.quantityError.Name = "quantityError";
            this.quantityError.Size = new System.Drawing.Size(0, 17);
            this.quantityError.TabIndex = 91;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.user.Location = new System.Drawing.Point(742, 34);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(0, 23);
            this.user.TabIndex = 92;
            this.user.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Finish
            // 
            this.Finish.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Finish.Enabled = false;
            this.Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finish.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Finish.Location = new System.Drawing.Point(934, 391);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(75, 29);
            this.Finish.TabIndex = 94;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(835, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 93;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Rest_Click);
            // 
            // SfSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.ControlBox = false;
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.user);
            this.Controls.Add(this.quantityError);
            this.Controls.Add(this.amountTotal);
            this.Controls.Add(this.price);
            this.Controls.Add(this.availableAmount);
            this.Controls.Add(this.amountWanted);
            this.Controls.Add(this.medicineNameComboBox);
            this.Controls.Add(this.cartDataView);
            this.Controls.Add(this.subTotalBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buyer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.total);
            this.Controls.Add(this.removeSelectedMedicine);
            this.Controls.Add(this.addSelectedMedicine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SfSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.SfSaleForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button removeSelectedMedicine;
        private System.Windows.Forms.Button addSelectedMedicine;
        private System.Windows.Forms.TextBox subTotalBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox buyer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.DataGridView cartDataView;
        private System.Windows.Forms.ComboBox medicineNameComboBox;
        private System.Windows.Forms.TextBox amountTotal;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox availableAmount;
        private System.Windows.Forms.TextBox amountWanted;
        private System.Windows.Forms.Label quantityError;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button button3;
    }
}