namespace SimbaCafe
{
    partial class frmAnamenu
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
            this.btnMasalar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnKilit = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnKasaIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMasalar
            // 
            this.btnMasalar.BackgroundImage = global::SimbaCafe.Properties.Resources.masalogo1;
            this.btnMasalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMasalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasalar.FlatAppearance.BorderSize = 0;
            this.btnMasalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMasalar.Location = new System.Drawing.Point(386, 188);
            this.btnMasalar.Name = "btnMasalar";
            this.btnMasalar.Size = new System.Drawing.Size(578, 257);
            this.btnMasalar.TabIndex = 0;
            this.btnMasalar.UseVisualStyleBackColor = true;
            this.btnMasalar.Click += new System.EventHandler(this.btnMasalar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackgroundImage = global::SimbaCafe.Properties.Resources.exitbutton;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(1262, 451);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(292, 240);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = global::SimbaCafe.Properties.Resources.menülogo;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Location = new System.Drawing.Point(970, 188);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(584, 257);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnKilit
            // 
            this.btnKilit.BackgroundImage = global::SimbaCafe.Properties.Resources.logout;
            this.btnKilit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKilit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKilit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKilit.Location = new System.Drawing.Point(970, 451);
            this.btnKilit.Name = "btnKilit";
            this.btnKilit.Size = new System.Drawing.Size(286, 240);
            this.btnKilit.TabIndex = 7;
            this.btnKilit.UseVisualStyleBackColor = true;
            this.btnKilit.Click += new System.EventHandler(this.btnKilit_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackgroundImage = global::SimbaCafe.Properties.Resources.ayarlarlogo;
            this.btnAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.Location = new System.Drawing.Point(678, 451);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(286, 240);
            this.btnAyarlar.TabIndex = 8;
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnKasaIslemleri
            // 
            this.btnKasaIslemleri.BackgroundImage = global::SimbaCafe.Properties.Resources.kasaislemlerilogo;
            this.btnKasaIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKasaIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKasaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKasaIslemleri.Location = new System.Drawing.Point(386, 451);
            this.btnKasaIslemleri.Name = "btnKasaIslemleri";
            this.btnKasaIslemleri.Size = new System.Drawing.Size(286, 240);
            this.btnKasaIslemleri.TabIndex = 9;
            this.btnKasaIslemleri.UseVisualStyleBackColor = true;
            this.btnKasaIslemleri.Click += new System.EventHandler(this.btnKasaIslemleri_Click);
            // 
            // frmAnamenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SimbaCafe.Properties.Resources.girisbg;
            this.ClientSize = new System.Drawing.Size(1924, 725);
            this.Controls.Add(this.btnKasaIslemleri);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnKilit);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMasalar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAnamenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAnamenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasalar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnKilit;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnKasaIslemleri;
    }
}