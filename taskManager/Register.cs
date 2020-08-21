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
    public partial class Register : Form
    {
        Form1 f;
        public Register(Form1 f1)
        {
            InitializeComponent();
            f = f1;
            this.Size = new Size(500, 400);
        }
    }
}
