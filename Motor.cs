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
    public partial class MotorFRM : Form
    {
        public MotorFRM()
        {
            InitializeComponent();
            
        }

        private void MotorFRM_Load(object sender, EventArgs e)
        {
            Arac motor1 = new Motorr();
            motor1.marka = "Yamaha YZF-R1";
            motor1.uretimYeri = "Japonya";
            label1.Text = motor1.marka;
            label7.Text = motor1.uretimYeri;
            label8.Text = motor1.beygir_gücü();
            label9.Text = motor1.vitesTipi("Otomatik Vites");
            label20.Text = "7.70 – 9.45 litre/100km.";

            Arac motor2 = new Motorr();
            motor2.marka = "BMW R NINET";
            motor2.uretimYeri = "Almanya";
            label2.Text = motor2.marka;
            label14.Text = motor2.uretimYeri;
            label15.Text = motor2.beygir_gücü();
            label16.Text = motor2.vitesTipi("Otomatik Vites");
            label21.Text = "5.20 – 5.90 lt / 100 km.";

            comboBox1.Items.Add("Günlük");
            comboBox1.Items.Add("Aylık");

            MessageBox.Show("Tanımlı motor sayısı  Yamaha YZF-R1  ve BMW R NINET olmak üzere  " + Motorr.tms+ " tanedir.", "~HOŞGELDİNİZ~");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arac motor1 = new Motorr();
            motor1.marka = "Yamaha YZF-R1";
            motor1.uretimYeri = "Japonya";
            label1.Text = motor1.marka;
            label7.Text = motor1.uretimYeri;
            label8.Text = motor1.beygir_gücü();
            label9.Text = motor1.vitesTipi("Otomatik Vites");
            label20.Text = "7.70 – 9.45 litre/100km.";

            Arac motor2 = new Motorr();
            motor2.marka = "BMW R NINET";
            motor2.uretimYeri = "Almanya";
            label2.Text = motor2.marka;
            label14.Text = motor2.uretimYeri;
            label15.Text = motor2.beygir_gücü();
            label16.Text = motor2.vitesTipi("Otomatik Vites");
            label21.Text = "5.20 – 5.90 lt / 100 km.";

            if (radioButton1.Checked)
            {
                MessageBox.Show("Toplam ödenecek tutar " + motor1.fiyat(motor1.marka, comboBox1.Text, Convert.ToInt32(textBox1.Text)) + " TL'dir", "TOPLAM ÜCRET");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Toplam ödenecek tutar " + motor1.fiyat(motor2.marka, comboBox1.Text, Convert.ToInt32(textBox1.Text)) + " TL'dir.", "TOPLAM ÜCRET");
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
