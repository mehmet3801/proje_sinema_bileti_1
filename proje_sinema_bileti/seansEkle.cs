using proje_sinema_bileti.sinemaTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_sinema_bileti
{
    public partial class frmSeansEkle: Form
    {

        public frmSeansEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MEHMETT;Initial Catalog=sinemeBileti;Integrated Security=True; TrustServerCertificate=True");
        sinemaTableAdapters.Seans_BilgileriTableAdapter filmSeans = new sinemaTableAdapters.Seans_BilgileriTableAdapter();

        private void frmSeansEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.ShowDialog();
        }


        private void filmVeSalonGoster(ComboBox combo, string sql, string sql2)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read() == true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }

        string seans;
        private void radioButtonSecili()
        {
            if(radioButton1.Checked == true) seans = radioButton1.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;
            else if (radioButton13.Checked == true) seans = radioButton13.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (seans != "")
            {
                radioButtonSecili(); // hata werirse bunu yukarı al
                filmSeans.SeansEkleme(comboFilm.Text,comboSalon.Text,dateTarih.Text,seans);
                MessageBox.Show("Seans Eklendi", "Kayıt");
            }
            else if (seans == "")
            {
                MessageBox.Show("Lütfen Seans Seçiniz", "Uyarı");
            }
            comboSalon.Text = "";
            comboFilm.Text = "";
        }

        private void frmSeansEkle_Load(object sender, EventArgs e)
        {
            filmVeSalonGoster(comboFilm, "select * from Fim_Bilgileri", "filmadi");
            filmVeSalonGoster(comboSalon, "select * from salon_Bilgileri", "salonadi");
        }

        private void dateTarih_ValueChanged(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTarih.Text);

            if (yeni == bugun)
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (DateTime.Parse(DateTime.Now.ToShortDateString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
            }
        }
    }
}

