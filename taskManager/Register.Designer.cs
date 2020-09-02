namespace taskManager
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.tFirstName = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.regSubButton = new System.Windows.Forms.Button();
            this.errLabel = new System.Windows.Forms.Label();
            this.tLastName = new System.Windows.Forms.TextBox();
            this.lLastName = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(389, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.ForeColor = System.Drawing.Color.White;
            this.lFirstName.Location = new System.Drawing.Point(265, 151);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(86, 20);
            this.lFirstName.TabIndex = 1;
            this.lFirstName.Text = "First Name";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.ForeColor = System.Drawing.Color.White;
            this.lEmail.Location = new System.Drawing.Point(265, 272);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(48, 20);
            this.lEmail.TabIndex = 2;
            this.lEmail.Text = "Email";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.ForeColor = System.Drawing.Color.White;
            this.lPassword.Location = new System.Drawing.Point(265, 341);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(78, 20);
            this.lPassword.TabIndex = 3;
            this.lPassword.Text = "Password";
            // 
            // tFirstName
            // 
            this.tFirstName.Location = new System.Drawing.Point(396, 148);
            this.tFirstName.Name = "tFirstName";
            this.tFirstName.Size = new System.Drawing.Size(181, 26);
            this.tFirstName.TabIndex = 4;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(396, 272);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(181, 26);
            this.tEmail.TabIndex = 6;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(396, 335);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(181, 26);
            this.tPassword.TabIndex = 7;
            // 
            // regSubButton
            // 
            this.regSubButton.Location = new System.Drawing.Point(502, 414);
            this.regSubButton.Name = "regSubButton";
            this.regSubButton.Size = new System.Drawing.Size(75, 29);
            this.regSubButton.TabIndex = 8;
            this.regSubButton.Text = "button1";
            this.regSubButton.UseVisualStyleBackColor = true;
            this.regSubButton.Click += new System.EventHandler(this.regSubButton_Click);
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.Location = new System.Drawing.Point(28, 27);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(0, 20);
            this.errLabel.TabIndex = 9;
            // 
            // tLastName
            // 
            this.tLastName.Location = new System.Drawing.Point(396, 206);
            this.tLastName.Name = "tLastName";
            this.tLastName.Size = new System.Drawing.Size(181, 26);
            this.tLastName.TabIndex = 5;
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.ForeColor = System.Drawing.Color.White;
            this.lLastName.Location = new System.Drawing.Point(265, 212);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(86, 20);
            this.lLastName.TabIndex = 9;
            this.lLastName.Text = "Last Name";
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.ForeColor = System.Drawing.Color.White;
            this.displayLabel.Location = new System.Drawing.Point(785, 119);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(0, 20);
            this.displayLabel.TabIndex = 10;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1024, 540);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.tLastName);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.errLabel);
            this.Controls.Add(this.regSubButton);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tFirstName);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lFirstName);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tFirstName;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button regSubButton;
        private System.Windows.Forms.Label errLabel;
        private System.Windows.Forms.TextBox tLastName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label displayLabel;
    }
}