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
    public partial class LoginForm : Form
    {
        static String loggedInUserID;
        static String loggedInUserName;
        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = userIDInput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String userId = userIDInput.Text.Trim();
            String password = passwordInput.Text.Trim();
            if ( userId == "" )
            {
                userIDError.Text = "UserID is required";
                passwordError.Text = "";
                loginError.Text = ""; 
            } 
            if (password == "")
            {
                passwordError.Text = "Password is required";
                userIDError.Text = "";
                loginError.Text = "";

            } 
            if (userId == "" && password == "") 
            {
                userIDError.Text = "UserID is required";
                passwordError.Text = "Password is required";
                loginError.Text = "";

            }
            if( userId != "" && password !="")
            {
                userIDError.Text = "";
                passwordError.Text = "";
                DataClasses1DataContext db = new DataClasses1DataContext();
                var dbGet =(from q in db.Users
                             where q.UserID == userId && q.Password == password
                             select new{
                                 q.UserID,
                                 q.First_Name,
                                 q.User_Type
                             }).SingleOrDefault();
               try{
                   if(dbGet.UserID.Any())
                   {
                        loggedInUserID = dbGet.UserID;
                        loggedInUserName = dbGet.First_Name ; 
                        MenuForm f2 = new MenuForm();
                        SfSaleForm sf = new SfSaleForm();

                        if (dbGet.User_Type == "Administrator")
                        { 
                            f2.LoggedInUserID= loggedInUserID;
                            f2.LoggedInUserName = loggedInUserName;
                            f2.MdiParent = this.MdiParent;
                            f2.Show();
                            this.Hide();
                        }
                        else
                        {
                            sf.LoggedInUserID = loggedInUserID;
                            sf.LoggedInUserName = loggedInUserName;
                            sf.MdiParent = this.MdiParent;
                            sf.Show();
                            this.Hide(); 
                        }
                         
                       
                 }
               }
                catch(Exception){
                    loginError.Text = "UserID or Password incorrect, Try again"; 
                }
            }
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        { 
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
