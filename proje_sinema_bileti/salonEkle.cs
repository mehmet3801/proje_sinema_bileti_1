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
    public partial class frmSalonEkle: Form
    {
        public frmSalonEkle()
        {
            InitializeComponent();
        }

        private void frmSalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.ShowDialog();

        }


        sinemaTableAdapters.Salon_bilgileriTableAdapter salon = new sinemaTableAdapters.Salon_bilgileriTableAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                salon.salonEkleme(txtSalonAdi.Text);
                MessageBox.Show("Salon Eklendi", "ekle");
            }
            catch (Exception)
            {

                MessageBox.Show("Aynı salonu daha önce eklediniz!!","Hata");
            }
            txtSalonAdi.Clear();
        }
    }
}
