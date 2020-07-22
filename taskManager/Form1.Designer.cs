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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.assignedTo = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(387, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(348, 199);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Visible = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 199);
            this.listBox1.TabIndex = 1;
            this.listBox1.Tag = "listbox1";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(404, 119);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 2;
            this.name.Text = "label1";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(564, 119);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(35, 13);
            this.description.TabIndex = 3;
            this.description.Text = "label2";
            // 
            // assignedTo
            // 
            this.assignedTo.AutoSize = true;
            this.assignedTo.Location = new System.Drawing.Point(407, 183);
            this.assignedTo.Name = "assignedTo";
            this.assignedTo.Size = new System.Drawing.Size(35, 13);
            this.assignedTo.TabIndex = 4;
            this.assignedTo.Text = "label3";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(567, 183);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(35, 13);
            this.state.TabIndex = 5;
            this.state.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.state);
            this.Controls.Add(this.assignedTo);
            this.Controls.Add(this.description);
            this.Controls.Add(this.name);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

