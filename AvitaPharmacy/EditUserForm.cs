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
    public partial class EditUserForm : Form
    {
        static String editUserID1;
        public EditUserForm()
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

        private void search_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                String key = searchKey.Text;
                String role = roleComboBox.Text;
                if (role == "None")
                {
                    var searchedItems = from x in context.Users
                                        where x.UserID.Contains(key) ||
                                              x.First_Name.Contains(key) ||
                                              x.Last_Name.Contains(key) ||
                                              x.User_Type.Contains(key)
                                        select x;
                    if (searchedItems.Any())
                    {
                        editDataGridView.DataSource = searchedItems;
                    }
                    else
                    {
                        editDataGridView.DataSource = null;
                    }
                }
                else
                {
                    var searchedItems1 = from x in context.Users
                                         where x.UserID.Contains(key) && x.User_Type == role ||
                                                      x.First_Name.Contains(key) && x.User_Type == role ||
                                                      x.Last_Name.Contains(key) && x.User_Type == role ||
                                                      x.User_Type.Contains(key) && x.User_Type == role
                                         select x;
                    if (searchedItems1.Any())
                    {
                        editDataGridView.DataSource = searchedItems1;
                    }
                    else
                    {
                        editDataGridView.DataSource = null;
                    }
                }

            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avitaDataSet6.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.avitaDataSet6.Users);

        }

        private void editUser_Click(object sender, EventArgs e)
        {
            int check = 0;
             
            if (editFirstName.Text.Trim() == "")
            {
                editFirstNameError.Text = "Field Required";
            }
            else
            {
                editFirstNameError.Text = "";
                check++;
            }
            if (editLastName.Text.Trim() == "")
            {
                editLastNameError.Text = "Field Required";
            }
            else
            {
                editLastNameError.Text = "";
                check++;
            }
            if (editPassword1.Text.Trim() == "")
            {
                editPassword1Error.Text = "Field Required";
            }
            else
            {
                editPassword1Error.Text = "";
                check++;
            }
            if (editPassword2.Text.Trim() == "")
            {
                editPassword2Error.Text = "Field Required";
            }
            else
            {
                editPassword2Error.Text = "";
                check++;
            }
            if (editPassword1.Text.Trim() != "" && editPassword2.Text.Trim() != "")
            {
                if (editPassword1.Text.Trim() != editPassword2.Text.Trim())
                {
                    editPassword2Error.Text = "Passwords Do not Match";
                }
                else
                {
                    editPassword2Error.Text = "";
                    check++;
                } 
            }
           
            if (check == 5)
            { 
                String firstName = editFirstName.Text;
                String lastName = editLastName.Text;
                String password = editPassword1.Text;
                String role = roleComboBox.Text;
                DataClasses1DataContext context = new DataClasses1DataContext();
                User editUser = context.Users.SingleOrDefault(x => x.UserID == editUserID1); 
                editUser.First_Name = firstName;
                editUser.Last_Name = lastName;
                editUser.Password = password;
                editUser.User_Type = role;
                context.SubmitChanges();
                editDataGridView.DataSource = context.Users;
                clearEdit();
                MessageBox.Show("Data Updated");

            }
        }

        private void editDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.editDataGridView.Rows[e.RowIndex];
                editUserID1 = selectedRow.Cells[0].Value.ToString(); 
                editFirstName.Text = selectedRow.Cells[1].Value.ToString();
                editLastName.Text = selectedRow.Cells[2].Value.ToString();
                roleComboBox.Text = selectedRow.Cells[3].Value.ToString();
                editPassword1.Text = selectedRow.Cells[4].Value.ToString();
                editPassword2.Text = selectedRow.Cells[4].Value.ToString();
            }
        }
        private void clearEdit()
        { 
            editFirstName.Clear();
            editLastName.Clear();
            editPassword1.Clear();
            editPassword2.Clear();
            roleComboBox.Text = "Receptionist"; 
            editFirstNameError.Text = "";
            editLastNameError.Text = "";
            editPassword1Error.Text = "";
            editPassword2Error.Text = "";
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        { 
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var items = from x in context.Users
                            select x;
                if (items.Any())
                {
                    editDataGridView.DataSource = items;
                }
                roleComboBox.Text = "None";
            } 
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
