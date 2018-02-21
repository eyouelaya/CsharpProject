namespace AvitaPharmacy
{
    partial class PrintPreview
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.receiptPreview = new System.Windows.Forms.WebBrowser();
            this.closeButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.receiptPreview);
            this.panel1.Location = new System.Drawing.Point(32, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 512);
            this.panel1.TabIndex = 0;
            // 
            // receiptPreview
            // 
            this.receiptPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptPreview.Location = new System.Drawing.Point(0, 0);
            this.receiptPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.receiptPreview.Name = "receiptPreview";
            this.receiptPreview.Size = new System.Drawing.Size(836, 512);
            this.receiptPreview.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::AvitaPharmacy.Properties.Resources.Close2;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(771, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(57, 59);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.White;
            this.printButton.BackgroundImage = global::AvitaPharmacy.Properties.Resources.print1;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Location = new System.Drawing.Point(673, 12);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(60, 60);
            this.printButton.TabIndex = 1;
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // PrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(120, 120);
            this.Name = "PrintPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PrintPreview";
            this.Load += new System.EventHandler(this.PrintPreview_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser receiptPreview;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button closeButton;
    }
}