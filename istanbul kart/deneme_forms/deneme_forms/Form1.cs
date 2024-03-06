using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("erkek");
                radioButton2.Checked = true;
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("kadın");
            }
            else if (checkBox1.Checked)
            {
                MessageBox.Show("küçük kadın");
            }
            
           
        }
    }
}
