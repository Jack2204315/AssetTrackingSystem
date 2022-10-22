
namespace AssetTrackingSystem
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
            this.syname = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.manfac = new System.Windows.Forms.Label();
            this.mod = new System.Windows.Forms.Label();
            this.sysname = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // syname
            // 
            this.syname.AutoSize = true;
            this.syname.Location = new System.Drawing.Point(23, 118);
            this.syname.Name = "syname";
            this.syname.Size = new System.Drawing.Size(72, 13);
            this.syname.TabIndex = 0;
            this.syname.Text = "System Name";
            this.syname.Click += new System.EventHandler(this.label1_Click);
            // 
            // ip
            // 
            this.ip.AutoSize = true;
            this.ip.Location = new System.Drawing.Point(37, 222);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(58, 13);
            this.ip.TabIndex = 1;
            this.ip.Text = "IP Address";
            this.ip.Click += new System.EventHandler(this.label2_Click);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(64, 196);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(31, 13);
            this.type.TabIndex = 2;
            this.type.Text = "Type";
            // 
            // manfac
            // 
            this.manfac.AutoSize = true;
            this.manfac.Location = new System.Drawing.Point(25, 170);
            this.manfac.Name = "manfac";
            this.manfac.Size = new System.Drawing.Size(70, 13);
            this.manfac.TabIndex = 3;
            this.manfac.Text = "Manufacturer";
            // 
            // mod
            // 
            this.mod.AutoSize = true;
            this.mod.Location = new System.Drawing.Point(59, 144);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(36, 13);
            this.mod.TabIndex = 4;
            this.mod.Text = "Model";
            // 
            // sysname
            // 
            this.sysname.Location = new System.Drawing.Point(101, 115);
            this.sysname.Name = "sysname";
            this.sysname.Size = new System.Drawing.Size(247, 20);
            this.sysname.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(247, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(101, 167);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(247, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(101, 141);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(247, 20);
            this.textBox5.TabIndex = 9;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(101, 253);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(246, 28);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "Insert new asset data";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sysname);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.manfac);
            this.Controls.Add(this.type);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.syname);
            this.Name = "Form1";
            this.Text = "Asset Tracking System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label syname;
        private System.Windows.Forms.Label ip;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label manfac;
        private System.Windows.Forms.Label mod;
        private System.Windows.Forms.TextBox sysname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_insert;
    }
}

