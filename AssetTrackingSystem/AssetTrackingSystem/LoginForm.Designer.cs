
namespace AssetTrackingSystem
{
    partial class LoginForm
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
            this.UsertextBox = new System.Windows.Forms.TextBox();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.Userlbl = new System.Windows.Forms.Label();
            this.Passlbl = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.feedbacklbl = new System.Windows.Forms.Label();
            this.passbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UsertextBox
            // 
            this.UsertextBox.Location = new System.Drawing.Point(175, 143);
            this.UsertextBox.Name = "UsertextBox";
            this.UsertextBox.Size = new System.Drawing.Size(198, 20);
            this.UsertextBox.TabIndex = 0;
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(175, 178);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.Size = new System.Drawing.Size(198, 20);
            this.PassTextBox.TabIndex = 1;
            this.PassTextBox.TextChanged += new System.EventHandler(this.PassTextBox_TextChanged);
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Location = new System.Drawing.Point(114, 146);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(55, 13);
            this.Userlbl.TabIndex = 2;
            this.Userlbl.Text = "Username";
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.Location = new System.Drawing.Point(114, 181);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(53, 13);
            this.Passlbl.TabIndex = 3;
            this.Passlbl.Text = "Password";
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(230, 233);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 23);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please enter your username and \r\npassword to continue";
            // 
            // feedbacklbl
            // 
            this.feedbacklbl.AutoSize = true;
            this.feedbacklbl.Location = new System.Drawing.Point(172, 210);
            this.feedbacklbl.Name = "feedbacklbl";
            this.feedbacklbl.Size = new System.Drawing.Size(0, 13);
            this.feedbacklbl.TabIndex = 6;
            // 
            // passbox
            // 
            this.passbox.AutoSize = true;
            this.passbox.Location = new System.Drawing.Point(379, 180);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(102, 17);
            this.passbox.TabIndex = 7;
            this.passbox.Text = "Show Password";
            this.passbox.UseVisualStyleBackColor = true;
            this.passbox.CheckedChanged += new System.EventHandler(this.passbox_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 368);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.feedbacklbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.Passlbl);
            this.Controls.Add(this.Userlbl);
            this.Controls.Add(this.PassTextBox);
            this.Controls.Add(this.UsertextBox);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsertextBox;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.Label Passlbl;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label feedbacklbl;
        private System.Windows.Forms.CheckBox passbox;
    }
}