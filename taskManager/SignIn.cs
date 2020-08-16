using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskManager
{
    public partial class SignIn : Form
    {
        Form1 f;
        public SignIn(Form1 f1)
        {
            InitializeComponent();
            f = f1;
        }

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
    }
}
