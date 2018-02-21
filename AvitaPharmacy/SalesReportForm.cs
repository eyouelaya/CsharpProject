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
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
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

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            var data = from x in context.SalesReports
                       select x;
            if (data.Any())
            {
                salesReportData.DataSource = data;
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
                    var items1 = from x in context.SalesReports
                                 where x.Medicine_Name.Contains(key) ||
                                       x.Category.Contains(key) ||
                                       x.Manufacturer.Contains(key) ||
                                       x.Seller.Contains(key) ||
                                       x.Buyer.Contains(key)
                                 select x;
                    if (items1.Any())
                    {
                        salesReportData.DataSource = items1;
                    }
                }
                var items = from x in context.SalesReports
                            where x.Medicine_Name.Contains(key) && x.Category == category ||
                                  x.Category.Contains(key) && x.Category == category ||
                                  x.Manufacturer.Contains(key) && x.Category == category ||
                                   x.Seller.Contains(key) && x.Category == category ||
                                   x.Buyer.Contains(key) && x.Category == category
                            select x;
                if (items.Any())
                {
                    salesReportData.DataSource = items;
                }
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
