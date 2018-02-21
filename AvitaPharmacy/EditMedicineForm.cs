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
    public partial class EditMedicineForm : Form
    {
        static String editMedicineID;
         

        public EditMedicineForm()
        {
            InitializeComponent();
            DataClasses1DataContext context = new DataClasses1DataContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm f2 = new MenuForm();
            f2.MdiParent = this.MdiParent;
            f2.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'avitaDataSet1.MedicineTable' table. You can move, or remove it, as needed.
            this.medicineTableTableAdapter.Fill(this.avitaDataSet1.MedicineTable);
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var category = from c in context.MedicineTables
                               select c.Category; 
                foreach (String c in category)
                    categoryComboBox.Items.Add(c);
            }
        }
        
        private void addNewMedicine_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                int check = 0; 
                if (editMedicineName.Text.Trim() == "")
                {
                    editMedicineNameError.Text = "Field Required";
                }
                else
                {
                    editMedicineNameError.Text = "";
                    check++;
                }
                if (editManufacturer.Text.Trim() == "")
                {
                    editManufacturerError.Text = "Field Required";
                }
                else
                {
                    editManufacturerError.Text = "";
                    check++;
                }
                if (editCategory.Text.Trim() == "")
                {
                    editCategoryError.Text = "Field Required";
                }
                else
                {
                    editCategoryError.Text = "";
                    check++;
                }
                if (editQuantity.Text.Trim() == "")
                {
                    editQuantityError.Text = "Field Required";
                }
                else
                {
                    int d;
                    if (!int.TryParse(editQuantity.Text.Trim(), out d))
                    {
                        editQuantityError.Text = "Non-Decimal \n Number input only";
                    }
                    else
                    {
                        editQuantityError.Text = "";
                        check++;
                    }

                }

                if (editSellingPrice.Text.Trim() == "")
                {
                    editSellingPriceError.Text = "Field Required";
                }
                else
                {
                    double d;
                    if (!double.TryParse(editSellingPrice.Text.Trim(), out d))
                    {
                        editSellingPriceError.Text = "Number input only";
                    }
                    else
                    {
                        editSellingPriceError.Text = "";
                        check++;
                    }

                }
                if (editBuyingPrice.Text.Trim() == "")
                {
                    editBuyingPriceError.Text = "Field Required";
                }
                else
                {
                    double d;
                    if (!double.TryParse(editBuyingPrice.Text.Trim(), out d))
                    {
                        editBuyingPriceError.Text = "Number input only";
                    }
                    else
                    {
                        editBuyingPriceError.Text = "";
                        check++; 
                    }
                }
                if (check == 6)
                {
                    String editMedicinename = editMedicineName.Text;
                    String editcategory = editCategory.Text;
                    String editmanufacturer = editManufacturer.Text;
                    int editquantity = Convert.ToInt32(editQuantity.Text);
                    DateTime editEntrydate = DateTime.Now;
                    DateTime editProductiondate = Convert.ToDateTime(editProductionDate.Text);
                    DateTime editExpiringDate = Convert.ToDateTime(editExpiryDate.Text);
                    Double editSellingprice = Convert.ToDouble(editSellingPrice.Text);
                    Double editBuyingprice = Convert.ToDouble(editBuyingPrice.Text);

                    MedicineTable dd = context.MedicineTables.SingleOrDefault(x => x.MedicineID == editMedicineID);
                    dd.Medicine_Name = editMedicinename;
                    dd.Category = editcategory;
                    dd.Manufacturer = editmanufacturer;
                    dd.Quantity = editquantity;
                    dd.Entry_Date = editEntrydate;
                    dd.Production_Date = editProductiondate;
                    dd.Expiring_Date = editExpiringDate;
                    dd.Selling_Price = editSellingprice;
                    dd.Buying_Price = editBuyingprice; 
                    context.SubmitChanges();
                    MessageBox.Show("Data Updated");
                    dataGridView1.DataSource = context.MedicineTables;
                    clearEdit();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow db = this.dataGridView1.Rows[e.RowIndex];
                editMedicineID = db.Cells[0].Value.ToString();
                editMedicineName.Text = db.Cells[1].Value.ToString();
                editCategory.Text = db.Cells[2].Value.ToString();
                editQuantity.Text = db.Cells[3].Value.ToString();
                editManufacturer.Text = db.Cells[4].Value.ToString();
                editProductionDate.Value = Convert.ToDateTime(db.Cells[6].Value.ToString());
                editExpiryDate.Value = Convert.ToDateTime(db.Cells[7].Value);
                editSellingPrice.Text = db.Cells[8].Value.ToString();
                editBuyingPrice.Text = db.Cells[9].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                String key = searchKey.Text; 
                String category = categoryComboBox.Text; 
                if (category == "None")
                {
                    var searchedItems = from x in context.MedicineTables
                                       where x.MedicineID.Contains(key)   ||
                                             x.Medicine_Name.Contains(key)  ||
                                             x.Category.Contains(key)  ||
                                             x.Manufacturer.Contains(key) 
                                       select x;
                    if (searchedItems.Any())
                    {
                        dataGridView1.DataSource = searchedItems;
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
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
                        dataGridView1.DataSource = searchedItems1;
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                    }
                }
               
            }
        }
        private void clearEdit()
        {
            editMedicineName.Clear();
            editCategory.Clear();
            editManufacturer.Clear();
            editQuantity.Clear();
            editProductionDate.ResetText();
            editExpiryDate.ResetText();
            editSellingPrice.Clear();
            editBuyingPrice.Clear();
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                var items = from x in context.MedicineTables
                            select x;
                if (items.Any())
                {
                    dataGridView1.DataSource = items;
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
