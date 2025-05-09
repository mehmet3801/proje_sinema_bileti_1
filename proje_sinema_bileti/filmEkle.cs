using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_sinema_bileti
{
    public partial class frmFilmEkle: Form
    {


        public frmFilmEkle()
        {
            InitializeComponent();
        }


        //sinemaTableAdapters.Fim_BilgileriTableAdapter film = new sinemaTableAdapters.Fim_BilgileriTableAdapter();
        sinemaTableAdapters.Fim_BilgileriTableAdapter film = new sinemaTableAdapters.Fim_BilgileriTableAdapter();
        private void frmFilmEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.ShowDialog();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            //film.FilmEkleme(txtFilmAdi.Text,txtYonetmen.Text,comboFilmTuru.Text,txtSure.Text,dateTimePicker1.Text, txtYapimYili.Text,pictureBox1.ImageLocation);
            film.filmEkleme(txtFilmAdi.Text, txtYonetmen.Text, comboFilmTuru.Text, txtSure.Text, dateTimePicker1.Text, txtYapimYili.Text, pictureBox1.ImageLocation);
            try
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                MessageBox.Show("Film Eklendi", "ekle");
            }
            catch (Exception)
            {
                MessageBox.Show("Aynı filmi daha önce eklediniz!!", "Hata");
            }
            comboFilmTuru.Text = "";
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void frmFilmEkle_Load(object sender, EventArgs e)
        {
            btnFilmEkle.Text = "\nFilm\nEkle";
            btnFilmEkle.TextAlign = ContentAlignment.MiddleRight;


            btnResimSec.Text = "\nAfiş\nEkle";
            btnResimSec.TextAlign = ContentAlignment.MiddleRight;


        }
    }
}
