
namespace Tangram
{
    partial class frmKolay
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
            this.btnK1 = new System.Windows.Forms.Button();
            this.btnK2 = new System.Windows.Forms.Button();
            this.btnK3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnK1
            // 
            this.btnK1.BackColor = System.Drawing.Color.SkyBlue;
            this.btnK1.FlatAppearance.BorderSize = 0;
            this.btnK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnK1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnK1.ForeColor = System.Drawing.Color.White;
            this.btnK1.Location = new System.Drawing.Point(62, 28);
            this.btnK1.Name = "btnK1";
            this.btnK1.Size = new System.Drawing.Size(80, 36);
            this.btnK1.TabIndex = 1;
            this.btnK1.Text = "LEVEL 1";
            this.btnK1.UseVisualStyleBackColor = false;
            this.btnK1.Click += new System.EventHandler(this.btnK1_Click);
            // 
            // btnK2
            // 
            this.btnK2.BackColor = System.Drawing.Color.SkyBlue;
            this.btnK2.FlatAppearance.BorderSize = 0;
            this.btnK2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnK2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnK2.ForeColor = System.Drawing.Color.White;
            this.btnK2.Location = new System.Drawing.Point(62, 90);
            this.btnK2.Name = "btnK2";
            this.btnK2.Size = new System.Drawing.Size(80, 36);
            this.btnK2.TabIndex = 1;
            this.btnK2.Text = "LEVEL 2";
            this.btnK2.UseVisualStyleBackColor = false;
            this.btnK2.Click += new System.EventHandler(this.btnK2_Click);
            // 
            // btnK3
            // 
            this.btnK3.BackColor = System.Drawing.Color.SkyBlue;
            this.btnK3.FlatAppearance.BorderSize = 0;
            this.btnK3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnK3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnK3.ForeColor = System.Drawing.Color.White;
            this.btnK3.Location = new System.Drawing.Point(62, 150);
            this.btnK3.Name = "btnK3";
            this.btnK3.Size = new System.Drawing.Size(80, 36);
            this.btnK3.TabIndex = 1;
            this.btnK3.Text = "LEVEL 3";
            this.btnK3.UseVisualStyleBackColor = false;
            this.btnK3.Click += new System.EventHandler(this.btnK3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 20);
            this.panel2.TabIndex = 3;
            // 
            // frmKolay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Tangram.Properties.Resources.hand_painted_watercolor_background_with_sky_clouds_shape_24972_1095;
            this.ClientSize = new System.Drawing.Size(199, 212);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnK3);
            this.Controls.Add(this.btnK2);
            this.Controls.Add(this.btnK1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKolay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKolay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnK1;
        private System.Windows.Forms.Button btnK2;
        private System.Windows.Forms.Button btnK3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}