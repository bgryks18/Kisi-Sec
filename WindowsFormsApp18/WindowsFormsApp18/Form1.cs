using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int sayi;
        string[] isimler = { "Buğra Yüksel", "Mustafa Can Telli", "Harun Reşit", "Adnan Cansız", "Anıl Adar", "Ecemnur Naz", "Rifka Razon", "Dilara Dönmez", "Deniz Genç", "Berkay Yıldız", "Ozan Kut", "Merve Sofuoğlu", "Adem", "Eren Ergin", "Abdullah" };
        void birinisec() {

                string eskitext = btnSec.Text;
                btnSec.Text = "Seçiliyor..";
                btnSec.Visible = false;
            sayi = rnd.Next(0, (isimler.Length));
                lstListe.SelectedIndex = sayi;

                btnSec.Visible = true;
                btnSec.Text = eskitext;
          
            
        }
        void listele()
        {
            foreach (string isim in isimler)
            {
                lstListe.Items.Add(isim);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
           birinisec();
        }

    }
}
