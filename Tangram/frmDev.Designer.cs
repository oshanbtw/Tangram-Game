
namespace Tangram
{
    partial class frmDev
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
            this.lblDev = new System.Windows.Forms.Label();
            this.btnCikisDev = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDev.Location = new System.Drawing.Point(64, 42);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(274, 15);
            this.lblDev.TabIndex = 0;
            this.lblDev.Text = "Bu program \"Oğuzhan\" tarafından geliştirilmiştir.";
            // 
            // btnCikisDev
            // 
            this.btnCikisDev.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCikisDev.FlatAppearance.BorderSize = 0;
            this.btnCikisDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisDev.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisDev.ForeColor = System.Drawing.Color.White;
            this.btnCikisDev.Location = new System.Drawing.Point(160, 75);
            this.btnCikisDev.Name = "btnCikisDev";
            this.btnCikisDev.Size = new System.Drawing.Size(75, 23);
            this.btnCikisDev.TabIndex = 1;
            this.btnCikisDev.Text = "ÇIKIŞ";
            this.btnCikisDev.UseVisualStyleBackColor = false;
            this.btnCikisDev.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Location = new System.Drawing.Point(-1, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 24);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 24);
            this.panel2.TabIndex = 3;
            // 
            // frmDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 146);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCikisDev);
            this.Controls.Add(this.lblDev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Button btnCikisDev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}