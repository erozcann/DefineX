using System;
using System.Windows.Forms;
using ZorunluAlanLibrary; // Class Library ekledik

namespace WindowsFormsZorunluKontrol
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

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = txtAdi.Text,
                Soyadi = txtSoyadi.Text,
                Bolum = txtBolum.Text
            };

            if (!ZorunluAlanAttribute.Dogrula(ogrenci))
            {
                MessageBox.Show("Öğrenci bilgileri eksik!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Form başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public class Ogrenci
    {
        [ZorunluAlan]
        public string Adi { get; set; }
        [ZorunluAlan]
        public string Soyadi { get; set; }
        [ZorunluAlan]
        public string Bolum { get; set; }
    }
}
