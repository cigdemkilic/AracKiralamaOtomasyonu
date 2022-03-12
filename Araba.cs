using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArackiralamaOtomasyonu
{
    public partial class ArabaFRM : Form
    {
        public ArabaFRM()
        {
            InitializeComponent();
        }

        private void Araba_Load(object sender, EventArgs e)
        {
            Arac araba1 = new Arabaa();
            araba1.marka = "TOGG";
            araba1.uretimYeri = "Türkiye";
            araba1.kisi_ = 5;
            elektrikli_ ea = (elektrikli_)araba1;
            label6.Text = araba1.kisi_.ToString();
            label16.Text = araba1.marka;
            label2.Text = araba1.uretimYeri;
            label4.Text = araba1.vitesTipi("Otomatik vites tipi");
            label24.Text = ea.özellik("Elektrik");
            radioButton1.Enabled = true;



            Arac araba2 = new Arabaa();
            araba2.marka = "RENAULT CAPTUR";
            araba2.uretimYeri = "Almanya";
            araba2.kisi_ = 5;
            elektrikli_ ea1 = (elektrikli_)araba2;
            label13.Text = araba2.kisi_.ToString();
            label15.Text = araba2.marka;
            label9.Text = araba2.uretimYeri;
            label11.Text = araba2.vitesTipi("Manuel vites tipi");
            label25.Text = ea1.özellik("Benzin");


            MessageBox.Show("Tanımlı araba sayısı  TOGG  ve VOLKSWAGEN E-GOLF olmak üzere  " + Arabaa.tas+ " tanedir.", "~HOŞGELDİNİZ~");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arac araba1 = new Arabaa();
            araba1.marka = "TOGG";
            araba1.uretimYeri = "Türkiye";
            araba1.kisi_ = 5;
            elektrikli_ ea = (elektrikli_)araba1;
            label6.Text = araba1.kisi_.ToString();
            label16.Text = araba1.marka;
            label2.Text = araba1.uretimYeri;
            label4.Text = araba1.vitesTipi("Otomatik vites");
            label24.Text = ea.özellik("Elektrik");


            Arac araba2 = new Arabaa();
            araba2.marka = "RENAULT CAPTOR";
            araba2.uretimYeri = "Almanya";
            araba2.kisi_ = 5;
            elektrikli_ ea1 = (elektrikli_)araba2;
            label13.Text = araba2.kisi_.ToString();
            label15.Text = araba2.marka;
            label9.Text = araba2.uretimYeri;
            label11.Text = araba2.vitesTipi("Manuel vites tipi");
            label25.Text = ea1.özellik("Benzin");


            if (radioButton1.Checked)
            {
                MessageBox.Show("toplam ödenecek tutar " + araba1.fiyat(araba1.marka, comboBox1.Text, Convert.ToInt32(textBox1.Text)) + " TL'dir", "TOPLAM ÜCRET");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("toplam ödenecek tutar " + araba1.fiyat(araba2.marka, comboBox1.Text, Convert.ToInt32(textBox1.Text)) + " TL'dir.", "TOPLAM ÜCRET");
            }
            else
                MessageBox.Show("Eksik bilgi girdiniz.", "UYARI!!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
