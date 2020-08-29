namespace taskManager
{
    partial class SignIn
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.errLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(460, 205);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(162, 26);
            this.nameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign In to TMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(366, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(366, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(460, 261);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(162, 26);
            this.passBox.TabIndex = 4;
            this.passBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passBox_KeyPress);
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(546, 321);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(75, 23);
            this.signInButton.TabIndex = 5;
            this.signInButton.Text = "Submit";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(599, 120);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 6;
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.Location = new System.Drawing.Point(123, 119);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(0, 20);
            this.errLabel.TabIndex = 7;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1024, 540);
            this.Controls.Add(this.errLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label errLabel;
    }
}