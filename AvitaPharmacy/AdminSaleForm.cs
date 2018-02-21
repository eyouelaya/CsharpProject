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
   
    public partial class AdminSaleForm : Form
    {
        static String Userid;
        public AdminSaleForm(String id)
        {
            InitializeComponent();
            Userid = id; 
            
        }
        public string LoggedInUserID { set; get; }
        private void button1_Click(object sender, EventArgs e)
        {
            
            MenuForm f2 = new MenuForm();
            f2.MdiParent = this.MdiParent;
            f2.Show();
            this.Hide();
        }
        public void SaleForm(Form f)
        {
            f.Enabled = true;
        }

        private void AdminSaleForm_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var medicines = from m in context.MedicineTables
                            select m.MedicineID; 
            foreach (String x in medicines)
                medicineNameComboBox.Items.Add(x); 

        }

        private void amountWanted_TextChanged(object sender, EventArgs e)
        {
            String selectedMedicine = medicineNameComboBox.Text;
            int amountRequested = 1;
            if (amountWanted.Text.Trim() != "" || amountWanted.Text.Trim() != " ")
            {
                int d;
                if (int.TryParse(amountWanted.Text.Trim(), out d))
                    amountRequested = Convert.ToInt32(amountWanted.Text);
            }
            if (selectedMedicine.Trim() != "")
            {
                if (quantityError.Text.Trim() == "Amount Insufficent")
                    addSelectedMedicine.Enabled = true;
                DataClasses1DataContext context = new DataClasses1DataContext();
                var prices = from m in context.MedicineTables
                             where m.MedicineID == selectedMedicine
                             select m.Selling_Price;
                foreach (double x in prices)
                {
                    price.Text = x.ToString();

                    if (availableAmount.Text.Trim() != "")
                    {
                        if (Convert.ToDouble(availableAmount.Text) < amountRequested)
                        {
                            addSelectedMedicine.Enabled = false;
                            quantityError.Text = "Amount Insufficent";
                        }
                        else
                        {
                            quantityError.Text = "";
                        }

                    }
                    amountTotal.Text = (x * amountRequested).ToString();
                }
            }
        }

        private void medicineNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            String selectedMedicine = medicineNameComboBox.Text;
            double amountRequested = 1;
            if (amountWanted.Text.Trim() != "")
            {
                int d;
                if (int.TryParse(amountWanted.Text.Trim(), out d))
                    amountRequested = Convert.ToInt32(amountWanted.Text);
            }

            if (selectedMedicine.Trim() != "")
            {
                if (quantityError.Text.Trim() == "Amount Insufficent")
                    addSelectedMedicine.Enabled = true;
                DataClasses1DataContext context = new DataClasses1DataContext();
                var quantity = from m in context.MedicineTables
                               where m.MedicineID == selectedMedicine
                               select m.Quantity;
                var prices = from m in context.MedicineTables
                             where m.MedicineID == selectedMedicine
                             select m.Selling_Price;
                var selectedMedicineName = (from m in context.MedicineTables
                                            where m.MedicineID == selectedMedicine
                                            select new
                                            {
                                                m.Medicine_Name
                                            }).First();
                foreach (int x in quantity)
                {
                    double avail = 0;
                    if (cartDataView.Rows.Count > 0)
                        foreach (DataGridViewRow rows in cartDataView.Rows)
                        {
                            if (selectedMedicineName.Medicine_Name == rows.Cells[0].Value.ToString())
                                avail += Convert.ToDouble(rows.Cells[5].Value);
                        }
                    avail = x - avail;
                    availableAmount.Text = avail.ToString();
                }
                foreach (double y in prices)
                {
                    price.Text = y.ToString();
                    if (Convert.ToInt32(availableAmount.Text) < amountRequested)
                    {
                        addSelectedMedicine.Enabled = false;
                        quantityError.Text = "Amount Insufficent";

                    }
                    else
                    {
                        quantityError.Text = "";
                        addSelectedMedicine.Enabled = true;
                    }
                    amountTotal.Text = (y * amountRequested).ToString();

                }

            }
            else
            {
                availableAmount.Clear();
                price.Clear();
                amountTotal.Clear();
                quantityError.Text = "";
                addSelectedMedicine.Enabled = false;
            }
        }

        private void addSelectedMedicine_Click(object sender, EventArgs e)
        {
            if (removeSelectedMedicine.Enabled == false)
            {
                removeSelectedMedicine.Enabled = true;
                Finish.Enabled = true;
            }
            String selectedMed = medicineNameComboBox.Text;
            DataClasses1DataContext context = new DataClasses1DataContext();
            var med = (from m in context.MedicineTables
                       where m.MedicineID == selectedMed
                       select new
                       {
                           m.Medicine_Name,
                           m.Category,
                           m.Manufacturer,
                           m.Production_Date,
                           m.Expiring_Date,
                           m.Quantity,
                           m.Selling_Price
                       }).First();
            double subTotal = 0;

            cartDataView.ColumnCount = 7;
            cartDataView.Columns[0].Name = "Medicine Name";
            cartDataView.Columns[1].Name = "Category";
            cartDataView.Columns[2].Name = "Manufacturer";
            cartDataView.Columns[3].Name = "Production Date";
            cartDataView.Columns[4].Name = "Expiry Date";
            cartDataView.Columns[5].Name = "Quantity";
            cartDataView.Columns[6].Name = "Price";

            if (amountWanted.Text.Trim() == "")
                cartDataView.Rows.Add(med.Medicine_Name, med.Category, med.Manufacturer, med.Production_Date,
                                    med.Expiring_Date, 1, med.Selling_Price);
            else
            {
                Double prices = Convert.ToDouble(med.Selling_Price);
                Double quantity = Convert.ToDouble(amountWanted.Text);
                Double totals = prices * quantity;
                cartDataView.Rows.Add(med.Medicine_Name, med.Category, med.Manufacturer, med.Production_Date,
                                   med.Expiring_Date, quantity, totals);
            }
            foreach (DataGridViewRow row in cartDataView.Rows)
            {
                subTotal += Convert.ToDouble(row.Cells[6].Value);
            }
            subTotalBox.Text = subTotal.ToString();
            tax.Text = "15%";
            double taxCalculated = subTotal + subTotal * 0.15;
            total.Text = (taxCalculated).ToString();
            medicineNameComboBox.SelectedIndex = 0;
            availableAmount.Clear();
            price.Clear();
            amountTotal.Clear();
            amountWanted.Clear();

        }

        private void removeSelectedMedicine_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> toBeRemoved = new List<DataGridViewRow>();
            DataClasses1DataContext context = new DataClasses1DataContext();
            foreach (DataGridViewRow row in cartDataView.SelectedRows)
            {
                double subTotal = Convert.ToDouble(subTotalBox.Text);
                subTotal -= Convert.ToDouble(row.Cells[6].Value);
                cartDataView.Rows.Remove(row);
                subTotalBox.Text = subTotal.ToString();
                total.Text = (subTotal * 0.15).ToString();
                var selectedMedicineName = (from m in context.MedicineTables
                                            where m.Medicine_Name == row.Cells[0].Value.ToString()
                                            select new
                                            {
                                                m.Medicine_Name,
                                                m.Quantity
                                            }).First();
                if (selectedMedicineName.Medicine_Name == row.Cells[0].Value.ToString())
                {
                    int quantity = Convert.ToInt32(row.Cells[5].Value); 
                    quantity = Convert.ToInt32(selectedMedicineName.Quantity) + quantity;
                    availableAmount.Text = quantity.ToString();
                }

            }
            if (cartDataView.Rows.Count == 0)
            {
                removeSelectedMedicine.Enabled = false;
                Finish.Enabled = false;

            }
      
            
        }   
        private void amountWanted_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Rest_Click(object sender, EventArgs e)
        {
            reset();
                
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            String customer;
            if (buyer.Text.Trim() != "")
                customer = buyer.Text;
            else
                customer = "customer";
            IList<String> medicineName = new List<String>();
            IList<String> category = new List<String>();
            IList<String> manufaturer = new List<String>();
            IList<DateTime> productionDate = new List<DateTime>();
            IList<DateTime> expiryDate = new List<DateTime>();
            IList<int> quantity = new List<int>();
            IList<Double> buyingPrice = new List<Double>();
            IList<Double> sellingPrice = new List<Double>();
            DateTime dateSold = DateTime.Now;
            IList<Double> amountTotals = new List<Double>();
            IList<Double> profit = new List<Double>();

            foreach (DataGridViewRow row in cartDataView.Rows)
            {
                medicineName.Add(row.Cells[0].Value.ToString());
                category.Add(row.Cells[1].Value.ToString());
                manufaturer.Add(row.Cells[2].Value.ToString());
                productionDate.Add(Convert.ToDateTime(row.Cells[3].Value));
                expiryDate.Add(Convert.ToDateTime(row.Cells[4].Value));
                quantity.Add(Convert.ToInt32(row.Cells[5].Value));
                sellingPrice.Add(Convert.ToDouble(row.Cells[6].Value));
                amountTotals.Add((Convert.ToInt32(row.Cells[5].Value)) * (Convert.ToDouble(row.Cells[6].Value)));
                var med = (from x in context.MedicineTables
                           where x.Medicine_Name == row.Cells[0].Value.ToString()
                           select new
                           {
                               x.Buying_Price
                           }).First();
                buyingPrice.Add(Convert.ToDouble(med.Buying_Price));
                profit.Add(Convert.ToDouble(row.Cells[6].Value) - Convert.ToDouble(med.Buying_Price));

            }
            for (int i = 0; i < medicineName.Count; i++)
            {
                SalesReport sale = new SalesReport
                {
                    Buyer = customer,
                    Seller = Userid,
                    Medicine_Name = medicineName[i],
                    Category = category[i],
                    Manufacturer = manufaturer[i],
                    Production_Date = productionDate[i],
                    Expiring_Date = expiryDate[i],
                    Quantity = quantity[i],
                    Selling_Price = sellingPrice[i],
                    Buying_Price = buyingPrice[i],
                    Profit_Gained = profit[i],
                    Date_Of_Sale = DateTime.Now
                };
                context.SalesReports.InsertOnSubmit(sale);
                context.SubmitChanges();
                var updateMedicine = (from x in context.MedicineTables
                                      where x.Medicine_Name == medicineName[i] && x.Manufacturer == manufaturer[i]
                                      select new
                                      {
                                          x.Quantity
                                      }).First();
                int update = Convert.ToInt32(updateMedicine.Quantity) - quantity[i];
                MedicineTable dd = context.MedicineTables.SingleOrDefault(x => x.Medicine_Name == medicineName[i] &&
                                                                             x.Manufacturer == manufaturer[i]);
                dd.Medicine_Name = medicineName[i];
                dd.Category = category[i];
                dd.Manufacturer = manufaturer[i];
                dd.Quantity = update;
                dd.Entry_Date = DateTime.Now;
                dd.Production_Date = productionDate[i];
                dd.Expiring_Date = expiryDate[i];
                dd.Selling_Price = sellingPrice[i];
                dd.Buying_Price = buyingPrice[i];
                context.SubmitChanges();

            }

            PrintPreview print = new PrintPreview();
            print.Customer = customer;
            print.MedicineName = medicineName;
            print.Category = category;
            print.Manufaturer = manufaturer;
            print.ProductionDate = productionDate;
            print.ExpiryDate = expiryDate;
            print.Quantity = quantity;
            print.SellingPrice = sellingPrice;
            print.BuyingPrice = buyingPrice;
            print.AmountTotal = amountTotals;
            print.SubTotal = Convert.ToDouble(subTotalBox.Text);
            print.Total = Convert.ToDouble(total.Text);

            reset();
            print.printPreviewAdmin(this, Userid, "admin");
            print.Show();
        }
        private void reset()
        {
            medicineNameComboBox.SelectedIndex = 0;
            availableAmount.Clear();
            price.Clear();
            amountTotal.Clear();
            amountWanted.Clear();
            subTotalBox.Clear();
            buyer.Clear();
            total.Clear();
            cartDataView.Rows.Clear();
            removeSelectedMedicine.Enabled = false;
            Finish.Enabled = false;
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
