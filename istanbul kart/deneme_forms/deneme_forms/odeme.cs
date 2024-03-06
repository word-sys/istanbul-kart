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
    public partial class odeme : Form
    {
        public odeme()
        {
            InitializeComponent();
        }
        public int yuklenen_tutar;
        public int odeme_verisi;
        public int kalan_bakiye;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void odeme_Load(object sender, EventArgs e)
        {
            label1.Text= odeme_verisi.ToString();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para yüklemek istediğinize eminmisiniz ?");
            Form2 akbilformu= new Form2();
            yuklenen_tutar += odeme_verisi;
            this.Close();
        }
    }
}
