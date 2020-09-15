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

        //public delegate void delPassData(TextBox text);

        private void regSubButton_Click(object sender, EventArgs e)
        {
            string userId = "";
            if(tFirstName.Text!= "" || tEmail.Text != "" || tPassword.Text != "" )
            {
                //delPassData del = new delPassData(f.signInName);
                //del(this.tFirstName);
                //see if user exists
                
                try
                {
                    int output = 0;
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=tms;";
                    //string existingAccount = "select * from userTable;"; 
                    string existingAccount = "select * from userTable where userEmail = '" + this.tEmail.Text + "';";
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    conn.Open();
                    MySqlCommand com = new MySqlCommand(existingAccount, conn);
                    MySqlDataReader dr = com.ExecuteReader();
                    while(dr.Read())
                    {
                        displayLabel.Text = dr.GetValue(0).ToString();
                        if (dr.GetInt32(0) != 0) // did we get empty data from the database? if we didnt then give a value to output
                        {
                            output = dr.GetInt32(0);
                            errLabel.Text = "There is already an account signed up with that email.";
                        }
                    }
                    
                    //displayLabel.Text = output.ToString(); // show what the query returned 



                    //if the statement didn't return any values then you are free to make the account
                    if (output == 0)
                    {
                        try
                        {
                            string connectionString2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=tms;";
                            string addUser = "INSERT into userTable(userFirstName,userLastName, userEmail, userPassword,userStatus) values ('" + this.tFirstName.Text + "','" + this.tLastName.Text + "', '" + this.tEmail.Text + "', '" + this.tPassword.Text + "','a')";
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

                        //get the userid from newly inserted row in the database
                        try
                        {
                            string connectionString2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=tms;";
                            string addUser = "select userID from userTable where userEmail = '" + this.tEmail + "'";
                            MySqlConnection dbConnect = new MySqlConnection(connectionString2);
                            MySqlCommand myCommand = new MySqlCommand(addUser, dbConnect);
                            dbConnect.Open();
                            MySqlDataReader myReader = myCommand.ExecuteReader();
                            while (myReader.Read())
                            {                                
                                userId = myReader.GetValue(0).ToString();
                                
                                errLabel.Text = userId;
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
