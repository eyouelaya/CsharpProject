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
    public partial class ViewUserForm : Form
    {
        public ViewUserForm()
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
                        viewUserGrid.DataSource = searchedItems;
                    }
                    else
                    {
                        viewUserGrid.DataSource = null;
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
                        viewUserGrid.DataSource = searchedItems1;
                    }
                    else
                    {
                        viewUserGrid.DataSource = null;
                    }
                }

            }
             
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avitaDataSet5.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.avitaDataSet5.Users);

        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var items = from x in context.Users
                            select x;
                if (items.Any())
                {
                    viewUserGrid.DataSource = items;
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
