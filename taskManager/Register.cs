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
    public partial class Register : Form
    {
        Form1 f;
        public Register(Form1 f1)
        {
            InitializeComponent();
            f = f1;
            this.Size = new Size(700, 400);
        }

        private void dbConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tms;";
            //string addUser = "INSERT into userTable(userFirstName,userLastName, userEmail, userPassword,userStatus) values ()"
            MySqlConnection dbConnect = new MySqlConnection(connectionString);
            try
            {
                dbConnect.Open();
            }
            catch (Exception e)
            {
                errLabel.Text = e.Message;
            }
        }

        public delegate void delPassData(TextBox text);

        private void regSubButton_Click(object sender, EventArgs e)
        {
            if(tFirstName.Text!= "" || tEmail.Text != "" || tPassword.Text != "" )
            {
                delPassData del = new delPassData(f.signInName);
                del(this.tFirstName);
                f.Show();
                this.Close();
            }
            dbConnection();
        }
    }
}
