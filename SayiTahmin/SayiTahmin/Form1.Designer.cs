namespace SayiTahmin
{
    partial class Form1
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
            this.basla_but = new System.Windows.Forms.Button();
            this.ipucu = new System.Windows.Forms.Label();
            this.tahmin_text = new System.Windows.Forms.TextBox();
            this.tahmin_but = new System.Windows.Forms.Button();
            this.tahmin_gecmis = new System.Windows.Forms.ListBox();
            this.baslik = new System.Windows.Forms.Label();
            this.button_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // basla_but
            // 
            this.basla_but.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basla_but.BackColor = System.Drawing.Color.White;
            this.basla_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basla_but.Location = new System.Drawing.Point(183, 48);
            this.basla_but.Name = "basla_but";
            this.basla_but.Size = new System.Drawing.Size(273, 57);
            this.basla_but.TabIndex = 0;
            this.basla_but.Text = "OYUNA BAŞLA";
            this.basla_but.UseVisualStyleBackColor = false;
            this.basla_but.Click += new System.EventHandler(this.basla_but_Click);
            // 
            // ipucu
            // 
            this.ipucu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ipucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ipucu.Location = new System.Drawing.Point(12, 111);
            this.ipucu.Margin = new System.Windows.Forms.Padding(3);
            this.ipucu.Name = "ipucu";
            this.ipucu.Size = new System.Drawing.Size(623, 67);
            this.ipucu.TabIndex = 1;
            this.ipucu.Text = "4 basamaklı sayıyı tahmin ediniz.";
            this.ipucu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ipucu.Visible = false;
            // 
            // tahmin_text
            // 
            this.tahmin_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tahmin_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tahmin_text.Location = new System.Drawing.Point(83, 278);
            this.tahmin_text.MaxLength = 4;
            this.tahmin_text.Name = "tahmin_text";
            this.tahmin_text.Size = new System.Drawing.Size(203, 30);
            this.tahmin_text.TabIndex = 2;
            this.tahmin_text.Visible = false;
            this.tahmin_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tahmin_text_KeyPress);
            // 
            // tahmin_but
            // 
            this.tahmin_but.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tahmin_but.BackColor = System.Drawing.Color.White;
            this.tahmin_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tahmin_but.Location = new System.Drawing.Point(50, 388);
            this.tahmin_but.Name = "tahmin_but";
            this.tahmin_but.Size = new System.Drawing.Size(273, 55);
            this.tahmin_but.TabIndex = 3;
            this.tahmin_but.Text = "Tahmini Gönder";
            this.tahmin_but.UseVisualStyleBackColor = false;
            this.tahmin_but.Visible = false;
            this.tahmin_but.Click += new System.EventHandler(this.tahmin_but_Click);
            // 
            // tahmin_gecmis
            // 
            this.tahmin_gecmis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tahmin_gecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tahmin_gecmis.FormattingEnabled = true;
            this.tahmin_gecmis.ItemHeight = 25;
            this.tahmin_gecmis.Location = new System.Drawing.Point(391, 245);
            this.tahmin_gecmis.Name = "tahmin_gecmis";
            this.tahmin_gecmis.Size = new System.Drawing.Size(199, 229);
            this.tahmin_gecmis.TabIndex = 4;
            // 
            // baslik
            // 
            this.baslik.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(386, 207);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(153, 25);
            this.baslik.TabIndex = 5;
            this.baslik.Text = "Tahmin Geçmişi";
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.White;
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_1.Location = new System.Drawing.Point(12, 12);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(133, 57);
            this.button_1.TabIndex = 6;
            this.button_1.Text = "Nasıl Oynanır?";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(647, 528);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.tahmin_gecmis);
            this.Controls.Add(this.tahmin_but);
            this.Controls.Add(this.tahmin_text);
            this.Controls.Add(this.ipucu);
            this.Controls.Add(this.basla_but);
            this.Name = "Form1";
            this.Text = "SAYI TAHMİN OYUNU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button basla_but;
        private System.Windows.Forms.Label ipucu;
        private System.Windows.Forms.TextBox tahmin_text;
        private System.Windows.Forms.Button tahmin_but;
        private System.Windows.Forms.ListBox tahmin_gecmis;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.Button button_1;
    }
}

