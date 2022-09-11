namespace Eeczanem
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTCKimlikNo = new System.Windows.Forms.Label();
            this.simpleButton14 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton15 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton16 = new DevExpress.XtraEditors.SimpleButton();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblSosyalGüvence = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.lblKullandıgıİlaclar = new System.Windows.Forms.Label();
            this.lblKullanımSekli = new System.Windows.Forms.Label();
            this.simpleButton17 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton18 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton19 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton20 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.cmbSosyalGüvence = new System.Windows.Forms.ComboBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.txtKullandıgıİlaclar = new System.Windows.Forms.TextBox();
            this.cmbKullanımSekli = new System.Windows.Forms.ComboBox();
            this.btnHastaBilgiListle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniKayıt = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGeri = new DevExpress.XtraEditors.SimpleButton();
            this.lblid = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(-1, 430);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(946, 269);
            this.listView2.TabIndex = 24;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İd";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TC Kimlik No";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ad Soyad";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sosyal Güvence";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adres";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Telefon No";
            this.columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kullandığı İlaçlar";
            this.columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kullanım Şekli";
            this.columnHeader8.Width = 127;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(51, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(173, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(772, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblTCKimlikNo
            // 
            this.lblTCKimlikNo.AutoSize = true;
            this.lblTCKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCKimlikNo.Location = new System.Drawing.Point(258, 65);
            this.lblTCKimlikNo.Name = "lblTCKimlikNo";
            this.lblTCKimlikNo.Size = new System.Drawing.Size(152, 26);
            this.lblTCKimlikNo.TabIndex = 27;
            this.lblTCKimlikNo.Text = "TC Kimlik No :";
            // 
            // simpleButton14
            // 
            this.simpleButton14.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton14.ImageOptions.Image")));
            this.simpleButton14.Location = new System.Drawing.Point(416, 65);
            this.simpleButton14.Name = "simpleButton14";
            this.simpleButton14.Size = new System.Drawing.Size(38, 32);
            this.simpleButton14.TabIndex = 34;
            this.simpleButton14.Text = "simpleButton14";
            // 
            // simpleButton15
            // 
            this.simpleButton15.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton15.ImageOptions.Image")));
            this.simpleButton15.Location = new System.Drawing.Point(416, 106);
            this.simpleButton15.Name = "simpleButton15";
            this.simpleButton15.Size = new System.Drawing.Size(38, 32);
            this.simpleButton15.TabIndex = 35;
            this.simpleButton15.Text = "simpleButton15";
            // 
            // simpleButton16
            // 
            this.simpleButton16.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton16.ImageOptions.Image")));
            this.simpleButton16.Location = new System.Drawing.Point(416, 144);
            this.simpleButton16.Name = "simpleButton16";
            this.simpleButton16.Size = new System.Drawing.Size(38, 32);
            this.simpleButton16.TabIndex = 36;
            this.simpleButton16.Text = "simpleButton16";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(291, 106);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(119, 26);
            this.lblAdSoyad.TabIndex = 37;
            this.lblAdSoyad.Text = "Ad Soyad :";
            // 
            // lblSosyalGüvence
            // 
            this.lblSosyalGüvence.AutoSize = true;
            this.lblSosyalGüvence.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSosyalGüvence.Location = new System.Drawing.Point(227, 150);
            this.lblSosyalGüvence.Name = "lblSosyalGüvence";
            this.lblSosyalGüvence.Size = new System.Drawing.Size(183, 26);
            this.lblSosyalGüvence.TabIndex = 38;
            this.lblSosyalGüvence.Text = "Sosyal Güvence :";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(329, 187);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(81, 26);
            this.lblAdres.TabIndex = 39;
            this.lblAdres.Text = "Adres :";
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefonNo.Location = new System.Drawing.Point(281, 222);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(129, 26);
            this.lblTelefonNo.TabIndex = 40;
            this.lblTelefonNo.Text = "Telefon No :";
            // 
            // lblKullandıgıİlaclar
            // 
            this.lblKullandıgıİlaclar.AutoSize = true;
            this.lblKullandıgıİlaclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullandıgıİlaclar.Location = new System.Drawing.Point(227, 264);
            this.lblKullandıgıİlaclar.Name = "lblKullandıgıİlaclar";
            this.lblKullandıgıİlaclar.Size = new System.Drawing.Size(183, 26);
            this.lblKullandıgıİlaclar.TabIndex = 41;
            this.lblKullandıgıİlaclar.Text = "Kullandığı İlaçlar :";
            // 
            // lblKullanımSekli
            // 
            this.lblKullanımSekli.AutoSize = true;
            this.lblKullanımSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanımSekli.Location = new System.Drawing.Point(247, 305);
            this.lblKullanımSekli.Name = "lblKullanımSekli";
            this.lblKullanımSekli.Size = new System.Drawing.Size(163, 26);
            this.lblKullanımSekli.TabIndex = 42;
            this.lblKullanımSekli.Text = "Kullanım Şekli :";
            // 
            // simpleButton17
            // 
            this.simpleButton17.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton17.ImageOptions.Image")));
            this.simpleButton17.Location = new System.Drawing.Point(416, 187);
            this.simpleButton17.Name = "simpleButton17";
            this.simpleButton17.Size = new System.Drawing.Size(38, 32);
            this.simpleButton17.TabIndex = 43;
            this.simpleButton17.Text = "simpleButton17";
            // 
            // simpleButton18
            // 
            this.simpleButton18.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton18.ImageOptions.Image")));
            this.simpleButton18.Location = new System.Drawing.Point(416, 225);
            this.simpleButton18.Name = "simpleButton18";
            this.simpleButton18.Size = new System.Drawing.Size(38, 32);
            this.simpleButton18.TabIndex = 44;
            this.simpleButton18.Text = "simpleButton18";
            // 
            // simpleButton19
            // 
            this.simpleButton19.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton19.ImageOptions.Image")));
            this.simpleButton19.Location = new System.Drawing.Point(416, 264);
            this.simpleButton19.Name = "simpleButton19";
            this.simpleButton19.Size = new System.Drawing.Size(38, 32);
            this.simpleButton19.TabIndex = 45;
            this.simpleButton19.Text = "simpleButton19";
            // 
            // simpleButton20
            // 
            this.simpleButton20.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton20.ImageOptions.Image")));
            this.simpleButton20.Location = new System.Drawing.Point(416, 305);
            this.simpleButton20.Name = "simpleButton20";
            this.simpleButton20.Size = new System.Drawing.Size(38, 32);
            this.simpleButton20.TabIndex = 46;
            this.simpleButton20.Text = "simpleButton20";
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTCKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCKimlikNo.Location = new System.Drawing.Point(460, 67);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(173, 30);
            this.txtTCKimlikNo.TabIndex = 47;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(460, 108);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(173, 30);
            this.txtAdSoyad.TabIndex = 48;
            // 
            // cmbSosyalGüvence
            // 
            this.cmbSosyalGüvence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbSosyalGüvence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSosyalGüvence.FormattingEnabled = true;
            this.cmbSosyalGüvence.Items.AddRange(new object[] {
            "emekli sandığı",
            "sgk"});
            this.cmbSosyalGüvence.Location = new System.Drawing.Point(460, 142);
            this.cmbSosyalGüvence.Name = "cmbSosyalGüvence";
            this.cmbSosyalGüvence.Size = new System.Drawing.Size(173, 32);
            this.cmbSosyalGüvence.TabIndex = 49;
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(460, 189);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(173, 30);
            this.txtAdres.TabIndex = 50;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTelefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefonNo.Location = new System.Drawing.Point(460, 227);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(173, 30);
            this.txtTelefonNo.TabIndex = 51;
            // 
            // txtKullandıgıİlaclar
            // 
            this.txtKullandıgıİlaclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtKullandıgıİlaclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullandıgıİlaclar.Location = new System.Drawing.Point(460, 266);
            this.txtKullandıgıİlaclar.Name = "txtKullandıgıİlaclar";
            this.txtKullandıgıİlaclar.Size = new System.Drawing.Size(173, 30);
            this.txtKullandıgıİlaclar.TabIndex = 52;
            // 
            // cmbKullanımSekli
            // 
            this.cmbKullanımSekli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbKullanımSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKullanımSekli.FormattingEnabled = true;
            this.cmbKullanımSekli.Items.AddRange(new object[] {
            "Sabah ",
            "Akşam",
            "Sabah+Akşam",
            "Sabah+Öğlen+Akşam"});
            this.cmbKullanımSekli.Location = new System.Drawing.Point(460, 305);
            this.cmbKullanımSekli.Name = "cmbKullanımSekli";
            this.cmbKullanımSekli.Size = new System.Drawing.Size(173, 32);
            this.cmbKullanımSekli.TabIndex = 53;
            // 
            // btnHastaBilgiListle
            // 
            this.btnHastaBilgiListle.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnHastaBilgiListle.Appearance.Options.UseFont = true;
            this.btnHastaBilgiListle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnHastaBilgiListle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHastaBilgiListle.ImageOptions.Image")));
            this.btnHastaBilgiListle.Location = new System.Drawing.Point(178, 359);
            this.btnHastaBilgiListle.Name = "btnHastaBilgiListle";
            this.btnHastaBilgiListle.Size = new System.Drawing.Size(262, 52);
            this.btnHastaBilgiListle.TabIndex = 54;
            this.btnHastaBilgiListle.Text = "Hasta Bilgilerini Listele ";
            this.btnHastaBilgiListle.Click += new System.EventHandler(this.btnHastaBilgiListle_Click);
            // 
            // btnYeniKayıt
            // 
            this.btnYeniKayıt.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnYeniKayıt.Appearance.Options.UseFont = true;
            this.btnYeniKayıt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnYeniKayıt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniKayıt.ImageOptions.Image")));
            this.btnYeniKayıt.Location = new System.Drawing.Point(460, 359);
            this.btnYeniKayıt.Name = "btnYeniKayıt";
            this.btnYeniKayıt.Size = new System.Drawing.Size(163, 52);
            this.btnYeniKayıt.TabIndex = 55;
            this.btnYeniKayıt.Text = "Yeni Kayıt";
            this.btnYeniKayıt.Click += new System.EventHandler(this.btnYeniKayıt_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 17F);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(645, 359);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(140, 52);
            this.btnSil.TabIndex = 56;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGeri.ImageOptions.Image")));
            this.btnGeri.Location = new System.Drawing.Point(7, 3);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(38, 32);
            this.btnGeri.TabIndex = 57;
            this.btnGeri.Text = "simpleButton1";
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(369, 28);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(42, 26);
            this.lblid.TabIndex = 58;
            this.lblid.Text = "İd :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(417, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(38, 32);
            this.simpleButton1.TabIndex = 59;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(461, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(173, 30);
            this.txtid.TabIndex = 60;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(970, 725);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeniKayıt);
            this.Controls.Add(this.btnHastaBilgiListle);
            this.Controls.Add(this.cmbKullanımSekli);
            this.Controls.Add(this.txtKullandıgıİlaclar);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.cmbSosyalGüvence);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTCKimlikNo);
            this.Controls.Add(this.simpleButton20);
            this.Controls.Add(this.simpleButton19);
            this.Controls.Add(this.simpleButton18);
            this.Controls.Add(this.simpleButton17);
            this.Controls.Add(this.lblKullanımSekli);
            this.Controls.Add(this.lblKullandıgıİlaclar);
            this.Controls.Add(this.lblTelefonNo);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblSosyalGüvence);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.simpleButton16);
            this.Controls.Add(this.simpleButton15);
            this.Controls.Add(this.simpleButton14);
            this.Controls.Add(this.lblTCKimlikNo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.listView2);
            this.Name = "Form7";
            this.Text = "Hasta Bilgileri";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTCKimlikNo;
        private DevExpress.XtraEditors.SimpleButton simpleButton14;
        private DevExpress.XtraEditors.SimpleButton simpleButton15;
        private DevExpress.XtraEditors.SimpleButton simpleButton16;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblSosyalGüvence;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.Label lblKullandıgıİlaclar;
        private System.Windows.Forms.Label lblKullanımSekli;
        private DevExpress.XtraEditors.SimpleButton simpleButton17;
        private DevExpress.XtraEditors.SimpleButton simpleButton18;
        private DevExpress.XtraEditors.SimpleButton simpleButton19;
        private DevExpress.XtraEditors.SimpleButton simpleButton20;
        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ComboBox cmbSosyalGüvence;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtKullandıgıİlaclar;
        private System.Windows.Forms.ComboBox cmbKullanımSekli;
        private DevExpress.XtraEditors.SimpleButton btnHastaBilgiListle;
        private DevExpress.XtraEditors.SimpleButton btnYeniKayıt;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGeri;
        private System.Windows.Forms.Label lblid;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}