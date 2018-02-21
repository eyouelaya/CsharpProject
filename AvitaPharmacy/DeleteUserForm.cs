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
    public partial class DeleteUserForm : Form
    {
        static String deleteUserID;
        public DeleteUserForm()
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

        private void button2_Click(object sender, EventArgs e)
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
                        deleteGridView.DataSource = searchedItems;
                    }
                    else
                    {
                        deleteGridView.DataSource = null;
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
                        deleteGridView.DataSource = searchedItems1;
                    }
                    else
                    {
                        deleteGridView.DataSource = null;
                    }
                }

            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avitaDataSet7.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.avitaDataSet7.Users);

        }

        private void deleteGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow db = this.deleteGridView.Rows[e.RowIndex];
                try
                {
                    deleteUserID = db.Cells[0].Value.ToString();
                }
                catch (Exception)
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (deleteUserID != "")
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                User dataToBeDeleted = context.Users.SingleOrDefault(x => x.UserID == deleteUserID);
                context.Users.DeleteOnSubmit(dataToBeDeleted);
                context.SubmitChanges();
                deleteGridView.DataSource = context.Users;
                MessageBox.Show("Data Deleted Successfully");

            }
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        { 
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var items = from x in context.Users
                            select x;
                if (items.Any())
                {
                    deleteGridView.DataSource = items;
                }
                searchKey.Clear();
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
