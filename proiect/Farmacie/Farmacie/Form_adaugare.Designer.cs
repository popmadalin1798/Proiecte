using System.Data.OleDb;

namespace Farmacie
{
    partial class Form_adaugare
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
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_pret = new System.Windows.Forms.TextBox();
            this.txt_nr = new System.Windows.Forms.TextBox();
            this.nume = new System.Windows.Forms.Label();
            this.pret = new System.Windows.Forms.Label();
            this.nr_buc = new System.Windows.Forms.Label();
            this.reteta = new System.Windows.Forms.CheckBox();
            this.fara_reteta = new System.Windows.Forms.CheckBox();
            this.group_valabilitate = new System.Windows.Forms.GroupBox();
            this.radioButton_nu = new System.Windows.Forms.RadioButton();
            this.radioButton_da = new System.Windows.Forms.RadioButton();
            this.group_vanzare = new System.Windows.Forms.GroupBox();
            this.adaugare = new System.Windows.Forms.Button();
            this.anulare = new System.Windows.Forms.Button();
            this.group_valabilitate.SuspendLayout();
            this.group_vanzare.SuspendLayout();
            this.SuspendLayout();
           
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(22, 47);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(115, 20);
            this.txt_num.TabIndex = 0;
            // 
            // txt_pret
            // 
            this.txt_pret.Location = new System.Drawing.Point(143, 47);
            this.txt_pret.Name = "txt_pret";
            this.txt_pret.Size = new System.Drawing.Size(115, 20);
            this.txt_pret.TabIndex = 1;
            // 
            // txt_nr
            // 
            this.txt_nr.Location = new System.Drawing.Point(264, 47);
            this.txt_nr.Name = "txt_nr";
            this.txt_nr.Size = new System.Drawing.Size(115, 20);
            this.txt_nr.TabIndex = 2;
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Location = new System.Drawing.Point(65, 28);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(35, 13);
            this.nume.TabIndex = 3;
            this.nume.Text = "Nume";
            // 
            // pret
            // 
            this.pret.AutoSize = true;
            this.pret.Location = new System.Drawing.Point(186, 28);
            this.pret.Name = "pret";
            this.pret.Size = new System.Drawing.Size(26, 13);
            this.pret.TabIndex = 4;
            this.pret.Text = "Pret";
            // 
            // nr_buc
            // 
            this.nr_buc.AutoSize = true;
            this.nr_buc.Location = new System.Drawing.Point(290, 28);
            this.nr_buc.Name = "nr_buc";
            this.nr_buc.Size = new System.Drawing.Size(70, 13);
            this.nr_buc.TabIndex = 5;
            this.nr_buc.Text = "Numar bucati";
            // 
            // reteta
            // 
            this.reteta.AutoSize = true;
            this.reteta.Location = new System.Drawing.Point(56, 19);
            this.reteta.Name = "reteta";
            this.reteta.Size = new System.Drawing.Size(69, 17);
            this.reteta.TabIndex = 6;
            this.reteta.Text = "Cu reteta";
            this.reteta.UseVisualStyleBackColor = true;
            // 
            // fara_reteta
            // 
            this.fara_reteta.AutoSize = true;
            this.fara_reteta.Location = new System.Drawing.Point(56, 53);
            this.fara_reteta.Name = "fara_reteta";
            this.fara_reteta.Size = new System.Drawing.Size(77, 17);
            this.fara_reteta.TabIndex = 7;
            this.fara_reteta.Text = "Fara reteta";
            this.fara_reteta.UseVisualStyleBackColor = true;
            // 
            // group_valabilitate
            // 
            this.group_valabilitate.Controls.Add(this.radioButton_nu);
            this.group_valabilitate.Controls.Add(this.radioButton_da);
            this.group_valabilitate.Location = new System.Drawing.Point(22, 211);
            this.group_valabilitate.Name = "group_valabilitate";
            this.group_valabilitate.Size = new System.Drawing.Size(200, 100);
            this.group_valabilitate.TabIndex = 9;
            this.group_valabilitate.TabStop = false;
            this.group_valabilitate.Text = "Valabilitate in farmacie";
            // 
            // radioButton_nu
            // 
            this.radioButton_nu.AutoSize = true;
            this.radioButton_nu.Location = new System.Drawing.Point(48, 61);
            this.radioButton_nu.Name = "radioButton_nu";
            this.radioButton_nu.Size = new System.Drawing.Size(39, 17);
            this.radioButton_nu.TabIndex = 1;
            this.radioButton_nu.TabStop = true;
            this.radioButton_nu.Text = "Nu";
            this.radioButton_nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_da
            // 
            this.radioButton_da.AutoSize = true;
            this.radioButton_da.Location = new System.Drawing.Point(48, 29);
            this.radioButton_da.Name = "radioButton_da";
            this.radioButton_da.Size = new System.Drawing.Size(39, 17);
            this.radioButton_da.TabIndex = 0;
            this.radioButton_da.TabStop = true;
            this.radioButton_da.Text = "Da";
            this.radioButton_da.UseVisualStyleBackColor = true;
            // 
            // group_vanzare
            // 
            this.group_vanzare.Controls.Add(this.fara_reteta);
            this.group_vanzare.Controls.Add(this.reteta);
            this.group_vanzare.Location = new System.Drawing.Point(22, 103);
            this.group_vanzare.Name = "group_vanzare";
            this.group_vanzare.Size = new System.Drawing.Size(200, 100);
            this.group_vanzare.TabIndex = 10;
            this.group_vanzare.TabStop = false;
            this.group_vanzare.Text = "Se vinde";
            // 
            // adaugare
            // 
            this.adaugare.Location = new System.Drawing.Point(321, 180);
            this.adaugare.Name = "adaugare";
            this.adaugare.Size = new System.Drawing.Size(75, 23);
            this.adaugare.TabIndex = 11;
            this.adaugare.Text = "Adauga";
            this.adaugare.UseVisualStyleBackColor = true;
            this.adaugare.Click += new System.EventHandler(this.adaugare_Click);
            // 
            // anulare
            // 
            this.anulare.Location = new System.Drawing.Point(321, 234);
            this.anulare.Name = "anulare";
            this.anulare.Size = new System.Drawing.Size(75, 23);
            this.anulare.TabIndex = 12;
            this.anulare.Text = "Anulare";
            this.anulare.UseVisualStyleBackColor = true;
            this.anulare.Click += new System.EventHandler(this.anulare_Click);
            // 
            // Form_adaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 323);
            this.Controls.Add(this.anulare);
            this.Controls.Add(this.adaugare);
            this.Controls.Add(this.group_vanzare);
            this.Controls.Add(this.group_valabilitate);
            this.Controls.Add(this.nr_buc);
            this.Controls.Add(this.pret);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.txt_nr);
            this.Controls.Add(this.txt_pret);
            this.Controls.Add(this.txt_num);
            this.Name = "Form_adaugare";
            this.Text = "Form_adaugare";
            this.group_valabilitate.ResumeLayout(false);
            this.group_valabilitate.PerformLayout();
            this.group_vanzare.ResumeLayout(false);
            this.group_vanzare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_pret;
        private System.Windows.Forms.TextBox txt_nr;
        private System.Windows.Forms.Label nume;
        private System.Windows.Forms.Label pret;
        private System.Windows.Forms.Label nr_buc;
        private System.Windows.Forms.CheckBox reteta;
        private System.Windows.Forms.CheckBox fara_reteta;
        private System.Windows.Forms.GroupBox group_valabilitate;
        private System.Windows.Forms.RadioButton radioButton_nu;
        private System.Windows.Forms.RadioButton radioButton_da;
        private System.Windows.Forms.GroupBox group_vanzare;
        private System.Windows.Forms.Button adaugare;
        private System.Windows.Forms.Button anulare;
    }
}