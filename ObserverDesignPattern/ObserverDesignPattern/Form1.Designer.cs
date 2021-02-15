namespace ObserverDesignPattern
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.cmbdoktorlar = new System.Windows.Forms.ComboBox();
            this.btnDOKTOREKLE = new DevExpress.XtraEditors.SimpleButton();
            this.btnDOKTORSİL = new DevExpress.XtraEditors.SimpleButton();
            this.btnanonsekle = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtyas = new DevExpress.XtraEditors.TextEdit();
            this.txtdurum = new System.Windows.Forms.RichTextBox();
            this.txtsüre = new DevExpress.XtraEditors.TextEdit();
            this.observerlist = new System.Windows.Forms.ListBox();
            this.btncagrıyolla = new DevExpress.XtraEditors.SimpleButton();
            this.anonsgrid = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.cmbhemsireler = new System.Windows.Forms.ComboBox();
            this.btnHEMŞİREEKLE = new DevExpress.XtraEditors.SimpleButton();
            this.btnHEMŞİRESİL = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox6 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtyas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsüre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anonsgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1022, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acil Hasta Anonsları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Uzman Doktor Salih GÜVEN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Uzman Doktor Halil DEDE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Uzman Doktor Dilek ŞAHİN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(659, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hemşire Alya KULELİ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(659, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hemşire Soner DURGUN:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Teal;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(458, 63);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(147, 29);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "DOKTORLAR";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(661, 140);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(361, 30);
            this.listBox2.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(662, 191);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(360, 30);
            this.listBox3.TabIndex = 12;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(662, 240);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(360, 30);
            this.listBox4.TabIndex = 13;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(662, 295);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(360, 30);
            this.listBox5.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(827, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "EXİT";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(851, 384);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(112, 23);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // cmbdoktorlar
            // 
            this.cmbdoktorlar.FormattingEnabled = true;
            this.cmbdoktorlar.Items.AddRange(new object[] {
            "Uzman Doktor Salih GÜVEN",
            "Uzman Doktor Halil DEDE",
            "Uzman Doktor Dilek ŞAHİN",
            "Uzman Doktor Nilüfer SOYLU",
            "Uzman Doktor Efe ŞİMŞEK"});
            this.cmbdoktorlar.Location = new System.Drawing.Point(476, 100);
            this.cmbdoktorlar.Name = "cmbdoktorlar";
            this.cmbdoktorlar.Size = new System.Drawing.Size(121, 21);
            this.cmbdoktorlar.TabIndex = 17;
            // 
            // btnDOKTOREKLE
            // 
            this.btnDOKTOREKLE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDOKTOREKLE.ImageOptions.Image")));
            this.btnDOKTOREKLE.Location = new System.Drawing.Point(454, 127);
            this.btnDOKTOREKLE.Name = "btnDOKTOREKLE";
            this.btnDOKTOREKLE.Size = new System.Drawing.Size(79, 25);
            this.btnDOKTOREKLE.TabIndex = 18;
            this.btnDOKTOREKLE.Text = "EKLE";
            this.btnDOKTOREKLE.Click += new System.EventHandler(this.btnDOKTOREKLE_Click_1);
            // 
            // btnDOKTORSİL
            // 
            this.btnDOKTORSİL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDOKTORSİL.ImageOptions.Image")));
            this.btnDOKTORSİL.Location = new System.Drawing.Point(539, 127);
            this.btnDOKTORSİL.Name = "btnDOKTORSİL";
            this.btnDOKTORSİL.Size = new System.Drawing.Size(75, 25);
            this.btnDOKTORSİL.TabIndex = 19;
            this.btnDOKTORSİL.Text = "SİL";
            this.btnDOKTORSİL.Click += new System.EventHandler(this.btnDOKTORSİL_Click);
            // 
            // btnanonsekle
            // 
            this.btnanonsekle.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnanonsekle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanonsekle.Appearance.Options.UseBackColor = true;
            this.btnanonsekle.Appearance.Options.UseFont = true;
            this.btnanonsekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnanonsekle.ImageOptions.Image")));
            this.btnanonsekle.Location = new System.Drawing.Point(306, 295);
            this.btnanonsekle.Name = "btnanonsekle";
            this.btnanonsekle.Size = new System.Drawing.Size(146, 37);
            this.btnanonsekle.TabIndex = 20;
            this.btnanonsekle.Text = "Yeni Anons Ekle";
            this.btnanonsekle.Click += new System.EventHandler(this.btnanonsekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(306, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Acil Hasta Anonsu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Hastaneye Ulaşma Süresi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Hastanın Durumu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Hasta Yaşı:";
            // 
            // txtyas
            // 
            this.txtyas.EditValue = "";
            this.txtyas.Location = new System.Drawing.Point(306, 130);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(100, 20);
            this.txtyas.TabIndex = 25;
            // 
            // txtdurum
            // 
            this.txtdurum.Location = new System.Drawing.Point(306, 172);
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(88, 75);
            this.txtdurum.TabIndex = 26;
            this.txtdurum.Text = "";
            // 
            // txtsüre
            // 
            this.txtsüre.EditValue = "";
            this.txtsüre.Location = new System.Drawing.Point(306, 269);
            this.txtsüre.Name = "txtsüre";
            this.txtsüre.Size = new System.Drawing.Size(100, 20);
            this.txtsüre.TabIndex = 27;
            // 
            // observerlist
            // 
            this.observerlist.FormattingEnabled = true;
            this.observerlist.Location = new System.Drawing.Point(485, 256);
            this.observerlist.Name = "observerlist";
            this.observerlist.Size = new System.Drawing.Size(120, 95);
            this.observerlist.TabIndex = 28;
            // 
            // btncagrıyolla
            // 
            this.btncagrıyolla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btncagrıyolla.ImageOptions.Image")));
            this.btncagrıyolla.Location = new System.Drawing.Point(476, 357);
            this.btncagrıyolla.Name = "btncagrıyolla";
            this.btncagrıyolla.Size = new System.Drawing.Size(145, 50);
            this.btncagrıyolla.TabIndex = 29;
            this.btncagrıyolla.Text = "AnonsuUlaştır";
            this.btncagrıyolla.Click += new System.EventHandler(this.btncagrıyolla_Click);
            // 
            // anonsgrid
            // 
            this.anonsgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.anonsgrid.Location = new System.Drawing.Point(0, 87);
            this.anonsgrid.Name = "anonsgrid";
            this.anonsgrid.Size = new System.Drawing.Size(300, 264);
            this.anonsgrid.TabIndex = 30;
            this.anonsgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.anonsgrid_CellClick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(661, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 30);
            this.listBox1.TabIndex = 31;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Teal;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(458, 158);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(147, 29);
            this.simpleButton2.TabIndex = 32;
            this.simpleButton2.Text = "HEMŞİRELER";
            // 
            // cmbhemsireler
            // 
            this.cmbhemsireler.FormattingEnabled = true;
            this.cmbhemsireler.Items.AddRange(new object[] {
            "Hemşire Alya KULELİ",
            "Hemşire Soner DURGUN",
            "Hemşire Gül KORKMAZ"});
            this.cmbhemsireler.Location = new System.Drawing.Point(476, 193);
            this.cmbhemsireler.Name = "cmbhemsireler";
            this.cmbhemsireler.Size = new System.Drawing.Size(121, 21);
            this.cmbhemsireler.TabIndex = 33;
            // 
            // btnHEMŞİREEKLE
            // 
            this.btnHEMŞİREEKLE.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHEMŞİREEKLE.ImageOptions.Image")));
            this.btnHEMŞİREEKLE.Location = new System.Drawing.Point(454, 218);
            this.btnHEMŞİREEKLE.Name = "btnHEMŞİREEKLE";
            this.btnHEMŞİREEKLE.Size = new System.Drawing.Size(79, 25);
            this.btnHEMŞİREEKLE.TabIndex = 34;
            this.btnHEMŞİREEKLE.Text = "EKLE";
            this.btnHEMŞİREEKLE.Click += new System.EventHandler(this.btnHEMŞİREEKLE_Click);
            // 
            // btnHEMŞİRESİL
            // 
            this.btnHEMŞİRESİL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHEMŞİRESİL.ImageOptions.Image")));
            this.btnHEMŞİRESİL.Location = new System.Drawing.Point(549, 218);
            this.btnHEMŞİRESİL.Name = "btnHEMŞİRESİL";
            this.btnHEMŞİRESİL.Size = new System.Drawing.Size(75, 25);
            this.btnHEMŞİRESİL.TabIndex = 35;
            this.btnHEMŞİRESİL.Text = "SİL";
            this.btnHEMŞİRESİL.Click += new System.EventHandler(this.btnHEMŞİRESİL_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(659, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Hemşire Gül KORKMAZ:";
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(661, 344);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(361, 30);
            this.listBox6.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 477);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnHEMŞİRESİL);
            this.Controls.Add(this.btnHEMŞİREEKLE);
            this.Controls.Add(this.cmbhemsireler);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.anonsgrid);
            this.Controls.Add(this.btncagrıyolla);
            this.Controls.Add(this.observerlist);
            this.Controls.Add(this.txtsüre);
            this.Controls.Add(this.txtdurum);
            this.Controls.Add(this.txtyas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnanonsekle);
            this.Controls.Add(this.btnDOKTORSİL);
            this.Controls.Add(this.btnDOKTOREKLE);
            this.Controls.Add(this.cmbdoktorlar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtyas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsüre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anonsgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private System.Windows.Forms.ComboBox cmbdoktorlar;
        private DevExpress.XtraEditors.SimpleButton btnDOKTOREKLE;
        private DevExpress.XtraEditors.SimpleButton btnDOKTORSİL;
        private DevExpress.XtraEditors.SimpleButton btnanonsekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtyas;
        private System.Windows.Forms.RichTextBox txtdurum;
        private DevExpress.XtraEditors.TextEdit txtsüre;
        private System.Windows.Forms.ListBox observerlist;
        private DevExpress.XtraEditors.SimpleButton btncagrıyolla;
        private System.Windows.Forms.DataGridView anonsgrid;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.ComboBox cmbhemsireler;
        private DevExpress.XtraEditors.SimpleButton btnHEMŞİREEKLE;
        private DevExpress.XtraEditors.SimpleButton btnHEMŞİRESİL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox6;
    }
}

