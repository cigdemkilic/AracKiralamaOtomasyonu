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
    public partial class BisikletFRM : Form
    {
        Bisiklett bisiklet1 = new Bisiklett();
        Bisiklett bisiklet2 = new Bisiklett();
        Bisiklett bisiklet3 = new Bisiklett();
        Bisiklett bisiklet4 = new Bisiklett();
        public int sure_;
        public string combo_;

        public BisikletFRM()
        {
            InitializeComponent();
        }


        private void BisikletFRM_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Bisiklett.tbs.ToString() + "  tanımlı bisiklet vardır.");

            bisiklet1.tur = "Çocuk Bisikleti";
            bisiklet1.marka = "Flash";
            bisiklet1.malzeme = "Çelik";
            bisiklet1.agirlik = 9.1;
            bisiklet1.uretimYeri = "Türkiye";
            radioButton1.Text = bisiklet1.tur;
            label2.Text = bisiklet1.tur;
            label4.Text = bisiklet1.marka;
            label6.Text = "Üretim yeri " + bisiklet1.uretimYeri + " " + bisiklet1.vitesTipi("Vitessiz") + "\n" + bisiklet1.malzeme + " kadro " + bisiklet1.agirlik + " Kg";

            bisiklet2.tur = "Dağ Bisikleti";
            bisiklet2.marka = "Corelli Zengo";
            bisiklet2.malzeme = "Alloy";
            bisiklet2.agirlik = 17.2;
            bisiklet2.uretimYeri = "Türkiye";
            radioButton2.Text = bisiklet2.tur;
            label21.Text = bisiklet2.tur;
            label22.Text = bisiklet2.marka;
            label23.Text = "Üretim yeri " + bisiklet2.uretimYeri + " " + bisiklet2.vitesTipi("21 Vites") + "\n" + bisiklet2.malzeme + " kadro " + bisiklet2.agirlik + " Kg";

            bisiklet3.tur = "Şehir Bisikleti1";
            bisiklet3.marka = "Canello";
            bisiklet3.malzeme = "26 Hi-Ten";
            bisiklet3.agirlik = 12.6;
            bisiklet3.uretimYeri = "Türkiye";
            radioButton3.Text = bisiklet3.tur;
            label25.Text = bisiklet3.tur;
            label26.Text = bisiklet3.marka;
            label27.Text = "Üretim yeri " + bisiklet3.uretimYeri + " " + bisiklet3.vitesTipi("21 Vites") + "\n" + bisiklet3.malzeme + " kadro " + bisiklet3.agirlik + " Kg";

            bisiklet4.tur = "Şehir Bisikleti2";
            bisiklet4.marka = "Bisan";
            bisiklet4.malzeme = "Çelik";
            bisiklet4.agirlik = 17;
            bisiklet4.uretimYeri = "Türkiye";
            radioButton4.Text = bisiklet4.tur;
            label29.Text = bisiklet4.tur;
            label30.Text = bisiklet4.marka;
            label31.Text = "Üretim yeri " + bisiklet4.uretimYeri + " " + bisiklet4.vitesTipi("7 Vites") + "\n" + bisiklet4.malzeme + " kadro " + bisiklet4.agirlik + " Kg";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            combo_ = comboBox1.Text;
            sure_ = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
                textBox2.Text = bisiklet1.fiyat("Çocuk", combo_, sure_).ToString();
            else if (radioButton2.Checked)
                textBox2.Text = bisiklet2.fiyat("Dağ", combo_, sure_).ToString();
            else
                textBox2.Text = bisiklet3.fiyat("Şehir", combo_, sure_).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Fiyat hesaplattırınız!");
            }
            else
            {
                if (radioButton1.Checked)
                    MessageBox.Show(bisiklet1.marka + " marka " + bisiklet1.tur + " " + sure_ + " " + combo_ + " " + textBox2.Text + " Tl'ye" + " kiralanmıştır.");
                else if (radioButton2.Checked)
                    MessageBox.Show(bisiklet2.marka + " marka " + bisiklet2.tur + " " + sure_ + " " + combo_ + " " + textBox2.Text + " Tl'ye" + " kiralanmıştır.");
                else if (radioButton3.Checked)
                    MessageBox.Show(bisiklet3.marka + " marka " + bisiklet3.tur + " " + sure_ + " " + combo_ + " " + textBox2.Text + " Tl'ye" + " kiralanmıştır.");
                else
                    MessageBox.Show(bisiklet4.marka + " marka " + bisiklet4.tur + " " + sure_ + " " + combo_ + " " + textBox2.Text + " Tl'ye" + " kiralanmıştır.");

                comboBox1.SelectedItem = null;
                textBox1.Clear();
                textBox2.Clear();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
