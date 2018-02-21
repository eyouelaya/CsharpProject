namespace AvitaPharmacy
{
    partial class ExpiryDateForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.expiredDataGridView = new System.Windows.Forms.DataGridView();
            this.avitaDataSet4 = new AvitaPharmacy.AvitaDataSet4();
            this.medicineTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicineTableTableAdapter = new AvitaPharmacy.AvitaDataSet4TableAdapters.MedicineTableTableAdapter();
            this.expiryDateKey = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.expiredDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avitaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AvitaPharmacy.Properties.Resources.back2;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(46, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input Expiry Before Date";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::AvitaPharmacy.Properties.Resources.search1;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(703, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 42);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // expiredDataGridView
            // 
            this.expiredDataGridView.AllowUserToAddRows = false;
            this.expiredDataGridView.AllowUserToDeleteRows = false;
            this.expiredDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.expiredDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expiredDataGridView.Location = new System.Drawing.Point(46, 186);
            this.expiredDataGridView.Name = "expiredDataGridView";
            this.expiredDataGridView.ReadOnly = true;
            this.expiredDataGridView.Size = new System.Drawing.Size(986, 415);
            this.expiredDataGridView.TabIndex = 14;
            // 
            // avitaDataSet4
            // 
            this.avitaDataSet4.DataSetName = "AvitaDataSet4";
            this.avitaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicineTableBindingSource
            // 
            this.medicineTableBindingSource.DataMember = "MedicineTable";
            this.medicineTableBindingSource.DataSource = this.avitaDataSet4;
            // 
            // medicineTableTableAdapter
            // 
            this.medicineTableTableAdapter.ClearBeforeFill = true;
            // 
            // expiryDateKey
            // 
            this.expiryDateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDateKey.Location = new System.Drawing.Point(442, 94);
            this.expiryDateKey.Name = "expiryDateKey";
            this.expiryDateKey.Size = new System.Drawing.Size(255, 23);
            this.expiryDateKey.TabIndex = 15;
            // 
            // ExpiryDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.expiryDateKey);
            this.Controls.Add(this.expiredDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpiryDateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expiredDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avitaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView expiredDataGridView;
        private AvitaDataSet4 avitaDataSet4;
        private System.Windows.Forms.BindingSource medicineTableBindingSource;
        private AvitaDataSet4TableAdapters.MedicineTableTableAdapter medicineTableTableAdapter;
        private System.Windows.Forms.DateTimePicker expiryDateKey;
    }
}