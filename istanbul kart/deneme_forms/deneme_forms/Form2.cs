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
    public partial class Form2 : Form
    {
        public int odeme_verisi = 0;
        public int kalan_bakiye = 0;
        public int yuklenen_tutar = 0;

        // bu programda öğrenci 7 tl, öğrenci olmayan 15 tl ödeme yapmaktadır. Her aktarma öğrenci için 1 tl öğrenci olmayan için 2 tl indirimlidir.

        public Form2()
        {
            InitializeComponent();
        }
        odeme yeniformac = new odeme();
        private void button2_Click(object sender, EventArgs e)
        {
            yeniformac.odeme_verisi = 50;
            yeniformac.ShowDialog();
            label4.Text = yeniformac.yuklenen_tutar.ToString();
            label2.Text = yeniformac.kalan_bakiye.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = yuklenen_tutar.ToString();
            label2.Text = kalan_bakiye.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                if (radioButton1.Checked)
                {
                    if (yeniformac.yuklenen_tutar >= 7)
                    {
                        MessageBox.Show("Öğrenci indirimi ile 7 tl ödeme yapıldı.");
                        yeniformac.yuklenen_tutar = yeniformac.yuklenen_tutar - 7;
                        kalan_bakiye = yeniformac.yuklenen_tutar;
                        label4.Text = kalan_bakiye.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz bakiye");
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (yeniformac.yuklenen_tutar >= 6)
                    {
                        MessageBox.Show("Öğrenci indirimi ile 6 tl ödeme yapıldı.");
                        yeniformac.yuklenen_tutar = yeniformac.yuklenen_tutar - 6;
                        kalan_bakiye = yeniformac.yuklenen_tutar;
                        label4.Text = kalan_bakiye.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz bakiye");
                    }
                }
                else if (radioButton3.Checked)
                {
                    if (yeniformac.yuklenen_tutar >= 5)
                    {
                        MessageBox.Show("Öğrenci indirimi ile 5 tl ödeme yapıldı.");
                        yeniformac.yuklenen_tutar = yeniformac.yuklenen_tutar - 5;
                        kalan_bakiye = yeniformac.yuklenen_tutar;
                        label4.Text = kalan_bakiye.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz bakiye");
                    }
                }
                else if (radioButton4.Checked)
                {
                    if (yeniformac.yuklenen_tutar >= 4)
                    {
                        MessageBox.Show("Öğrenci indirimi ile 4 tl ödeme yapıldı.");
                        yeniformac.yuklenen_tutar = yeniformac.yuklenen_tutar - 4;
                        kalan_bakiye = yeniformac.yuklenen_tutar;
                        label4.Text = kalan_bakiye.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz bakiye");
                    }
                }
            }
            else if (checkBox1.Checked == false)
            {
                if (radioButton1.Checked)
                {
                    if (yeniformac.yuklenen_tutar >= 15)
                    {
                        yeniformac.yuklenen_tutar = yeniformac.yuklenen_tutar - 15;
                        kalan_bakiye = yeniformac.yuklenen_tutar;
                        label4.Text = kalan_bakiye.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz bakiye");
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (yeniformac.yuklenen_tutar >= 13)
                    {
                        yeniformac.yuklenen_tutar = yeniformac.yuklenen_tutar - 13;
                        kalan_bakiye = yeniformac.yuklenen_tutar;
                        label4.Text = kalan_bakiye.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz bakiye");
                    }
                }
                else if (radioButton3.Checked)
                {
                    if (yeniformac.yuklenen_tutar >= 11)
                    {
                        yeniformac.yuklenen_tutar = yeniformac.yuklenen_tutar - 11;
                        kalan_bakiye = yeniformac.yuklenen_tutar;
                        label4.Text = kalan_bakiye.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz bakiye");
                    }
                }
                else if (radioButton4.Checked)
                {
                    if (yeniformac.yuklenen_tutar >= 9)
                    {
                        yeniformac.yuklenen_tutar = yeniformac.yuklenen_tutar - 9;
                        kalan_bakiye = yeniformac.yuklenen_tutar;
                        label4.Text = kalan_bakiye.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz bakiye");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yeniformac.odeme_verisi = 100;
            yeniformac.ShowDialog();
            label4.Text = yeniformac.yuklenen_tutar.ToString();
            label2.Text = yeniformac.kalan_bakiye.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yeniformac.odeme_verisi = 200;
            yeniformac.ShowDialog();
            label4.Text = yeniformac.yuklenen_tutar.ToString();
            label2.Text = yeniformac.kalan_bakiye.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (checkBox1.Checked)
                {
                    odeme_verisi = 7;
                    label2.Text = odeme_verisi.ToString();
                }
                else if (checkBox1.Checked == false)
                {
                    odeme_verisi = 15;
                    label2.Text = odeme_verisi.ToString();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (checkBox1.Checked)
                {
                    odeme_verisi = 6;
                    label2.Text = odeme_verisi.ToString();
                }
                else if (checkBox1.Checked == false)
                {
                    odeme_verisi = 13;
                    label2.Text = odeme_verisi.ToString();
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                if (checkBox1.Checked)
                {
                    odeme_verisi = 5;
                    label2.Text = odeme_verisi.ToString();
                }
                else if (checkBox1.Checked == false)
                {
                    odeme_verisi = 11;
                    label2.Text = odeme_verisi.ToString();
                }
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                if (checkBox1.Checked)
                {
                    odeme_verisi = 4;
                    label2.Text = odeme_verisi.ToString();
                }
                else if (checkBox1.Checked == false)
                {
                    odeme_verisi = 9;
                    label2.Text = odeme_verisi.ToString();
                }
            }
        }
    }
}
