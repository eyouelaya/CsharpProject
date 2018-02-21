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
    public partial class PrintPreview : Form
    {
        static Form parent;
        static String type;
        static String id;
        public PrintPreview()
        {
            InitializeComponent();
        }

        public String Customer { set; get; }
        public IList<String> MedicineName { set; get; }
        public IList<String> Category { set; get; }
        public IList<String> Manufaturer { set; get; }
        public IList<DateTime> ProductionDate { set; get; }
        public IList<DateTime> ExpiryDate { set; get; }
        public IList<int> Quantity { set; get; }
        public IList<Double> BuyingPrice { set; get; }
        public IList<Double> SellingPrice { set; get; }
        public IList<Double> AmountTotal { set; get; }
        public Double SubTotal { set; get; }
        public Double Total { set; get; }
        public void printPreview(Form f,String t)
        {
            parent = f;
            type = t;
            f.Enabled = false;
        }
        public void printPreviewAdmin(Form f, String id, String t)
        {
            parent = f;
            type = t;
            f.Enabled = false;
        }
        private void PrintPreview_Load(object sender, EventArgs e)
        {
            String head = "<html><head><title></title>" +
                          "<style>" +
                           " label{ " +
                           " display:block; " +
                           " } " +
                           " div{" +
                           "float:right; " +
                           "padding: 50px;" +
                           "padding-right:200px;" +
                           "}" +
                           "h1{" +
                           "padding:10px;" + 
                           "display:block;" +
                           "text-align:center" +
                           "}" +
                           "#customer{" +
                           "font-size:17px;" +
                           "padding:10px;"+
                           "}"+
                           "#date{"+
                           "position:absolute;"+
                           "top:3px;"+
                           "left:700px;"+
                           "font-size:12px;"+
                           "}"+

                          "</style> </head>"+
                "<body>"+
                "<h1> Avita Pharmacy </h1>"+
                "<label id=\"customer\">Customer or Tin number: "+Customer+"</label>"+
                "<label id=\"date\">Date "+DateTime.Now+"</label>"+

                "<label>"+
                "<table style=\"text-align:center;\" width=\"700px\"><tr><th >Medicine Name</th><th>Expiry Date</th><th>Quantity</th><th>Price</th><th>Total</th></tr>";
            String data = null;
            for (int i = 0; i < MedicineName.Count; i++)
            {
                data += "<tr>";
                data += "<td>" + MedicineName[i] + "</td>";
                data += "<td>" + ExpiryDate[i] + "</td>";
                data += "<td>" + Quantity[i] + "</td>";
                data += "<td>" + SellingPrice[i] + "</td>";
                data += "<td>" + AmountTotal[i] + "</td>";
                data += "</tr>";
            }
            data += "</table>";
            data += "<div><label>SubTotal " + SubTotal + "</label>";
            data += "<label>Tax  15%<label>";
            data += "<label>Total " + Total + "</label></div>";
            String end = "</body></html>";
            String totalData = head + data + end;
            receiptPreview.DocumentText = totalData;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if(type == "sale")
            {
                SfSaleForm sf = new SfSaleForm();
                sf.SaleForm(parent);
            }
            else
            {
                AdminSaleForm ad = new AdminSaleForm(id);
                ad.SaleForm(parent);


            }
            
            this.Close();

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            receiptPreview.Print();
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
