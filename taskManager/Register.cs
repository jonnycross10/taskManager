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
                //see if user exists
                
                try
                {
                    string output = "";
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tms;";
                    string existingAccount = "select * from userTable;"; 
                    //string existingAccount = "select * from userTable where " + this.tEmail + " = userEmail;";
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    conn.Open();
                    MySqlCommand com = new MySqlCommand(existingAccount, conn);
                    MySqlDataReader dr = com.ExecuteReader();
                    while(dr.Read())
                    {
                        if (dr.GetValue(0).ToString() != "") // did we get empty data from the database? if we didnt then give a value to output
                        {
                            output = output + dr.GetValue(0).ToString() + dr.GetValue(1);
                        }
                    }
                    errLabel.Text = "An account already exists, try another email!";



                    //if the statement didn't return any values then you are free to make the account
                    if (output == "")
                    {
                        try
                        {
                            string connectionString2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=tms;";
                            string addUser = "INSERT into userTable(userFirstName,userLastName, userEmail, userPassword,userStatus) values ('" + this.tFirstName.Text + "','" + this.tLastName.Text + "', '" + this.tEmail + "', '" + this.tPassword + "','a')";
                            MySqlConnection dbConnect = new MySqlConnection(connectionString2);
                            MySqlCommand myCommand = new MySqlCommand(addUser, dbConnect);
                            dbConnect.Open();
                            MySqlDataReader myReader = myCommand.ExecuteReader();
                            while (myReader.Read())
                            {

                            }
                            dbConnect.Close();
                        }
                        catch (Exception ex)
                        {
                            errLabel.Text = ex.Message;
                        }
                    }





                }
                catch (Exception ex)
                {
                    errLabel.Text = ex.Message;
                }

                
              



                f.Show();
                //this.Close();
            }
            dbConnection();
        }
    }
}
