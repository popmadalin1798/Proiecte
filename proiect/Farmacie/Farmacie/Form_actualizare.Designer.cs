namespace Farmacie
{
    partial class Form_actualizare
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
            this.lbl_num_med = new System.Windows.Forms.Label();
            this.txt_num_med = new System.Windows.Forms.TextBox();
            this.butt_ok = new System.Windows.Forms.Button();
            this.butt_anulare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_num_med
            // 
            this.lbl_num_med.AutoSize = true;
            this.lbl_num_med.Location = new System.Drawing.Point(87, 9);
            this.lbl_num_med.Name = "lbl_num_med";
            this.lbl_num_med.Size = new System.Drawing.Size(95, 13);
            this.lbl_num_med.TabIndex = 0;
            this.lbl_num_med.Text = "Nume medicament";
            // 
            // txt_num_med
            // 
            this.txt_num_med.Location = new System.Drawing.Point(82, 37);
            this.txt_num_med.Name = "txt_num_med";
            this.txt_num_med.Size = new System.Drawing.Size(100, 20);
            this.txt_num_med.TabIndex = 1;
            // 
            // butt_ok
            // 
            this.butt_ok.Location = new System.Drawing.Point(55, 86);
            this.butt_ok.Name = "butt_ok";
            this.butt_ok.Size = new System.Drawing.Size(75, 23);
            this.butt_ok.TabIndex = 2;
            this.butt_ok.Text = "Ok";
            this.butt_ok.UseVisualStyleBackColor = true;
            this.butt_ok.Click += new System.EventHandler(this.butt_ok_Click);
            // 
            // butt_anulare
            // 
            this.butt_anulare.Location = new System.Drawing.Point(152, 86);
            this.butt_anulare.Name = "butt_anulare";
            this.butt_anulare.Size = new System.Drawing.Size(75, 23);
            this.butt_anulare.TabIndex = 3;
            this.butt_anulare.Text = "Anulare";
            this.butt_anulare.UseVisualStyleBackColor = true;
            this.butt_anulare.Click += new System.EventHandler(this.butt_anulare_Click);
            // 
            // Form_actualizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 150);
            this.Controls.Add(this.butt_anulare);
            this.Controls.Add(this.butt_ok);
            this.Controls.Add(this.txt_num_med);
            this.Controls.Add(this.lbl_num_med);
            this.Name = "Form_actualizare";
            this.Text = "Form_actualizare";
            this.Load += new System.EventHandler(this.Form_actualizare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_num_med;
        private System.Windows.Forms.TextBox txt_num_med;
        private System.Windows.Forms.Button butt_ok;
        private System.Windows.Forms.Button butt_anulare;
    }
}