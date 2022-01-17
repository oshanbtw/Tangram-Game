
namespace Tangram
{
    partial class frmHow
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCikisHow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level seçimini yaptıktan sonra renkli olan parçaları doğru olan siyah parçaların " +
    "üstüne\r\nsürükleyerek seviyeyi tamamlamak.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Location = new System.Drawing.Point(2, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 20);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 20);
            this.panel2.TabIndex = 2;
            // 
            // btnCikisHow
            // 
            this.btnCikisHow.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCikisHow.FlatAppearance.BorderSize = 0;
            this.btnCikisHow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisHow.ForeColor = System.Drawing.Color.White;
            this.btnCikisHow.Location = new System.Drawing.Point(270, 158);
            this.btnCikisHow.Name = "btnCikisHow";
            this.btnCikisHow.Size = new System.Drawing.Size(75, 23);
            this.btnCikisHow.TabIndex = 3;
            this.btnCikisHow.Text = "ÇIKIŞ";
            this.btnCikisHow.UseVisualStyleBackColor = false;
            this.btnCikisHow.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 242);
            this.Controls.Add(this.btnCikisHow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCikisHow;
    }
}