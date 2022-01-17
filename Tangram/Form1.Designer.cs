
namespace Tangram
{
    partial class frmMain
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnHow = new System.Windows.Forms.Button();
            this.btnDev = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblT = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBasla.FlatAppearance.BorderSize = 0;
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasla.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btnBasla.ForeColor = System.Drawing.Color.White;
            this.btnBasla.Location = new System.Drawing.Point(216, 147);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(130, 50);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnHow
            // 
            this.btnHow.BackColor = System.Drawing.Color.SkyBlue;
            this.btnHow.FlatAppearance.BorderSize = 0;
            this.btnHow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHow.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHow.ForeColor = System.Drawing.Color.White;
            this.btnHow.Location = new System.Drawing.Point(216, 203);
            this.btnHow.Name = "btnHow";
            this.btnHow.Size = new System.Drawing.Size(130, 50);
            this.btnHow.TabIndex = 0;
            this.btnHow.Text = "Nasıl Oynanır?";
            this.btnHow.UseVisualStyleBackColor = false;
            this.btnHow.Click += new System.EventHandler(this.btnHow_Click);
            // 
            // btnDev
            // 
            this.btnDev.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDev.FlatAppearance.BorderSize = 0;
            this.btnDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDev.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btnDev.ForeColor = System.Drawing.Color.White;
            this.btnDev.Location = new System.Drawing.Point(216, 259);
            this.btnDev.Name = "btnDev";
            this.btnDev.Size = new System.Drawing.Size(130, 50);
            this.btnDev.TabIndex = 0;
            this.btnDev.Text = "Geliştiriciler";
            this.btnDev.UseVisualStyleBackColor = false;
            this.btnDev.Click += new System.EventHandler(this.btnDev_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(216, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 50);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.BackColor = System.Drawing.Color.Transparent;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblT.ForeColor = System.Drawing.Color.Green;
            this.lblT.Location = new System.Drawing.Point(23, 48);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(74, 76);
            this.lblT.TabIndex = 1;
            this.lblT.Text = "T";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.Transparent;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblA.ForeColor = System.Drawing.Color.Orange;
            this.lblA.Location = new System.Drawing.Point(93, 48);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(78, 76);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.BackColor = System.Drawing.Color.Transparent;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblN.ForeColor = System.Drawing.Color.Blue;
            this.lblN.Location = new System.Drawing.Point(163, 48);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(81, 76);
            this.lblN.TabIndex = 1;
            this.lblN.Text = "N";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.BackColor = System.Drawing.Color.Transparent;
            this.lblG.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblG.ForeColor = System.Drawing.Color.Red;
            this.lblG.Location = new System.Drawing.Point(233, 48);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(85, 76);
            this.lblG.TabIndex = 1;
            this.lblG.Text = "G";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.BackColor = System.Drawing.Color.Transparent;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblR.ForeColor = System.Drawing.Color.Yellow;
            this.lblR.Location = new System.Drawing.Point(303, 48);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(81, 76);
            this.lblR.TabIndex = 1;
            this.lblR.Text = "R";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.BackColor = System.Drawing.Color.Transparent;
            this.lblA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblA2.ForeColor = System.Drawing.Color.Purple;
            this.lblA2.Location = new System.Drawing.Point(373, 48);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(78, 76);
            this.lblA2.TabIndex = 1;
            this.lblA2.Text = "A";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.BackColor = System.Drawing.Color.Transparent;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblM.ForeColor = System.Drawing.Color.Pink;
            this.lblM.Location = new System.Drawing.Point(443, 48);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(89, 76);
            this.lblM.TabIndex = 1;
            this.lblM.Text = "M";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Tangram.Properties.Resources.hand_painted_watercolor_background_with_sky_clouds_shape_24972_1095;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 398);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblA2);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDev);
            this.Controls.Add(this.btnHow);
            this.Controls.Add(this.btnBasla);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tangram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnHow;
        private System.Windows.Forms.Button btnDev;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label lblM;
    }
}

