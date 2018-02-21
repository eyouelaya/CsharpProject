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
    public partial class MenuForm : Form
    {
        static String UserId;
        static String UserName;
        public MenuForm()
        {
            InitializeComponent();
        }
        public string LoggedInUserID { set; get; }
        public string LoggedInUserName { set; get; }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            AddMedicineForm f3 = new AddMedicineForm();
            f3.MdiParent = this.MdiParent;
            f3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point pointerLocation = new Point(0, btnSender.Height);
            pointerLocation = btnSender.PointToScreen(pointerLocation);
            contextMenuStrip1.Show(pointerLocation);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
             
            ViewMedicineForm f4 = new ViewMedicineForm();
            f4.MdiParent = this.MdiParent;
            f4.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            LoginForm f1 = new LoginForm();
            f1.MdiParent = this.MdiParent;
            f1.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
            EditMedicineForm f5 = new EditMedicineForm();
            f5.MdiParent = MdiParent;
            f5.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            DeleteMedicineForm f6 = new DeleteMedicineForm();
            f6.MdiParent = this.MdiParent;
            f6.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
          
            ExpiryDateForm f7 = new ExpiryDateForm();
            f7.MdiParent = this.MdiParent;
            f7.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            AddUserForm f8 = new AddUserForm();
            f8.MdiParent = this.MdiParent;
            f8.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
            ViewUserForm f9 = new ViewUserForm();
            f9.MdiParent = this.MdiParent;
            f9.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
            EditUserForm f10 = new EditUserForm();
            f10.MdiParent = this.MdiParent;
            f10.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           
            DeleteUserForm f11 = new DeleteUserForm();
            f11.MdiParent = this.MdiParent;
            f11.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

            AdminSaleForm f12 = new AdminSaleForm(UserId); 
            f12.MdiParent = this.MdiParent;
            f12.Show(); 
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            
            SalesReportForm f13 = new SalesReportForm();
            f13.MdiParent = this.MdiParent;
            f13.Show();
            this.Hide();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
        
            ViewMedicineForm f4 = new ViewMedicineForm();
            f4.MdiParent = this.MdiParent;
            f4.Show();
            this.Hide();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        { 
            if(UserId == null)
             UserId = LoggedInUserID;
            if (UserName == null)
                UserName = LoggedInUserName;
            user.Text = "Logged in As: " + UserName;

            
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
