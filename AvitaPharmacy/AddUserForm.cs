using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvitaPharmacy
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm f2 = new MenuForm();
            f2.MdiParent = this.MdiParent;
            f2.Show();
            this.Hide();

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (addUserID.Text.Trim() == "")
            {
                userIDError.Text = "Field Required";
            }
            else
            {
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    var newUser = from d in context.Users
                                     where d.UserID == addUserID.Text
                                     select d;

                    if (newUser.Any())
                        userIDError.Text = "Id Already Exists";
                    else
                    {
                        userIDError.Text = "";
                        check++;
                    }
                }
            }
            if (addFirstName.Text.Trim() == "")
            {
                firstNameError.Text = "Field Required";
            }
            else
            {
                firstNameError.Text = "";
                check++;
            }
            if (addLastName.Text.Trim() == "")
            {
                lastNameError.Text = "Field Required";
            }
            else
            {
                lastNameError.Text = "";
                check++;
            }
            if (addPassword1.Text.Trim() == "")
            {
                password1Error.Text = "Field Required";
            }
            else
            {
                password1Error.Text = "";
                check++;
            }
            if (addPassword2.Text.Trim() == "")
            {
                password2Error.Text = "Field Required";
            }
            else
            {
                password2Error.Text = "";
                check++;
            }
            if (addPassword1.Text.Trim() != "" && addPassword2.Text.Trim() != "")
            {
                if (addPassword1.Text.Trim() != addPassword2.Text.Trim())
                {
                    password2Error.Text = "Passwords Do not Match";
                }
                else
                {
                    password2Error.Text = "";
                    check++;
                } 
            }
           
            if (check == 6)
            { 
                String userID = addUserID.Text;
                String firstName = addFirstName.Text;
                String lastName = addLastName.Text;
                String password = addPassword1.Text;
                String role = roleComboBox.Text;

                DataClasses1DataContext context = new DataClasses1DataContext();
                User newUser = new User
                {
                    UserID = userID,
                    First_Name = firstName,
                    Last_Name = lastName,
                    User_Type = role,
                    Password = password
                };
                context.Users.InsertOnSubmit(newUser);
                context.SubmitChanges();
                clearAdd();
                MessageBox.Show("User Added Successfully");
            }

        }
        private void clearAdd()
        {
            addUserID.Clear();
            addFirstName.Clear();
            addLastName.Clear();
            addPassword1.Clear();
            addPassword2.Clear();
            roleComboBox.Text = "Receptionist";
            userIDError.Text = "";
            firstNameError.Text = "";
            lastNameError.Text = "";
            password1Error.Text = "";
            password2Error.Text = "";

        }

        private void reset_Click(object sender, EventArgs e)
        {
            clearAdd();
        }
        protected override CreateParams CreateParams
        {
            //makes the filckering during form change stop 
            //code copied from stackoverflow
            get
            {
                //Activate double buffering at the form level. All child controls will
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; //WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}
