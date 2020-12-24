
namespace WindowsFormsApp18
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
            this.components = new System.ComponentModel.Container();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBilgi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 16;
            this.lstListe.Location = new System.Drawing.Point(133, 27);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(314, 324);
            this.lstListe.TabIndex = 0;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(133, 379);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(140, 33);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "Bir Kişi Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);

            // 
            // lblBilgi
            // 
            this.lblBilgi.Location = new System.Drawing.Point(0, 0);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(100, 23);
            this.lblBilgi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.lstListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBilgi;
    }
}

