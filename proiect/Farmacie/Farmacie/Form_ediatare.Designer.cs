namespace Farmacie
{
    partial class Form_ediatare
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.butt_mod = new System.Windows.Forms.Button();
            this.lbl_nume = new System.Windows.Forms.Label();
            this.txt_nume = new System.Windows.Forms.TextBox();
            this.txt_pret = new System.Windows.Forms.TextBox();
            this.lbl_pret = new System.Windows.Forms.Label();
            this.txt_nr_buc = new System.Windows.Forms.TextBox();
            this.lbl_nr_buc = new System.Windows.Forms.Label();
            this.group_reteta = new System.Windows.Forms.GroupBox();
            this.chk_fara_reteta = new System.Windows.Forms.CheckBox();
            this.chk_cu_reteta = new System.Windows.Forms.CheckBox();
            this.group_valabil = new System.Windows.Forms.GroupBox();
            this.chk_nu = new System.Windows.Forms.CheckBox();
            this.chk_da = new System.Windows.Forms.CheckBox();
            this.butt_save = new System.Windows.Forms.Button();
            this.butt_anulare = new System.Windows.Forms.Button();
            this.group_reteta.SuspendLayout();
            this.group_valabil.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(101, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(330, 55);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // butt_mod
            // 
            this.butt_mod.Location = new System.Drawing.Point(238, 73);
            this.butt_mod.Name = "butt_mod";
            this.butt_mod.Size = new System.Drawing.Size(75, 23);
            this.butt_mod.TabIndex = 1;
            this.butt_mod.Text = "Modifica";
            this.butt_mod.UseVisualStyleBackColor = true;
            this.butt_mod.Click += new System.EventHandler(this.butt_mod_Click);
            // 
            // lbl_nume
            // 
            this.lbl_nume.AutoSize = true;
            this.lbl_nume.Location = new System.Drawing.Point(98, 129);
            this.lbl_nume.Name = "lbl_nume";
            this.lbl_nume.Size = new System.Drawing.Size(35, 13);
            this.lbl_nume.TabIndex = 2;
            this.lbl_nume.Text = "Nume";
            // 
            // txt_nume
            // 
            this.txt_nume.Location = new System.Drawing.Point(68, 169);
            this.txt_nume.Name = "txt_nume";
            this.txt_nume.Size = new System.Drawing.Size(100, 20);
            this.txt_nume.TabIndex = 3;
            // 
            // txt_pret
            // 
            this.txt_pret.Location = new System.Drawing.Point(220, 169);
            this.txt_pret.Name = "txt_pret";
            this.txt_pret.Size = new System.Drawing.Size(100, 20);
            this.txt_pret.TabIndex = 5;
            // 
            // lbl_pret
            // 
            this.lbl_pret.AutoSize = true;
            this.lbl_pret.Location = new System.Drawing.Point(253, 129);
            this.lbl_pret.Name = "lbl_pret";
            this.lbl_pret.Size = new System.Drawing.Size(26, 13);
            this.lbl_pret.TabIndex = 4;
            this.lbl_pret.Text = "Pret";
            // 
            // txt_nr_buc
            // 
            this.txt_nr_buc.Location = new System.Drawing.Point(363, 169);
            this.txt_nr_buc.Name = "txt_nr_buc";
            this.txt_nr_buc.Size = new System.Drawing.Size(100, 20);
            this.txt_nr_buc.TabIndex = 7;
            // 
            // lbl_nr_buc
            // 
            this.lbl_nr_buc.AutoSize = true;
            this.lbl_nr_buc.Location = new System.Drawing.Point(377, 129);
            this.lbl_nr_buc.Name = "lbl_nr_buc";
            this.lbl_nr_buc.Size = new System.Drawing.Size(70, 13);
            this.lbl_nr_buc.TabIndex = 6;
            this.lbl_nr_buc.Text = "Numar bucati";
            // 
            // group_reteta
            // 
            this.group_reteta.Controls.Add(this.chk_fara_reteta);
            this.group_reteta.Controls.Add(this.chk_cu_reteta);
            this.group_reteta.Location = new System.Drawing.Point(101, 196);
            this.group_reteta.Name = "group_reteta";
            this.group_reteta.Size = new System.Drawing.Size(330, 36);
            this.group_reteta.TabIndex = 8;
            this.group_reteta.TabStop = false;
            this.group_reteta.Text = "Se vinde";
            // 
            // chk_fara_reteta
            // 
            this.chk_fara_reteta.AutoSize = true;
            this.chk_fara_reteta.Location = new System.Drawing.Point(199, 13);
            this.chk_fara_reteta.Name = "chk_fara_reteta";
            this.chk_fara_reteta.Size = new System.Drawing.Size(77, 17);
            this.chk_fara_reteta.TabIndex = 1;
            this.chk_fara_reteta.Text = "Fara reteta";
            this.chk_fara_reteta.UseVisualStyleBackColor = true;
            // 
            // chk_cu_reteta
            // 
            this.chk_cu_reteta.AutoSize = true;
            this.chk_cu_reteta.Location = new System.Drawing.Point(51, 13);
            this.chk_cu_reteta.Name = "chk_cu_reteta";
            this.chk_cu_reteta.Size = new System.Drawing.Size(69, 17);
            this.chk_cu_reteta.TabIndex = 0;
            this.chk_cu_reteta.Text = "Cu reteta";
            this.chk_cu_reteta.UseVisualStyleBackColor = true;
            // 
            // group_valabil
            // 
            this.group_valabil.Controls.Add(this.chk_nu);
            this.group_valabil.Controls.Add(this.chk_da);
            this.group_valabil.Location = new System.Drawing.Point(101, 248);
            this.group_valabil.Name = "group_valabil";
            this.group_valabil.Size = new System.Drawing.Size(330, 36);
            this.group_valabil.TabIndex = 9;
            this.group_valabil.TabStop = false;
            this.group_valabil.Text = "Valabil in farmacie";
            // 
            // chk_nu
            // 
            this.chk_nu.AutoSize = true;
            this.chk_nu.Location = new System.Drawing.Point(199, 13);
            this.chk_nu.Name = "chk_nu";
            this.chk_nu.Size = new System.Drawing.Size(40, 17);
            this.chk_nu.TabIndex = 1;
            this.chk_nu.Text = "Nu";
            this.chk_nu.UseVisualStyleBackColor = true;
            // 
            // chk_da
            // 
            this.chk_da.AutoSize = true;
            this.chk_da.Location = new System.Drawing.Point(51, 13);
            this.chk_da.Name = "chk_da";
            this.chk_da.Size = new System.Drawing.Size(40, 17);
            this.chk_da.TabIndex = 0;
            this.chk_da.Text = "Da";
            this.chk_da.UseVisualStyleBackColor = true;
            // 
            // butt_save
            // 
            this.butt_save.Location = new System.Drawing.Point(146, 317);
            this.butt_save.Name = "butt_save";
            this.butt_save.Size = new System.Drawing.Size(75, 23);
            this.butt_save.TabIndex = 10;
            this.butt_save.Text = "Salveaza";
            this.butt_save.UseVisualStyleBackColor = true;
            this.butt_save.Click += new System.EventHandler(this.butt_save_Click);
            // 
            // butt_anulare
            // 
            this.butt_anulare.Location = new System.Drawing.Point(300, 317);
            this.butt_anulare.Name = "butt_anulare";
            this.butt_anulare.Size = new System.Drawing.Size(75, 23);
            this.butt_anulare.TabIndex = 11;
            this.butt_anulare.Text = "Anulare";
            this.butt_anulare.UseVisualStyleBackColor = true;
            this.butt_anulare.Click += new System.EventHandler(this.butt_anulare_Click);
            // 
            // Form_ediatare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 368);
            this.Controls.Add(this.butt_anulare);
            this.Controls.Add(this.butt_save);
            this.Controls.Add(this.group_valabil);
            this.Controls.Add(this.group_reteta);
            this.Controls.Add(this.txt_nr_buc);
            this.Controls.Add(this.lbl_nr_buc);
            this.Controls.Add(this.txt_pret);
            this.Controls.Add(this.lbl_pret);
            this.Controls.Add(this.txt_nume);
            this.Controls.Add(this.lbl_nume);
            this.Controls.Add(this.butt_mod);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form_ediatare";
            this.Text = "Form_ediatare";
            this.group_reteta.ResumeLayout(false);
            this.group_reteta.PerformLayout();
            this.group_valabil.ResumeLayout(false);
            this.group_valabil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button butt_mod;
        private System.Windows.Forms.Label lbl_nume;
        private System.Windows.Forms.TextBox txt_nume;
        private System.Windows.Forms.TextBox txt_pret;
        private System.Windows.Forms.Label lbl_pret;
        private System.Windows.Forms.TextBox txt_nr_buc;
        private System.Windows.Forms.Label lbl_nr_buc;
        private System.Windows.Forms.GroupBox group_reteta;
        private System.Windows.Forms.CheckBox chk_fara_reteta;
        private System.Windows.Forms.CheckBox chk_cu_reteta;
        private System.Windows.Forms.GroupBox group_valabil;
        private System.Windows.Forms.CheckBox chk_nu;
        private System.Windows.Forms.CheckBox chk_da;
        private System.Windows.Forms.Button butt_save;
        private System.Windows.Forms.Button butt_anulare;
    }
}