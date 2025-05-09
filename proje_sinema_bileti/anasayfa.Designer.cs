namespace proje_sinema_bileti
{
    partial class frmAnasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.button4 = new System.Windows.Forms.Button();
            this.ımageList4 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBiletAl = new System.Windows.Forms.Button();
            this.comboFilmAdi = new System.Windows.Forms.ComboBox();
            this.comboSalonAdi = new System.Windows.Forms.ComboBox();
            this.comboFilmTarihi = new System.Windows.Forms.ComboBox();
            this.comboSeans = new System.Windows.Forms.ComboBox();
            this.comboUcret = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.ımageList5 = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.ımageList6 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboKoltukİptal = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.ImageIndex = 0;
            this.button4.ImageList = this.ımageList4;
            this.button4.Location = new System.Drawing.Point(457, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 94);
            this.button4.TabIndex = 3;
            this.button4.Text = "Seans Liste";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ımageList4
            // 
            this.ımageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList4.ImageStream")));
            this.ımageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList4.Images.SetKeyName(0, "listelee.png");
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.ImageIndex = 0;
            this.button3.ImageList = this.ımageList3;
            this.button3.Location = new System.Drawing.Point(306, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 96);
            this.button3.TabIndex = 2;
            this.button3.Text = "Seans Ekle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "seans.png");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.ımageList2;
            this.button2.Location = new System.Drawing.Point(161, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 96);
            this.button2.TabIndex = 1;
            this.button2.Text = "Film Ekle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "sallonn.png");
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.ImageIndex = 5;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(18, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salon Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "salonEkleİcon.jpeg");
            this.ımageList1.Images.SetKeyName(1, "senas.jpg");
            this.ımageList1.Images.SetKeyName(2, "salonEkle.jpg");
            this.ımageList1.Images.SetKeyName(3, "filmEkle.jpg");
            this.ımageList1.Images.SetKeyName(4, "sallonn.png");
            this.ımageList1.Images.SetKeyName(5, "saaaalll.jpg");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBiletAl);
            this.groupBox1.Controls.Add(this.comboFilmAdi);
            this.groupBox1.Controls.Add(this.comboSalonAdi);
            this.groupBox1.Controls.Add(this.comboFilmTarihi);
            this.groupBox1.Controls.Add(this.comboSeans);
            this.groupBox1.Controls.Add(this.comboUcret);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKoltukNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Russo One", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1150, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 415);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Satış İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.Font = new System.Drawing.Font("Baloo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletAl.Location = new System.Drawing.Point(98, 355);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(186, 52);
            this.btnBiletAl.TabIndex = 21;
            this.btnBiletAl.Text = "Bilet Sat";
            this.btnBiletAl.UseVisualStyleBackColor = true;
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // comboFilmAdi
            // 
            this.comboFilmAdi.FormattingEnabled = true;
            this.comboFilmAdi.Location = new System.Drawing.Point(98, 28);
            this.comboFilmAdi.Name = "comboFilmAdi";
            this.comboFilmAdi.Size = new System.Drawing.Size(186, 24);
            this.comboFilmAdi.TabIndex = 0;
            this.comboFilmAdi.SelectedIndexChanged += new System.EventHandler(this.comboFilmAdi_SelectedIndexChanged);
            // 
            // comboSalonAdi
            // 
            this.comboSalonAdi.FormattingEnabled = true;
            this.comboSalonAdi.Location = new System.Drawing.Point(98, 68);
            this.comboSalonAdi.Name = "comboSalonAdi";
            this.comboSalonAdi.Size = new System.Drawing.Size(186, 24);
            this.comboSalonAdi.TabIndex = 6;
            this.comboSalonAdi.SelectedIndexChanged += new System.EventHandler(this.comboSalonAdi_SelectedIndexChanged);
            // 
            // comboFilmTarihi
            // 
            this.comboFilmTarihi.FormattingEnabled = true;
            this.comboFilmTarihi.Location = new System.Drawing.Point(98, 112);
            this.comboFilmTarihi.Name = "comboFilmTarihi";
            this.comboFilmTarihi.Size = new System.Drawing.Size(186, 24);
            this.comboFilmTarihi.TabIndex = 7;
            this.comboFilmTarihi.SelectedIndexChanged += new System.EventHandler(this.comboFilmTarihi_SelectedIndexChanged);
            // 
            // comboSeans
            // 
            this.comboSeans.FormattingEnabled = true;
            this.comboSeans.Location = new System.Drawing.Point(98, 152);
            this.comboSeans.Name = "comboSeans";
            this.comboSeans.Size = new System.Drawing.Size(186, 24);
            this.comboSeans.TabIndex = 8;
            this.comboSeans.SelectedIndexChanged += new System.EventHandler(this.comboSeans_SelectedIndexChanged);
            // 
            // comboUcret
            // 
            this.comboUcret.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.comboUcret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUcret.Items.AddRange(new object[] {
            "120"});
            this.comboUcret.Location = new System.Drawing.Point(98, 312);
            this.comboUcret.Name = "comboUcret";
            this.comboUcret.Size = new System.Drawing.Size(186, 24);
            this.comboUcret.TabIndex = 20;
            this.comboUcret.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Film Adı";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(98, 276);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(186, 23);
            this.txtSoyad.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Salon Adı";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(98, 239);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(186, 23);
            this.txtAd.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Film Tarihi";
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Enabled = false;
            this.txtKoltukNo.Location = new System.Drawing.Point(98, 200);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(186, 23);
            this.txtKoltukNo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 12;
            this.label4.Tag = "";
            this.label4.Text = "Film Seansı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 16;
            this.label8.Tag = "";
            this.label8.Text = "Ücret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 13;
            this.label5.Tag = "";
            this.label5.Text = "Koltuk NO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 15;
            this.label7.Tag = "";
            this.label7.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 14;
            this.label6.Tag = "";
            this.label6.Text = "Ad";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(470, 884);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 52);
            this.button6.TabIndex = 21;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(543, 893);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 38);
            this.label9.TabIndex = 22;
            this.label9.Text = "Dolu Koltuklar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1013, 889);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 38);
            this.label10.TabIndex = 23;
            this.label10.Text = "Boş Koltuklar";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Location = new System.Drawing.Point(939, 880);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 52);
            this.button7.TabIndex = 24;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(819, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 38);
            this.label11.TabIndex = 25;
            this.label11.Text = "Film Afişi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(724, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(164, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 436);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BackgroundImage = global::proje_sinema_bileti.Properties.Resources.panel2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(164, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 122);
            this.panel2.TabIndex = 28;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.ImageIndex = 0;
            this.button10.ImageList = this.ımageList5;
            this.button10.Location = new System.Drawing.Point(603, 11);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(124, 94);
            this.button10.TabIndex = 5;
            this.button10.Text = "Satışlar";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // ımageList5
            // 
            this.ımageList5.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList5.ImageStream")));
            this.ımageList5.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList5.Images.SetKeyName(0, "satışlar.jpg");
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.ImageIndex = 0;
            this.button5.ImageList = this.ımageList6;
            this.button5.Location = new System.Drawing.Point(748, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 96);
            this.button5.TabIndex = 4;
            this.button5.Text = "ÇIKIŞ";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ımageList6
            // 
            this.ımageList6.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList6.ImageStream")));
            this.ımageList6.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList6.Images.SetKeyName(0, "çıkış2.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.comboKoltukİptal);
            this.groupBox2.Font = new System.Drawing.Font("Baloo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(1160, 577);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 145);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilet İptal";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(88, 92);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(179, 47);
            this.button9.TabIndex = 30;
            this.button9.Text = "Bilet İptal";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 21);
            this.label12.TabIndex = 14;
            this.label12.Tag = "";
            this.label12.Text = "Koltuk NO";
            // 
            // comboKoltukİptal
            // 
            this.comboKoltukİptal.FormattingEnabled = true;
            this.comboKoltukİptal.Location = new System.Drawing.Point(88, 50);
            this.comboKoltukİptal.Name = "comboKoltukİptal";
            this.comboKoltukİptal.Size = new System.Drawing.Size(179, 29);
            this.comboKoltukİptal.TabIndex = 0;
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proje_sinema_bileti.Properties.Resources.sinema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1572, 1055);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmAnasayfa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboFilmAdi;
        private System.Windows.Forms.ComboBox comboSalonAdi;
        private System.Windows.Forms.ComboBox comboFilmTarihi;
        private System.Windows.Forms.ComboBox comboSeans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKoltukNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ComboBox comboUcret;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnBiletAl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboKoltukİptal;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ImageList ımageList4;
        private System.Windows.Forms.ImageList ımageList5;
        private System.Windows.Forms.ImageList ımageList6;
    }
}

