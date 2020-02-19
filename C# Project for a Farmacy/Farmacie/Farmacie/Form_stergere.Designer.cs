using System.Data;
using System.Data.OleDb;

namespace Farmacie
{
    partial class Form_stergere
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
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Madalin\Desktop\desk\piu\proiect\Farmacie\Farmacie\bin\Debug\Database2.mdb");
            this.checkedList_bad = new System.Windows.Forms.CheckedListBox();
            this.but_stg = new System.Windows.Forms.Button();
            this.but_anulare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedList_bad
            // 
            this.checkedList_bad.FormattingEnabled = true;
            this.checkedList_bad.Location = new System.Drawing.Point(81, 22);
            this.checkedList_bad.Name = "checkedList_bad";
            this.checkedList_bad.Size = new System.Drawing.Size(293, 154);
            Farmacie_lab8 f = new Farmacie_lab8();
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Tabel";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            f.data.DataSource = dt;
            con.Close();
            int i = 0;
            int limita = f.data.Rows.Count;
            string[] s = new string[100];
            while (i < limita - 1)
            {
                s[i] = f.data.Rows[i].Cells[0].Value.ToString();
                this.checkedList_bad.Items.Add(s[i]);
                i++;
            }
            this.checkedList_bad.TabIndex = 0;
            // 
            // but_stg
            // 
            this.but_stg.Location = new System.Drawing.Point(125, 209);
            this.but_stg.Name = "but_stg";
            this.but_stg.Size = new System.Drawing.Size(75, 23);
            this.but_stg.TabIndex = 1;
            this.but_stg.Text = "Sterge";
            this.but_stg.UseVisualStyleBackColor = true;
            this.but_stg.Click += new System.EventHandler(this.but_stg_Click);
            // 
            // but_anulare
            // 
            this.but_anulare.Location = new System.Drawing.Point(246, 209);
            this.but_anulare.Name = "but_anulare";
            this.but_anulare.Size = new System.Drawing.Size(75, 23);
            this.but_anulare.TabIndex = 2;
            this.but_anulare.Text = "Anulare";
            this.but_anulare.UseVisualStyleBackColor = true;
            this.but_anulare.Click += new System.EventHandler(this.but_anulare_Click);
            // 
            // Form_stergere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 284);
            this.Controls.Add(this.but_anulare);
            this.Controls.Add(this.but_stg);
            this.Controls.Add(this.checkedList_bad);
            this.Name = "Form_stergere";
            this.Text = "Form_stergere";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedList_bad;
        private System.Windows.Forms.Button but_stg;
        private System.Windows.Forms.Button but_anulare;
    }
}