
namespace AssetTrackingSystem
{
    partial class deletebtn
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
            this.SystemTextBox = new System.Windows.Forms.TextBox();
            this.IPadTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.ManuTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView_hardware = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.insertbtn = new System.Windows.Forms.Button();
            this.ExtraDataTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hardware)).BeginInit();
            this.SuspendLayout();
            // 
            // syname
            // 
            this.syname.AutoSize = true;
            this.syname.Location = new System.Drawing.Point(7, 109);
            this.syname.Name = "syname";
            this.syname.Size = new System.Drawing.Size(72, 13);
            this.syname.TabIndex = 0;
            this.syname.Text = "System Name";
            this.syname.Click += new System.EventHandler(this.label1_Click);
            // 
            // ip
            // 
            this.ip.AutoSize = true;
            this.ip.Location = new System.Drawing.Point(21, 213);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(58, 13);
            this.ip.TabIndex = 1;
            this.ip.Text = "IP Address";
            this.ip.Click += new System.EventHandler(this.label2_Click);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(48, 187);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(31, 13);
            this.type.TabIndex = 2;
            this.type.Text = "Type";
            // 
            // manfac
            // 
            this.manfac.AutoSize = true;
            this.manfac.Location = new System.Drawing.Point(9, 161);
            this.manfac.Name = "manfac";
            this.manfac.Size = new System.Drawing.Size(70, 13);
            this.manfac.TabIndex = 3;
            this.manfac.Text = "Manufacturer";
            // 
            // mod
            // 
            this.mod.AutoSize = true;
            this.mod.Location = new System.Drawing.Point(43, 135);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(36, 13);
            this.mod.TabIndex = 4;
            this.mod.Text = "Model";
            // 
            // SystemTextBox
            // 
            this.SystemTextBox.Location = new System.Drawing.Point(85, 106);
            this.SystemTextBox.Name = "SystemTextBox";
            this.SystemTextBox.Size = new System.Drawing.Size(247, 20);
            this.SystemTextBox.TabIndex = 5;
            // 
            // IPadTextBox
            // 
            this.IPadTextBox.Location = new System.Drawing.Point(85, 210);
            this.IPadTextBox.Name = "IPadTextBox";
            this.IPadTextBox.Size = new System.Drawing.Size(247, 20);
            this.IPadTextBox.TabIndex = 6;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(85, 184);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(247, 20);
            this.TypeTextBox.TabIndex = 7;
            // 
            // ManuTextBox
            // 
            this.ManuTextBox.Location = new System.Drawing.Point(85, 158);
            this.ManuTextBox.Name = "ManuTextBox";
            this.ManuTextBox.Size = new System.Drawing.Size(247, 20);
            this.ManuTextBox.TabIndex = 8;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(85, 132);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(247, 20);
            this.ModelTextBox.TabIndex = 9;
            // 
            // dataGridView_hardware
            // 
            this.dataGridView_hardware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hardware.Location = new System.Drawing.Point(362, 47);
            this.dataGridView_hardware.Name = "dataGridView_hardware";
            this.dataGridView_hardware.Size = new System.Drawing.Size(426, 335);
            this.dataGridView_hardware.TabIndex = 11;
            this.dataGridView_hardware.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hardware_CellClick_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "View data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // insertbtn
            // 
            this.insertbtn.Location = new System.Drawing.Point(85, 302);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(246, 28);
            this.insertbtn.TabIndex = 13;
            this.insertbtn.Text = "Insert data";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // ExtraDataTextBox
            // 
            this.ExtraDataTextBox.Location = new System.Drawing.Point(85, 236);
            this.ExtraDataTextBox.Multiline = true;
            this.ExtraDataTextBox.Name = "ExtraDataTextBox";
            this.ExtraDataTextBox.Size = new System.Drawing.Size(247, 60);
            this.ExtraDataTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Extra Data";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(362, 388);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(198, 28);
            this.editbtn.TabIndex = 16;
            this.editbtn.Text = "Edit data";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Delete data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deletebtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExtraDataTextBox);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView_hardware);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.ManuTextBox);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.IPadTextBox);
            this.Controls.Add(this.SystemTextBox);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.manfac);
            this.Controls.Add(this.type);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.syname);
            this.Name = "deletebtn";
            this.Text = "Asset Tracking System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hardware)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label syname;
        private System.Windows.Forms.Label ip;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label manfac;
        private System.Windows.Forms.Label mod;
        private System.Windows.Forms.TextBox SystemTextBox;
        private System.Windows.Forms.TextBox IPadTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox ManuTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.DataGridView dataGridView_hardware;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.TextBox ExtraDataTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button button1;
    }
}

