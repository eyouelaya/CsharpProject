﻿using System;
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
    public partial class DeleteMedicineForm : Form
    {
        static String deleteMedicineID;
       
        public DeleteMedicineForm()
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

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avitaDataSet2.MedicineTable' table. You can move, or remove it, as needed.
            this.medicineTableTableAdapter.Fill(this.avitaDataSet2.MedicineTable);
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var category = from c in context.MedicineTables
                               select c.Category;
                foreach (String c in category)
                    categoryComboBox.Items.Add(c);
            }
        }

        private void deleteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow db = this.deleteDataGridView.Rows[e.RowIndex];
                try
                {
                    deleteMedicineID = db.Cells[0].Value.ToString();
                }
                catch (Exception )
                {
                    
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deleteMedicineID != "")
            {
                DataClasses1DataContext context = new DataClasses1DataContext();
                MedicineTable dataToBeDeleted = context.MedicineTables.SingleOrDefault(x => x.MedicineID == deleteMedicineID);
                context.MedicineTables.DeleteOnSubmit(dataToBeDeleted);
                context.SubmitChanges(); 
                deleteDataGridView.DataSource = context.MedicineTables;
                MessageBox.Show("Data Deleted Successfully");
            }
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                String key = searchKey.Text;
                String category = categoryComboBox.Text;
                if (category == "None")
                {
                    var searchedItems = from x in context.MedicineTables
                                        where x.MedicineID.Contains(key) ||
                                              x.Medicine_Name.Contains(key) ||
                                              x.Category.Contains(key) ||
                                              x.Manufacturer.Contains(key)
                                        select x;
                    if (searchedItems.Any())
                    {
                        deleteDataGridView.DataSource = searchedItems;
                    }
                    else
                    {
                        deleteDataGridView.DataSource = null;
                    }
                }
                else
                {
                    var searchedItems1 = from x in context.MedicineTables
                                         where x.MedicineID.Contains(key) && x.Category == category ||
                                               x.Medicine_Name.Contains(key) && x.Category == category ||
                                               x.Category.Contains(key) && x.Category == category ||
                                               x.Manufacturer.Contains(key) && x.Category == category
                                         select x;
                    if (searchedItems1.Any())
                    {
                        deleteDataGridView.DataSource = searchedItems1;
                    }
                    else
                    {
                        deleteDataGridView.DataSource = null;
                    }
                }

            }
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var items = from x in context.MedicineTables 
                                     select x;
                if (items.Any())
                {
                    deleteDataGridView.DataSource = items;
                }
                searchKey.Clear();
                categoryComboBox.Text = "None";
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
