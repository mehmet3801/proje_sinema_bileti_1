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
    public partial class frmAnasayfa: Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MEHMETT;Initial Catalog=sinemeBileti;Integrated Security=True; TrustServerCertificate=True");
        int sayac = 0;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void filmveSalon_getir(ComboBox combo, string sql1,string sql2)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand(sql1, baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }
        private void filmAfisiGoster()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from fim_bilgileri where filmadi = '"+comboFilmAdi.SelectedItem+"'",baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            
            while (read.Read())
            {
                pictureBox1.ImageLocation = read["resim"].ToString();
            }
            baglanti.Close();
        }

        private void yenidenRenklendirme()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void veritabanDoluKoltuklar()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from satis_bilgileri where filmadi = '"+comboFilmAdi.SelectedItem+"' and salonadi = '" + comboSalonAdi.SelectedItem + "' and tarih= '" + comboFilmTarihi.SelectedItem + "' and saat = '" + comboSeans.SelectedItem + "'", baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (read["koltukno"].ToString() == item.Text)
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                }
            }
            baglanti.Close();
        }
        private void combo_dolu_koltuklar()
        {
            comboKoltukİptal.Items.Clear();
            comboKoltukİptal.Text = "";
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor == Color.Red)
                    {
                        comboKoltukİptal.Items.Add(item.Text);
                    }
                }
            }
        }
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            bos_koltuklar();
            filmveSalon_getir(comboFilmAdi,"select * from fim_bilgileri", "filmAdi");
            filmveSalon_getir(comboSalonAdi,"select * from salon_bilgileri", "salonAdi");
        }

        private void bos_koltuklar()
        {
            sayac = 1;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.White;
                    btn.Size = new Size(40, 40);
                    btn.Location = new Point(j * 35 + 30, i * 35 + 35);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    this.panel1.Controls.Add(btn);
                    sayac++;

                    btn.Click += Btn_click;
                }
            }
        }

        private void Btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.BackColor == Color.White)
            {
                txtKoltukNo.Text = btn.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSalonEkle ekle = new frmSalonEkle();
            ekle.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFilmEkle ekle = new frmFilmEkle();
            ekle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSeansEkle ekle = new frmSeansEkle();
            ekle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSeansListele ekle = new frmSeansListele();
            ekle.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); // anasyfa formunu kapatir
        }

        private void button10_Click(object sender, EventArgs e)
        {
            satislar satis = new satislar();
            satis.ShowDialog();
        }

        private void comboFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSalonAdi.Text = "";
            comboSeans.Text = "";
            comboFilmTarihi.Text = "";
            comboFilmTarihi.Items.Clear();
            comboSeans.Items.Clear();

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            } 

            filmAfisiGoster();
            yenidenRenklendirme();
            combo_dolu_koltuklar();
        }


        sinemaTableAdapters.Satis_BilgileriTableAdapter satis = new sinemaTableAdapters.Satis_BilgileriTableAdapter();

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKoltukNo.Text)) // Koltuk numarası boşsa hatta göster
            {
                MessageBox.Show("Koltuk seçimi yapmadınız!", "Uyarı");
                return; // İşlemi burada durdur
            }

            try
            {
                satis.satis_yap(txtKoltukNo.Text, comboSalonAdi.Text, comboFilmAdi.Text,
                                comboFilmTarihi.Text, comboSeans.Text, txtAd.Text, txtSoyad.Text,
                                comboUcret.Text, DateTime.Now.ToString());
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                yenidenRenklendirme();
                veritabanDoluKoltuklar();
                combo_dolu_koltuklar();

                MessageBox.Show("Bilet başarıyla satın alındı!", "Bilgi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu: " + hata.Message, "Uyarı");
            }
        }

        private void filmTarihiGetir()
        {
            comboFilmTarihi.Text = "";
            comboSeans.Text = "";
            comboFilmTarihi.Items.Clear();
            comboSeans.Items.Clear();
            

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from seans_bilgileri where filmadi = '" + comboFilmAdi.SelectedItem + "' and salonadi = '" + comboSalonAdi.SelectedItem + "'" , baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString()) >= DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!comboFilmTarihi.Items.Contains(read["tarih"].ToString()))
                    {
                        comboFilmTarihi.Items.Add(read["tarih"].ToString());
                    }
                }
            }
            baglanti.Close();
        }

        private void comboSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmTarihiGetir();
        }

        private void filmSeansigetir()
        {
            comboSeans.Items.Clear();
            comboSeans.Text = "";
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from seans_bilgileri where salonadi = '" + comboSalonAdi.SelectedItem + "' and filmadi = '" + comboFilmAdi.SelectedItem + "' and tarih = '"+comboFilmTarihi.SelectedItem+"'", baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["seans"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (DateTime.Parse(read["seans"].ToString())> DateTime.Parse(DateTime.Now.ToShortDateString())){
                        comboSeans.Items.Add(read["seans"].ToString());
                    }
                }

                else if (DateTime.Parse(read["tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    comboSeans.Items.Add(read["seans"].ToString());
                }
            }
            baglanti.Close();
        }

        private void comboFilmTarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmSeansigetir();
        }

        private void comboSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            yenidenRenklendirme();
            veritabanDoluKoltuklar();
            combo_dolu_koltuklar();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(comboKoltukİptal.Text != "")
            {
                try
                {
                    satis.satis_iptal(comboFilmAdi.Text, comboSalonAdi.Text, comboFilmTarihi.Text, comboSeans.Text, comboKoltukİptal.Text);
                    yenidenRenklendirme();
                    veritabanDoluKoltuklar();
                    combo_dolu_koltuklar();
                    MessageBox.Show("Bilet iptal edildi!", "Bilgi");
                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata oluştu: " + hata.Message, "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız!", "Uyarı");
            }
        }
    }
}
