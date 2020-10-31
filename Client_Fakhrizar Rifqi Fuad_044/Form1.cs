using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Fakhrizar_Rifqi_Fuad_044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hasil;

            hasil = Convert.ToInt32(txtAngka1.Text) + Convert.ToInt32(txtAngka2.Text);
            lblPenjumlahan.Text = hasil.ToString();

            hasil = Convert.ToInt32(txtAngka1.Text) - Convert.ToInt32(txtAngka2.Text);
            lblPengurangan.Text = hasil.ToString();

            hasil = Convert.ToInt32(txtAngka1.Text) * Convert.ToInt32(txtAngka2.Text);
            lblPerkalian.Text = hasil.ToString();

            hasil = Convert.ToInt32(txtAngka1.Text) / Convert.ToInt32(txtAngka2.Text);
            lblPembagian.Text = hasil.ToString();
        }
    }
}
