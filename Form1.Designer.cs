namespace TekCift
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
            this.btnhesapla = new System.Windows.Forms.Button();
            this.txtboy = new System.Windows.Forms.TextBox();
            this.lblboy = new System.Windows.Forms.Label();
            this.lblkilo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhesapla
            // 
            this.btnhesapla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhesapla.Location = new System.Drawing.Point(99, 129);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(76, 23);
            this.btnhesapla.TabIndex = 0;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // txtboy
            // 
            this.txtboy.Location = new System.Drawing.Point(89, 35);
            this.txtboy.Name = "txtboy";
            this.txtboy.Size = new System.Drawing.Size(100, 20);
            this.txtboy.TabIndex = 1;
            // 
            // lblboy
            // 
            this.lblboy.AutoSize = true;
            this.lblboy.Location = new System.Drawing.Point(48, 38);
            this.lblboy.Name = "lblboy";
            this.lblboy.Size = new System.Drawing.Size(28, 13);
            this.lblboy.TabIndex = 2;
            this.lblboy.Text = "Boy:";
            // 
            // lblkilo
            // 
            this.lblkilo.AutoSize = true;
            this.lblkilo.Location = new System.Drawing.Point(48, 85);
            this.lblkilo.Name = "lblkilo";
            this.lblkilo.Size = new System.Drawing.Size(27, 13);
            this.lblkilo.TabIndex = 4;
            this.lblkilo.Text = "Kilo:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(255, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sonuç:";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(313, 82);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(10, 13);
            this.lblsonuc.TabIndex = 6;
            this.lblsonuc.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(622, 325);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblkilo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblboy);
            this.Controls.Add(this.txtboy);
            this.Controls.Add(this.btnhesapla);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.TextBox txtboy;
        private System.Windows.Forms.Label lblboy;
        private System.Windows.Forms.Label lblkilo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsonuc;
    }
}

