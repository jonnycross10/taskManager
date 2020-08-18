using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskManager
{
    public partial class Form1 : Form
    {
        
        public class myList
        {
            public string listName { get; set; }
            public string listDescription { get; set; }

            public string assigned { get; set; }

            public string state { get; set; }
        }

        public static List<myList> listLog = new List<myList>();

        SignIn s;
  
        public Form1()
        {   
            InitializeComponent();
            this.Size = new Size(1500, 1400);
            s = new SignIn(this);
        }
        
       public void setSubmitVisibility(bool b)
        {
            //showList.Text = "-";
            lName.Visible = b;
            tName.Visible = b;
            lDescription.Visible = b;
            tDescription.Visible = b;
            lAssigned.Visible = b;
            tAssigned.Visible = b;
            lCompleted.Visible = b;
            tCompleted.Visible = b;
            submit.Visible = b;
            shown = b;
        }
        
        public void setLabelVisibility(bool b)
        {
            listView1.Visible = b;
            name.Visible = b;
            description.Visible = b;
            assignedTo.Visible = b;
            state.Visible = b;
            errorLabel.Visible = false;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int i = listBox1.SelectedIndex;
                name.Text = listLog[i].listName;
                errorLabel.Visible = false;
                listView1.Visible = true;               
                description.Text = listLog[i].listDescription;
                assignedTo.Text = listLog[i].assigned;
                state.Text = listLog[i].state;


                listView1.Visible = true;
                name.Visible = true;
                description.Visible = true;
                assignedTo.Visible = true;
                state.Visible = true;
            }
            catch(System.ArgumentOutOfRangeException)
            {
                errorLabel.Visible = true;
                errorLabel.Location = new Point(Cursor.Position.X-7, Cursor.Position.Y-45);
                errorLabel.Text = "Please select an existing index";
            }
        }
        bool shown = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!shown)
            {
                showList.Text="-";
                lName.Visible = true;
                tName.Visible = true;
                lDescription.Visible = true;
                tDescription.Visible = true;
                lAssigned.Visible = true;
                tAssigned.Visible = true;
                lCompleted.Visible = true;
                tCompleted.Visible = true;
                submit.Visible = true;
                shown = true;
            }
            else
            {
                //put into its own method and pass in bool
                showList.Text="+";
                lName.Visible = false;
                tName.Visible = false;
                lDescription.Visible = false;
                tDescription.Visible = false;
                lAssigned.Visible = false;
                tAssigned.Visible = false;
                lCompleted.Visible = false;
                tCompleted.Visible = false;
                submit.Visible = false;
                shown = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            var item1 = new myList
            {
                listName = tName.Text,
                listDescription = tDescription.Text,
                assigned = tAssigned.Text,
                state = tCompleted.Text
            };
            listBox1.Items.Add(item1.listName);
            listLog.Add(item1);
            tName.Text = "";
            tDescription.Text = "";
            tAssigned.Text = "";
            tCompleted.Text = "";
        }



        private async void showList_MouseHover_1(object sender, EventArgs e)
        {
            //check if 
            if(!shown)
            {
                showList.ForeColor = Color.White;
                await Task.Delay(500);
                suggestionLabel1.Visible = true;
            }
            if(shown)
            {
                showList.ForeColor = Color.White;
                await Task.Delay(500);
                suggestionLabel2.Visible = true;
            }
        }

        private void showList_MouseLeave(object sender, EventArgs e)
        {
            showList.ForeColor = Color.Black;
            suggestionLabel1.Visible = false;
            suggestionLabel2.Visible = false;
            
        }

        
        private void signInBtn_Click(object sender, EventArgs e)
        {
            s.Show();
        }
        
        public void signInName(TextBox t)
        {
            nameLabel.Text = " Hello, " + t.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void deleteListItem_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listLog.RemoveAt(index);
            listBox1.Items.RemoveAt(index);
            setLabelVisibility(false);
        }
    }
}
