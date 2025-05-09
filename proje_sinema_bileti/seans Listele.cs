using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace proje_sinema_bileti
{
    public partial class frmSeansListele : Form
    {
        public frmSeansListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MEHMETT;Initial Catalog=sinemeBileti;Integrated Security=True; TrustServerCertificate=True");
        DataTable tablo = new DataTable();

        private void seanslistesi(string sql)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void frmSeansListele_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnasayfa anasayfa = new frmAnasayfa();
            anasayfa.ShowDialog();
        }

        private void frmSeansListele_Load(object sender, EventArgs e)
        {
            tablo.Clear();
            seanslistesi("select * from seans_bilgileri where tarih like'" + dateTimeSeansListeleme.Text + "'");
        }

        private void dateTimeSeansListeleme_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            seanslistesi("select * from seans_bilgileri where tarih like'" + dateTimeSeansListeleme.Text + "'");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            seanslistesi("select * from seans_bilgileri");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // PDF dosyasını kaydetmek için SaveFileDialog aç
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Dosyaları|*.pdf";
                sfd.Title = "PDF Dosyasını Kaydet";
                sfd.FileName = "SeansRaporu.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // PDF belgesi oluştur
                        Document doc = new Document(PageSize.A4);
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        // Başlık ekle
                        iTextSharp.text.Font baslikFont = FontFactory.GetFont(FontFactory.HELVETICA, 18, iTextSharp.text.Font.BOLD);
                        Paragraph baslik = new Paragraph("Seans Raporu", baslikFont);
                        baslik.Alignment = Element.ALIGN_CENTER;
                        doc.Add(baslik);

                        // Boşluk ekle
                        doc.Add(new Paragraph("\n"));

                        // Tarih bilgisi ekle
                        iTextSharp.text.Font tarihFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                        Paragraph tarih = new Paragraph("Tarih: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), tarihFont);
                        tarih.Alignment = Element.ALIGN_RIGHT;
                        doc.Add(tarih);

                        // Boşluk ekle
                        doc.Add(new Paragraph("\n"));

                        // Tablo oluştur (dataGridView1 sütun sayısı kadar sütunlu)
                        PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                        table.WidthPercentage = 100; // Tablo genişliği sayfanın %100'ü olsun

                        // Sütun başlıklarını ekle
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            table.AddCell(cell);
                        }

                        // Satır verilerini ekle
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(cell.Value?.ToString() ?? ""); // Null kontrolü
                            }
                        }

                        // Tabloyu PDF'e ekle
                        doc.Add(table);

                        // Belgeyi kapat
                        doc.Close();
                        writer.Close();

                        MessageBox.Show("PDF başarıyla oluşturuldu ve kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("PDF oluşturulurken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}