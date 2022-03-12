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
    public partial class AnasayfaFRM : Form
    {
        public AnasayfaFRM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form araba = new ArabaFRM();
            araba.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form motor = new MotorFRM();
            motor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form bisiklet = new BisikletFRM();
            bisiklet.Show();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
