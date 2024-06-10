using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_bangcuuchuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            lbsketqua.Items.Clear();
            int cc = Convert.ToInt32(txtso.Text);
            for (int i = 1; i <= 10; i++)
            {
                //lbsketqua.Items.Add(txtso.Text + " x " + i.ToString() + " = " + Convert.ToString(cc*i));
                lbsketqua.Items.Add(string.Format("{1} x {0} = {2}",txtso.Text,i.ToString(),Convert.ToString(cc*i)));
            }
        }
    }
}
