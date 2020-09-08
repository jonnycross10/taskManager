using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace taskManager
{
    public partial class SignIn : Form
    {
        Form1 f;
        public SignIn(Form1 f1)
        {
            InitializeComponent();
            f = f1;
            this.Size = new Size(700,400);
        }
        private void dbConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tms;";
            MySqlConnection dbConnect = new MySqlConnection(connectionString);
            try
            {
                dbConnect.Open();
            }
            catch(Exception e)
            {
                errLabel.Text = e.Message;
            }
        }

        //public delegate void delPassData(TextBox text);

        public void signInButton_Click(object sender, EventArgs e)
        {
            
            
            if (tEmail.Text != "" && passBox.Text != "")
            {
                //delPassData del = new delPassData(f.signInName);
                //del(this.tEmail);
                int id = 0; // will contain user id number if one is found
                string fn = "";

                try
                {
                    
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tms;";
                    string query = "select * from userTable where userEmail = '" + this.tEmail.Text +"';";
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    MySqlCommand com = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader dr = com.ExecuteReader();
                    while(dr.Read())
                    {
                        id = dr.GetInt32(0);
                        fn = dr.GetString(1);
                    }
                    errLabel.Text = dr.GetInt32(0).ToString() + fn;

                }
                catch(Exception ex)
                {
                    errLabel.Text = ex.Message;
                }
                //pass user id to form 1 method so i can call the database with it in form1
                
                f.Show();
                f.userID = id.ToString();
                //f.getList(id);
                //if it works
                //this.Close();
            }
            else
            {
                errorLabel.Text = "user name and password must not be blank";
                
            }

            
        }

        private void passBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            passBox.PasswordChar = '\u2022';
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
