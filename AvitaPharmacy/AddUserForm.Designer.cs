namespace AvitaPharmacy
{
    partial class AddUserForm
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
            this.reset = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addLastName = new System.Windows.Forms.TextBox();
            this.addFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addUserID = new System.Windows.Forms.TextBox();
            this.addPassword1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addPassword2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.userIDError = new System.Windows.Forms.Label();
            this.firstNameError = new System.Windows.Forms.Label();
            this.lastNameError = new System.Windows.Forms.Label();
            this.password1Error = new System.Windows.Forms.Label();
            this.password2Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.BackgroundImage = global::AvitaPharmacy.Properties.Resources.brush;
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Location = new System.Drawing.Point(775, 35);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(70, 70);
            this.reset.TabIndex = 28;
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // addUser
            // 
            this.addUser.BackgroundImage = global::AvitaPharmacy.Properties.Resources.Save;
            this.addUser.FlatAppearance.BorderSize = 0;
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser.Location = new System.Drawing.Point(897, 30);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(75, 75);
            this.addUser.TabIndex = 27;
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AvitaPharmacy.Properties.Resources.back2;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(63, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addLastName
            // 
            this.addLastName.Location = new System.Drawing.Point(520, 350);
            this.addLastName.Name = "addLastName";
            this.addLastName.Size = new System.Drawing.Size(201, 20);
            this.addLastName.TabIndex = 34;
            this.addLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addFirstName
            // 
            this.addFirstName.Location = new System.Drawing.Point(520, 275);
            this.addFirstName.Name = "addFirstName";
            this.addFirstName.Size = new System.Drawing.Size(201, 20);
            this.addFirstName.TabIndex = 33;
            this.addFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "User ID";
            // 
            // addUserID
            // 
            this.addUserID.Location = new System.Drawing.Point(520, 199);
            this.addUserID.Name = "addUserID";
            this.addUserID.Size = new System.Drawing.Size(201, 20);
            this.addUserID.TabIndex = 29;
            this.addUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addPassword1
            // 
            this.addPassword1.Location = new System.Drawing.Point(520, 423);
            this.addPassword1.Name = "addPassword1";
            this.addPassword1.PasswordChar = '*';
            this.addPassword1.Size = new System.Drawing.Size(201, 20);
            this.addPassword1.TabIndex = 35;
            this.addPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Password";
            // 
            // addPassword2
            // 
            this.addPassword2.Location = new System.Drawing.Point(520, 491);
            this.addPassword2.Name = "addPassword2";
            this.addPassword2.PasswordChar = '*';
            this.addPassword2.Size = new System.Drawing.Size(201, 20);
            this.addPassword2.TabIndex = 37;
            this.addPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 38;
            this.label5.Text = "Role";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Administrator",
            "Receptionist"});
            this.roleComboBox.Location = new System.Drawing.Point(520, 563);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(201, 21);
            this.roleComboBox.TabIndex = 39;
            this.roleComboBox.Text = "Receptionist";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(385, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 26);
            this.label12.TabIndex = 40;
            this.label12.Text = "Add New User";
            // 
            // userIDError
            // 
            this.userIDError.AutoSize = true;
            this.userIDError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDError.ForeColor = System.Drawing.Color.Red;
            this.userIDError.Location = new System.Drawing.Point(517, 236);
            this.userIDError.Name = "userIDError";
            this.userIDError.Size = new System.Drawing.Size(0, 17);
            this.userIDError.TabIndex = 41;
            // 
            // firstNameError
            // 
            this.firstNameError.AutoSize = true;
            this.firstNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameError.ForeColor = System.Drawing.Color.Red;
            this.firstNameError.Location = new System.Drawing.Point(517, 313);
            this.firstNameError.Name = "firstNameError";
            this.firstNameError.Size = new System.Drawing.Size(0, 17);
            this.firstNameError.TabIndex = 42;
            // 
            // lastNameError
            // 
            this.lastNameError.AutoSize = true;
            this.lastNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameError.ForeColor = System.Drawing.Color.Red;
            this.lastNameError.Location = new System.Drawing.Point(517, 388);
            this.lastNameError.Name = "lastNameError";
            this.lastNameError.Size = new System.Drawing.Size(0, 17);
            this.lastNameError.TabIndex = 43;
            // 
            // password1Error
            // 
            this.password1Error.AutoSize = true;
            this.password1Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password1Error.ForeColor = System.Drawing.Color.Red;
            this.password1Error.Location = new System.Drawing.Point(517, 460);
            this.password1Error.Name = "password1Error";
            this.password1Error.Size = new System.Drawing.Size(0, 17);
            this.password1Error.TabIndex = 44;
            // 
            // password2Error
            // 
            this.password2Error.AutoSize = true;
            this.password2Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2Error.ForeColor = System.Drawing.Color.Red;
            this.password2Error.Location = new System.Drawing.Point(517, 527);
            this.password2Error.Name = "password2Error";
            this.password2Error.Size = new System.Drawing.Size(0, 17);
            this.password2Error.TabIndex = 45;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.ControlBox = false;
            this.Controls.Add(this.password2Error);
            this.Controls.Add(this.password1Error);
            this.Controls.Add(this.lastNameError);
            this.Controls.Add(this.firstNameError);
            this.Controls.Add(this.userIDError);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addPassword2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addPassword1);
            this.Controls.Add(this.addLastName);
            this.Controls.Add(this.addFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addUserID);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox addLastName;
        private System.Windows.Forms.TextBox addFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addUserID;
        private System.Windows.Forms.TextBox addPassword1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addPassword2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label userIDError;
        private System.Windows.Forms.Label firstNameError;
        private System.Windows.Forms.Label lastNameError;
        private System.Windows.Forms.Label password1Error;
        private System.Windows.Forms.Label password2Error;
    }
}