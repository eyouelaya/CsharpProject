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
    public partial class ExpiryDateForm : Form
    {
        public ExpiryDateForm()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        { 
            DataClasses1DataContext context = new DataClasses1DataContext();
            var expiredItems = from x in context.MedicineTables
                               where x.Expiring_Date <= DateTime.Now
                               select x; 

            if (expiredItems.Any())
            {
                expiredDataGridView.DataSource = expiredItems;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataClasses1DataContext context = new DataClasses1DataContext();
            var expiredItems = from x in context.MedicineTables
                               where x.Expiring_Date <= Convert.ToDateTime(expiryDateKey.Text)
                               select x;
            if (expiredItems.Any())
            {
                expiredDataGridView.DataSource = expiredItems;
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
