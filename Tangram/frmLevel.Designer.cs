
namespace Tangram
{
    partial class frmLevel
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
            this.btnKolay = new System.Windows.Forms.Button();
            this.btnOrta = new System.Windows.Forms.Button();
            this.btnZor = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnKolay
            // 
            this.btnKolay.BackColor = System.Drawing.Color.SkyBlue;
            this.btnKolay.FlatAppearance.BorderSize = 0;
            this.btnKolay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKolay.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKolay.ForeColor = System.Drawing.Color.White;
            this.btnKolay.Location = new System.Drawing.Point(81, 34);
            this.btnKolay.Name = "btnKolay";
            this.btnKolay.Size = new System.Drawing.Size(80, 36);
            this.btnKolay.TabIndex = 0;
            this.btnKolay.Text = "KOLAY";
            this.btnKolay.UseVisualStyleBackColor = false;
            this.btnKolay.Click += new System.EventHandler(this.btnKolay_Click);
            // 
            // btnOrta
            // 
            this.btnOrta.BackColor = System.Drawing.Color.SkyBlue;
            this.btnOrta.FlatAppearance.BorderSize = 0;
            this.btnOrta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrta.ForeColor = System.Drawing.Color.White;
            this.btnOrta.Location = new System.Drawing.Point(81, 93);
            this.btnOrta.Name = "btnOrta";
            this.btnOrta.Size = new System.Drawing.Size(80, 36);
            this.btnOrta.TabIndex = 0;
            this.btnOrta.Text = "ORTA";
            this.btnOrta.UseVisualStyleBackColor = false;
            this.btnOrta.Click += new System.EventHandler(this.btnOrta_Click);
            // 
            // btnZor
            // 
            this.btnZor.BackColor = System.Drawing.Color.SkyBlue;
            this.btnZor.FlatAppearance.BorderSize = 0;
            this.btnZor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZor.ForeColor = System.Drawing.Color.White;
            this.btnZor.Location = new System.Drawing.Point(81, 152);
            this.btnZor.Name = "btnZor";
            this.btnZor.Size = new System.Drawing.Size(80, 36);
            this.btnZor.TabIndex = 0;
            this.btnZor.Text = "ZOR";
            this.btnZor.UseVisualStyleBackColor = false;
            this.btnZor.Click += new System.EventHandler(this.btnZor_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(147, 209);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(80, 32);
            this.btnGeri.TabIndex = 0;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 16);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Location = new System.Drawing.Point(-1, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 16);
            this.panel2.TabIndex = 2;
            // 
            // frmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Tangram.Properties.Resources.hand_painted_watercolor_background_with_sky_clouds_shape_24972_1095;
            this.ClientSize = new System.Drawing.Size(239, 280);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnZor);
            this.Controls.Add(this.btnOrta);
            this.Controls.Add(this.btnKolay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLevel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKolay;
        private System.Windows.Forms.Button btnOrta;
        private System.Windows.Forms.Button btnZor;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}