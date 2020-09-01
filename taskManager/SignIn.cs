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
        /*
        static MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        commandDatabase.CommandTimeout = 60;
        MySqlDataReader reader;
        */

        /*
        Animate the sign in button to load gif

        Enable the Image animation:
        sfButton1.AllowImageAnimation = true;

        Initialize the animation image to SfButton:
        sfButton1.Style.Image = Image.FromFile(@"..\..\Data\animationImage.gif");
        */

        public delegate void delPassData(TextBox text);

        private void signInButton_Click(object sender, EventArgs e)
        {
            
            
            if (nameBox.Text != "" && passBox.Text != "")
            {
                delPassData del = new delPassData(f.signInName);
                del(this.nameBox);
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
