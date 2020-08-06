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
    public partial class Form1 : Form
    {
        public class myList
        {
            public string listName { get; set; }
            public string listDescription { get; set; }

            public string assigned { get; set; }

            public string state { get; set; }
        }
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
            InitializeComponent();

            myList item1 = getBackWork();
            listBox1.Items.Add(item1.listName); //adds listname to the itemBox
        }

       
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Visible = true;
            name.Text = listBox1.SelectedItem.ToString();
            description.Text = getBackWork().listDescription;
            assignedTo.Text = getBackWork().assigned;
            state.Text = getBackWork().state;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lName.Visible = true;
            tName.Visible = true;
            lDescription.Visible = true;
            tDescription.Visible = true;
            lAssigned.Visible = true;
            tAssigned.Visible = true;
            lCompleted.Visible = true;
            tCompleted.Visible = true;
            submit.Visible = true;
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
    }
}
