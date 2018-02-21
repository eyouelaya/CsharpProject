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
    public partial class AddMedicineForm : Form
    {
        public AddMedicineForm()
        {
            InitializeComponent();
            DataClasses1DataContext context = new DataClasses1DataContext();
            addProductionDate.MaxDate = DateTime.Now;
            addExpiryDate.MinDate = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm f2 = new MenuForm();
            f2.MdiParent = this.MdiParent;
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearAdd(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (addMedicineID.Text.Trim() == "")
            {
                addMedicineIDError.Text = "Field Required";
            }
            else
            {
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    var medicineId = from d in context.MedicineTables 
                                     where d.MedicineID == addMedicineID.Text
                                     select d;
             
                if (medicineId.Any())
                    addMedicineIDError.Text = "Id Already Exists";
                else
                {
                    addMedicineIDError.Text = "";
                    check++; 
                }
                }
            }
            if (addMedicineName.Text.Trim() == "")
            {
                addMedicineNameError.Text = "Field Required";
            }
            else
            {
                addMedicineNameError.Text = "";
                check++;
            }
            if (addManufacturer.Text.Trim() == "")
            {
                addManufacturerError.Text = "Field Required";
            }
            else
            {
                addManufacturerError.Text = "";
                check++;
            }
            if (addCategory.Text.Trim() == "")
            {
                addCategoryError.Text = "Field Required";
            }
            else
            {
                addCategoryError.Text = "";
                check++;
            }
            if (addQuantity.Text.Trim() == "")
            {
                addQuantityError.Text = "Field Required";
            }
            else
            {
                int d;
                if (!int.TryParse(addQuantity.Text.Trim(), out d))
                {
                    addQuantityError.Text = "Non-Decimal \n Number input only";
                }
                else
                {
                    addQuantityError.Text = "";
                    check++;
                }

            } 
            
            if (addSellingPrice.Text.Trim() == "")
            {
                addSellingPriceError.Text = "Field Required";
            }
            else
            {
                double d;
                if (!double.TryParse(addSellingPrice.Text.Trim(), out d))
                {
                    addSellingPriceError.Text = "Number input only";
                }
                else
                {
                    addSellingPriceError.Text = "";
                    check++;
                }

            }
            if (addBuyingPrice.Text.Trim() == "")
            {
                addBuyingPriceError.Text = "Field Required";
            }
            else
            {
                double d;
                if (!double.TryParse(addBuyingPrice.Text.Trim(), out d))
                {
                    addBuyingPriceError.Text = "Number input only";
                }
                else
                {
                    addBuyingPriceError.Text = "";
                    check++;
                }
            }
            if (check == 7)
            {
                String newMedicineID = addMedicineID.Text;
                String newMedicineName = addMedicineName.Text;
                String newCategory = addCategory.Text;
                int newQuantity = Convert.ToInt32(addQuantity.Text);
                String newManufacturer = addManufacturer.Text;
                DateTime newEntryDate = DateTime.Now;
                DateTime newProductionDate = Convert.ToDateTime(addProductionDate.Text);
                DateTime newExpiryDate = Convert.ToDateTime(addExpiryDate.Text);
                double newSellingPrice = Math.Round(Convert.ToDouble(addSellingPrice.Text),2);
                double newBuyingPrice = Math.Round(Convert.ToDouble(addBuyingPrice.Text), 2);
             
                 
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {

                    MedicineTable newMedicine = new MedicineTable
                    {
                        MedicineID = newMedicineID,
                        Medicine_Name = newMedicineName,
                        Category = newCategory,
                        Quantity = newQuantity,
                        Manufacturer = newManufacturer,
                        Entry_Date = newEntryDate,
                        Production_Date = newProductionDate,
                        Expiring_Date = newExpiryDate,
                        Selling_Price = newSellingPrice,
                        Buying_Price = newBuyingPrice
                    };
                    context.MedicineTables.InsertOnSubmit(newMedicine);
                    context.SubmitChanges();
                    clearAdd();
                    MessageBox.Show("Medicine Added Successfully");
                }

            }
        }
        private void clearAdd()
        {
            addMedicineID.Clear();
            addMedicineName.Clear();
            addCategory.Clear();
            addQuantity.Clear();
            addManufacturer.Clear();
            addExpiryDate.ResetText();
            addProductionDate.ResetText();
            addSellingPrice.Clear();
            addBuyingPrice.Clear();

            addMedicineIDError.Text = "";
            addMedicineNameError.Text = "";
            addCategoryError.Text = "";
            addQuantityError.Text = "";
            addManufacturerError.Text = "";
            addProductionDateError.Text = "";
            addExpiryDateError.Text = "";
            addSellingPriceError.Text = "";
            addBuyingPriceError.Text = "";
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
