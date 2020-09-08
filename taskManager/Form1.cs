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
using System.Globalization;

namespace taskManager
{
    public partial class Form1 : Form
    {
        //setting the buttons to have no border showing
        
        
        public class myList
        {
            public string listName { get; set; }
            public string listDescription { get; set; }

            public string assigned { get; set; }

            public string state { get; set; }
        }

        public static List<myList> listLog = new List<myList>();

        SignIn s;
        Register r;
        public string userID = "";
  
        public Form1()
        {   
            InitializeComponent();
            this.Size = new Size(1500, 1400);
            s = new SignIn(this);
            r = new Register(this);
            this.showList.FlatAppearance.BorderSize = 0;
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


                setLabelVisibility(true);
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
                setSubmitVisibility(true);
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

            try
            {
                string queryString = "insert into itemTable(itemName, itemDetail, itemAssignedUserID, itemCreateUserID, itemCreateDT, itemUpdateUserID, itemState) " +
                "values( '"+ item1.listName + "', '"+ item1.listDescription + "', 0, '"+userID+"', '" +DateTime.Now +"', 0, O ";
            }
            catch(Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
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
            try
            {
                s.Show();
            }
            catch(System.ObjectDisposedException)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "You already signed in";
            }
        }
        
        //public void signInName(TextBox t)
        //{nameLabel.Text = " Hello, " + t.Text;}



        private void deleteListItem_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listLog.RemoveAt(index);
            listBox1.Items.RemoveAt(index);
            setLabelVisibility(false);
        }

        private void deleteListItem_MouseHover(object sender, EventArgs e)
        {
            deleteListItem.ForeColor = Color.White;
        }

        private void deleteListItem_MouseLeave(object sender, EventArgs e)
        {
            deleteListItem.ForeColor = Color.Black;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            { 
                r.Show(); 
            }
            catch(System.ObjectDisposedException)
            {
                errorLabel.Visible = true;
                errorLabel.Text = "You already clicked this button";
            }
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        //this method will get the items from the database and return them as a list of items
        public  void getList()
        {
            //will need to query for all of the items with a matching user id, obtained from sign in and register pages
            myList[] m = new myList[1]; // set length to the count from the database
            nameLabel.Text = "hello user " + userID;
            try
            {
                //get the assigned and owned lists
                string queryString = "select * from itemTable where itemCreateUserID = '" + userID + "'";
            }
            catch(Exception e)
            {
                errorLabel.Text = e.Message;
            }


            //probably make a for loop to insert the items at beginning of list, in case someone added an item and then signed in
            //listBox1.Items.Insert(0, username);
        }
    }
}
