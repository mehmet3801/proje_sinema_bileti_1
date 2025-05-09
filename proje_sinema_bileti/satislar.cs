using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace proje_sinema_bileti
{
    public partial class satislar: Form
    {
        public satislar()
        {
            InitializeComponent();
        }
        sinemaTableAdapters.Satis_BilgileriTableAdapter satisListesi = new sinemaTableAdapters.Satis_BilgileriTableAdapter();

        private void satislar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satisListesi.TariheGoreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();
        }

        private void ToplamUcretHesapla()
        {
            int toplam = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ucret"].Value != null) // Null kontrolü yap
                {
                    string deger = row.Cells["ucret"].Value.ToString().Trim(); // Trim ile boşlukları kaldır

                    if (int.TryParse(deger, out int ucret)) // Sayıya çevirme kontrolü
                    {
                        toplam += ucret;
                    }
                }
            }

            label1.Text = "Toplam Kazanç: " + toplam.ToString() + " TL";

            label1.Text = "Toplam Kazanç: " + toplam.ToString() + " TL";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satisListesi.TariheGoreListele2(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            ToplamUcretHesapla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satisListesi.satisListesi2();
            ToplamUcretHesapla();
        }
    }
}
