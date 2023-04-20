using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaTicketSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cola,toplam; 
            misir = Convert.ToInt32(txtMisir.Text);
            bilet = Convert.ToInt32(txtBilet.Text);
            su = Convert.ToInt32(txtSu.Text);   
            cola = Convert.ToInt32(txtCola.Text);

            toplam = misir * 40+cola*12+su*4+bilet*80;
            lblToplam.Text = toplam.ToString() + " TL";
            kasatutar = kasatutar+ toplam;
            lblKasa.Text = kasatutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtCola.Text = "";
            txtMisir.Text = "";
            txtSu.Text = "";

        }
    }
}
