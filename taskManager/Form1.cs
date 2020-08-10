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
        public myList getBackWork()
        {
            
            string nListName = "Work";
            string nListDescription = "Work at petsmart from 9:00 am to 5:30";
            string nAssigned = "Jonny";
            string nState = "incomplete";

            listBox1.DisplayMember = "list1";
            var item1 = new myList { listName = nListName, listDescription = nListDescription, 
            assigned = nAssigned, state = nState};
            return (item1);
        }
  
        public Form1()
        {
            
            //this.AutoSize = true;
            InitializeComponent();
            //set the damn size
            this.Size = new Size(1500, 1400);

            myList item1 = getBackWork();
            //listBox1.Items.Add(item1.listName); //adds listname to the itemBox
        }
        
       
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Visible = true;
            int i = listBox1.SelectedIndex;
            //next line breaks when non existing index is chosen
            //throw in  a try catch, and update label possibly?
            name.Text = listLog[i].listName;
            //description.Text = listBox1.SelectedIndex.ToString();
            description.Text = listLog[i].listDescription;
            //description.Text = getBackWork().listDescription;
            assignedTo.Text = listLog[i].assigned;
            state.Text = listLog[i].state;
            

            listView1.Visible = true;
            name.Visible = true;
            description.Visible = true;
            assignedTo.Visible = true;
            state.Visible = true;
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
    }
}
