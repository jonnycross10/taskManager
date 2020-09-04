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

        public delegate void delPassData(TextBox text);

        private void signInButton_Click(object sender, EventArgs e)
        {
            
            
            if (tEmail.Text != "" && passBox.Text != "")
            {
                delPassData del = new delPassData(f.signInName);
                del(this.tEmail);

                try
                {
                    int output =0; // will contain user id number if one is found
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tms;";
                    string query = "select * from userTable where userEmail = '" + this.tEmail.Text +"';";
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    MySqlCommand com = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader dr = com.ExecuteReader();
                    while(dr.Read())
                    {
                        output = dr.GetInt32(0);
                    }

                }
                catch(Exception ex)
                {
                    errLabel.Text = ex.Message;
                }

                f.Show();
                this.Close();
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
