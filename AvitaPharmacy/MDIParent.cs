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
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
            LoginForm f1 = new LoginForm();
            f1.MdiParent = this;
            f1.Show(); 
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
