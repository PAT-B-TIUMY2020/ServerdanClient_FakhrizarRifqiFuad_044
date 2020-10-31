using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceMtk_P1_044;

namespace Server_FakhrizarRifqiFuad_044
{
    public partial class Form1 : Form
    {
        ServiceHost hostObj = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOff.Enabled = false;
            btnOn.Enabled = true;

            lblServer.Text = "OFF";
            lblStatus.Text = "Klik ON untuk Menjalankan Server";
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            hostObj = new ServiceHost(typeof(Matematika));
            hostObj.Close();
            btnOff.Enabled = false;
            btnOn.Enabled = true;

            lblServer.Text = "OFF";
            lblStatus.Text = "Klik ON untuk Menjalankan Server";
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            hostObj = new ServiceHost(typeof(Matematika));
            hostObj.Open();
            btnOff.Enabled = true;
            btnOn.Enabled = false;

            lblServer.Text = "ON";
            lblStatus.Text = "Klik OFF untuk Mematikan Server";
            hostObj.Close();
        }
    }
}
