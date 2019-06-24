using System.Windows.Forms;

namespace Farmacie
{
    partial class Farmacie_lab8
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
            this.adauga = new System.Windows.Forms.Button();
            this.actualizare = new System.Windows.Forms.Button();
            this.sterge = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.but_afis = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // adauga
            // 
            this.adauga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adauga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adauga.Location = new System.Drawing.Point(76, 70);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(94, 30);
            this.adauga.TabIndex = 0;
            this.adauga.Text = "Adaugare";
            this.adauga.UseVisualStyleBackColor = true;
            this.adauga.Click += new System.EventHandler(this.adauga_Click);
            // 
            // actualizare
            // 
            this.actualizare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.actualizare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actualizare.Location = new System.Drawing.Point(76, 106);
            this.actualizare.Name = "actualizare";
            this.actualizare.Size = new System.Drawing.Size(94, 30);
            this.actualizare.TabIndex = 1;
            this.actualizare.Text = "Actualizare";
            this.actualizare.UseVisualStyleBackColor = true;
            this.actualizare.Click += new System.EventHandler(this.button1_Click);
            // 
            // sterge
            // 
            this.sterge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sterge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sterge.Location = new System.Drawing.Point(76, 142);
            this.sterge.Name = "sterge";
            this.sterge.Size = new System.Drawing.Size(94, 30);
            this.sterge.TabIndex = 2;
            this.sterge.Text = "Stergere";
            this.sterge.UseVisualStyleBackColor = true;
            this.sterge.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // info
            // 
            this.info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.Location = new System.Drawing.Point(76, 178);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(94, 30);
            this.info.TabIndex = 3;
            this.info.Text = "Info Aplicatie";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // but_afis
            // 
            this.but_afis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but_afis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_afis.Location = new System.Drawing.Point(76, 34);
            this.but_afis.Name = "but_afis";
            this.but_afis.Size = new System.Drawing.Size(94, 30);
            this.but_afis.TabIndex = 4;
            this.but_afis.Text = "Arata baza de date";
            this.but_afis.UseVisualStyleBackColor = true;
            this.but_afis.Click += new System.EventHandler(this.but_afis_Click);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(199, 34);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(587, 193);
            this.data.TabIndex = 0;
            this.data.Visible = false;
            // 
            // Farmacie_lab8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Farmacie.Properties.Resources.bkg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(267, 247);
            this.Controls.Add(this.data);
            this.Controls.Add(this.but_afis);
            this.Controls.Add(this.info);
            this.Controls.Add(this.sterge);
            this.Controls.Add(this.actualizare);
            this.Controls.Add(this.adauga);
            this.Name = "Farmacie_lab8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacie_lab8";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adauga;
        private System.Windows.Forms.Button actualizare;
        private System.Windows.Forms.Button sterge;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button but_afis;
        public DataGridView data;
    }
}