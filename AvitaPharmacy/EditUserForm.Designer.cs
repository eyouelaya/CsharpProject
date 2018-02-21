namespace AvitaPharmacy
{
    partial class EditUserForm
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
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.searchKey = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editPassword2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editPassword1 = new System.Windows.Forms.TextBox();
            this.editLastName = new System.Windows.Forms.TextBox();
            this.editFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editDataGridView = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avitaDataSet6 = new AvitaPharmacy.AvitaDataSet6();
            this.search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.usersTableAdapter = new AvitaPharmacy.AvitaDataSet6TableAdapters.UsersTableAdapter();
            this.editFirstNameError = new System.Windows.Forms.Label();
            this.editLastNameError = new System.Windows.Forms.Label();
            this.editPassword1Error = new System.Windows.Forms.Label();
            this.editPassword2Error = new System.Windows.Forms.Label();
            this.editUser = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avitaDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(548, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 24);
            this.label12.TabIndex = 32;
            this.label12.Text = "Role";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "None",
            "Administrator",
            "Receptionist"});
            this.roleComboBox.Location = new System.Drawing.Point(620, 78);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(121, 21);
            this.roleComboBox.TabIndex = 31;
            this.roleComboBox.Text = "None";
            // 
            // searchKey
            // 
            this.searchKey.Location = new System.Drawing.Point(330, 78);
            this.searchKey.Name = "searchKey";
            this.searchKey.Size = new System.Drawing.Size(191, 20);
            this.searchKey.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(236, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 24);
            this.label11.TabIndex = 29;
            this.label11.Text = "Search";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "AdmInistrator",
            "Receptionist"});
            this.comboBox2.Location = new System.Drawing.Point(171, 503);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 21);
            this.comboBox2.TabIndex = 50;
            this.comboBox2.Text = "Receptionist";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 49;
            this.label5.Text = "Role";
            // 
            // editPassword2
            // 
            this.editPassword2.Location = new System.Drawing.Point(171, 429);
            this.editPassword2.Name = "editPassword2";
            this.editPassword2.Size = new System.Drawing.Size(201, 20);
            this.editPassword2.TabIndex = 48;
            this.editPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Password";
            // 
            // editPassword1
            // 
            this.editPassword1.Location = new System.Drawing.Point(171, 362);
            this.editPassword1.Name = "editPassword1";
            this.editPassword1.Size = new System.Drawing.Size(201, 20);
            this.editPassword1.TabIndex = 46;
            this.editPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editLastName
            // 
            this.editLastName.Location = new System.Drawing.Point(171, 284);
            this.editLastName.Name = "editLastName";
            this.editLastName.Size = new System.Drawing.Size(201, 20);
            this.editLastName.TabIndex = 45;
            this.editLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editFirstName
            // 
            this.editFirstName.Location = new System.Drawing.Point(171, 213);
            this.editFirstName.Name = "editFirstName";
            this.editFirstName.Size = new System.Drawing.Size(201, 20);
            this.editFirstName.TabIndex = 44;
            this.editFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 43;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "First Name";
            // 
            // editDataGridView
            // 
            this.editDataGridView.AllowUserToAddRows = false;
            this.editDataGridView.AllowUserToDeleteRows = false;
            this.editDataGridView.AutoGenerateColumns = false;
            this.editDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.editDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.editDataGridView.DataSource = this.usersBindingSource;
            this.editDataGridView.Location = new System.Drawing.Point(409, 159);
            this.editDataGridView.Name = "editDataGridView";
            this.editDataGridView.ReadOnly = true;
            this.editDataGridView.Size = new System.Drawing.Size(638, 448);
            this.editDataGridView.TabIndex = 51;
            this.editDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editDataGridView_CellClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "User_Type";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "User_Type";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.avitaDataSet6;
            // 
            // avitaDataSet6
            // 
            this.avitaDataSet6.DataSetName = "AvitaDataSet6";
            this.avitaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // search
            // 
            this.search.BackgroundImage = global::AvitaPharmacy.Properties.Resources.search;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(758, 66);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(50, 35);
            this.search.TabIndex = 33;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AvitaPharmacy.Properties.Resources.back2;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(49, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // editFirstNameError
            // 
            this.editFirstNameError.AutoSize = true;
            this.editFirstNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFirstNameError.ForeColor = System.Drawing.Color.Red;
            this.editFirstNameError.Location = new System.Drawing.Point(172, 249);
            this.editFirstNameError.Name = "editFirstNameError";
            this.editFirstNameError.Size = new System.Drawing.Size(0, 17);
            this.editFirstNameError.TabIndex = 53;
            // 
            // editLastNameError
            // 
            this.editLastNameError.AutoSize = true;
            this.editLastNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLastNameError.ForeColor = System.Drawing.Color.Red;
            this.editLastNameError.Location = new System.Drawing.Point(171, 327);
            this.editLastNameError.Name = "editLastNameError";
            this.editLastNameError.Size = new System.Drawing.Size(0, 17);
            this.editLastNameError.TabIndex = 54;
            // 
            // editPassword1Error
            // 
            this.editPassword1Error.AutoSize = true;
            this.editPassword1Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPassword1Error.ForeColor = System.Drawing.Color.Red;
            this.editPassword1Error.Location = new System.Drawing.Point(171, 397);
            this.editPassword1Error.Name = "editPassword1Error";
            this.editPassword1Error.Size = new System.Drawing.Size(0, 17);
            this.editPassword1Error.TabIndex = 55;
            // 
            // editPassword2Error
            // 
            this.editPassword2Error.AutoSize = true;
            this.editPassword2Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPassword2Error.ForeColor = System.Drawing.Color.Red;
            this.editPassword2Error.Location = new System.Drawing.Point(171, 467);
            this.editPassword2Error.Name = "editPassword2Error";
            this.editPassword2Error.Size = new System.Drawing.Size(0, 17);
            this.editPassword2Error.TabIndex = 56;
            // 
            // editUser
            // 
            this.editUser.BackgroundImage = global::AvitaPharmacy.Properties.Resources.Save;
            this.editUser.FlatAppearance.BorderSize = 0;
            this.editUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUser.Location = new System.Drawing.Point(897, 52);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(75, 75);
            this.editUser.TabIndex = 57;
            this.editUser.UseVisualStyleBackColor = true;
            this.editUser.Click += new System.EventHandler(this.editUser_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.BackgroundImage = global::AvitaPharmacy.Properties.Resources.green_back;
            this.clearSearchButton.FlatAppearance.BorderSize = 0;
            this.clearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchButton.Location = new System.Drawing.Point(814, 68);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(30, 30);
            this.clearSearchButton.TabIndex = 58;
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.ControlBox = false;
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.editUser);
            this.Controls.Add(this.editPassword2Error);
            this.Controls.Add(this.editPassword1Error);
            this.Controls.Add(this.editLastNameError);
            this.Controls.Add(this.editFirstNameError);
            this.Controls.Add(this.editDataGridView);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editPassword2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editPassword1);
            this.Controls.Add(this.editLastName);
            this.Controls.Add(this.editFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.searchKey);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avitaDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.TextBox searchKey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editPassword2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox editPassword1;
        private System.Windows.Forms.TextBox editLastName;
        private System.Windows.Forms.TextBox editFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editUserID;
        private System.Windows.Forms.DataGridView editDataGridView;
        private AvitaDataSet6 avitaDataSet6;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private AvitaDataSet6TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label editFirstNameError;
        private System.Windows.Forms.Label editLastNameError;
        private System.Windows.Forms.Label editPassword1Error;
        private System.Windows.Forms.Label editPassword2Error;
        private System.Windows.Forms.Button editUser;
        private System.Windows.Forms.Button clearSearchButton;
    }
}