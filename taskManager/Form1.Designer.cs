namespace taskManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.assignedTo = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.tDescription = new System.Windows.Forms.TextBox();
            this.tAssigned = new System.Windows.Forms.TextBox();
            this.tCompleted = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.lAssigned = new System.Windows.Forms.Label();
            this.lCompleted = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.TMSName = new System.Windows.Forms.Label();
            this.showList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MediumOrchid;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(607, 286);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(520, 304);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Visible = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.MediumOrchid;
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 33;
            this.listBox1.Location = new System.Drawing.Point(26, 286);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(466, 301);
            this.listBox1.TabIndex = 1;
            this.listBox1.Tag = "listbox1";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.MediumOrchid;
            this.name.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(666, 326);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(80, 33);
            this.name.TabIndex = 2;
            this.name.Text = "label1";
            this.name.Visible = false;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.MediumOrchid;
            this.description.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Black;
            this.description.Location = new System.Drawing.Point(924, 326);
            this.description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description.MinimumSize = new System.Drawing.Size(30, 50);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(132, 91);
            this.description.TabIndex = 3;
            this.description.Text = "label2";
            this.description.Visible = false;
            // 
            // assignedTo
            // 
            this.assignedTo.AutoSize = true;
            this.assignedTo.BackColor = System.Drawing.Color.MediumOrchid;
            this.assignedTo.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedTo.ForeColor = System.Drawing.Color.Black;
            this.assignedTo.Location = new System.Drawing.Point(666, 486);
            this.assignedTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.assignedTo.Name = "assignedTo";
            this.assignedTo.Size = new System.Drawing.Size(80, 33);
            this.assignedTo.TabIndex = 4;
            this.assignedTo.Text = "label3";
            this.assignedTo.Visible = false;
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.BackColor = System.Drawing.Color.MediumOrchid;
            this.state.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.ForeColor = System.Drawing.Color.Black;
            this.state.Location = new System.Drawing.Point(924, 486);
            this.state.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(80, 33);
            this.state.TabIndex = 5;
            this.state.Text = "label4";
            this.state.Visible = false;
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(1377, 286);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(407, 26);
            this.tName.TabIndex = 7;
            this.tName.Visible = false;
            // 
            // tDescription
            // 
            this.tDescription.Location = new System.Drawing.Point(1377, 339);
            this.tDescription.Multiline = true;
            this.tDescription.Name = "tDescription";
            this.tDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tDescription.Size = new System.Drawing.Size(407, 78);
            this.tDescription.TabIndex = 8;
            this.tDescription.Visible = false;
            // 
            // tAssigned
            // 
            this.tAssigned.Location = new System.Drawing.Point(1377, 446);
            this.tAssigned.Name = "tAssigned";
            this.tAssigned.Size = new System.Drawing.Size(407, 26);
            this.tAssigned.TabIndex = 9;
            this.tAssigned.Visible = false;
            // 
            // tCompleted
            // 
            this.tCompleted.Location = new System.Drawing.Point(1377, 505);
            this.tCompleted.Name = "tCompleted";
            this.tCompleted.Size = new System.Drawing.Size(407, 26);
            this.tCompleted.TabIndex = 10;
            this.tCompleted.Visible = false;
            this.tCompleted.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.ForeColor = System.Drawing.Color.White;
            this.lName.Location = new System.Drawing.Point(1230, 286);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(54, 24);
            this.lName.TabIndex = 11;
            this.lName.Text = "Name";
            this.lName.Visible = false;
            this.lName.Click += new System.EventHandler(this.lName_Click);
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescription.ForeColor = System.Drawing.Color.White;
            this.lDescription.Location = new System.Drawing.Point(1230, 342);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(98, 24);
            this.lDescription.TabIndex = 12;
            this.lDescription.Text = "Description";
            this.lDescription.Visible = false;
            // 
            // lAssigned
            // 
            this.lAssigned.AutoSize = true;
            this.lAssigned.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAssigned.ForeColor = System.Drawing.Color.White;
            this.lAssigned.Location = new System.Drawing.Point(1230, 452);
            this.lAssigned.Name = "lAssigned";
            this.lAssigned.Size = new System.Drawing.Size(132, 24);
            this.lAssigned.TabIndex = 13;
            this.lAssigned.Text = "Users Assigned";
            this.lAssigned.Visible = false;
            // 
            // lCompleted
            // 
            this.lCompleted.AutoSize = true;
            this.lCompleted.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCompleted.ForeColor = System.Drawing.Color.White;
            this.lCompleted.Location = new System.Drawing.Point(1230, 505);
            this.lCompleted.Name = "lCompleted";
            this.lCompleted.Size = new System.Drawing.Size(93, 24);
            this.lCompleted.TabIndex = 14;
            this.lCompleted.Text = "Completed";
            this.lCompleted.Visible = false;
            this.lCompleted.Click += new System.EventHandler(this.label4_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(1377, 557);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(92, 33);
            this.submit.TabIndex = 15;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Visible = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // TMSName
            // 
            this.TMSName.Font = new System.Drawing.Font("Sylfaen", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMSName.ForeColor = System.Drawing.Color.Black;
            this.TMSName.Location = new System.Drawing.Point(579, 29);
            this.TMSName.Name = "TMSName";
            this.TMSName.Size = new System.Drawing.Size(698, 109);
            this.TMSName.TabIndex = 16;
            this.TMSName.Text = "TMS";
            this.TMSName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TMSName.Click += new System.EventHandler(this.label1_Click);
            // 
            // showList
            // 
            this.showList.FlatAppearance.BorderSize = 0;
            this.showList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.showList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.showList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showList.Image = global::taskManager.Properties.Resources.thisisit;
            this.showList.Location = new System.Drawing.Point(91, 150);
            this.showList.Name = "showList";
            this.showList.Size = new System.Drawing.Size(77, 74);
            this.showList.TabIndex = 6;
            this.showList.Text = " +";
            this.showList.UseVisualStyleBackColor = true;
            this.showList.Click += new System.EventHandler(this.button1_Click);
            this.showList.MouseLeave += new System.EventHandler(this.showList_MouseLeave);
            this.showList.MouseHover += new System.EventHandler(this.showList_MouseHover_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1849, 1050);
            this.Controls.Add(this.TMSName);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.lCompleted);
            this.Controls.Add(this.lAssigned);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tCompleted);
            this.Controls.Add(this.tAssigned);
            this.Controls.Add(this.tDescription);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.showList);
            this.Controls.Add(this.state);
            this.Controls.Add(this.assignedTo);
            this.Controls.Add(this.description);
            this.Controls.Add(this.name);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label assignedTo;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Button showList;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tDescription;
        private System.Windows.Forms.TextBox tAssigned;
        private System.Windows.Forms.TextBox tCompleted;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Label lAssigned;
        private System.Windows.Forms.Label lCompleted;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label TMSName;
    }
}

