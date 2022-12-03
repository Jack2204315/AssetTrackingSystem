using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetTrackingSystem
{
    public partial class Direction : Form
    {
        public Direction()
        {
            InitializeComponent();
        }
        //https://www.youtube.com/watch?v=NBOaMrigrRw
        //link above was video used for button form direction.
        private void button1_Click(object sender, EventArgs e)
        {
            deletebtn df = new deletebtn();
            df.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoftwareForm sf = new SoftwareForm();
            sf.Show();
            Visible = false;
        }
    }
}
