using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacie
{
    public partial class Form_ediatare : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Madalin\Desktop\desk\piu\proiect\Farmacie\Farmacie\bin\Debug\Database2.mdb");
        public Form_ediatare()
        {
            InitializeComponent();
        }

        private void butt_anulare_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butt_mod_Click(object sender, EventArgs e)
        {
            Form_actualizare f = new Form_actualizare();
            this.Close();
            f.Show();
        }

        private void butt_save_Click(object sender, EventArgs e)
        {
            string num, nr_buc, pret;
            string valid = string.Empty;
            string ret = string.Empty;
            num = txt_nume.Text;
            nr_buc = txt_nr_buc.Text;
            pret = txt_pret.Text;
            if(chk_cu_reteta.Checked)
            {
                ret = "Da";
            }
            else if(chk_fara_reteta.Checked)
            {
                ret = "Nu";
            }
            if(chk_da.Checked)
            {
                valid = "Da";
            }
            else if(chk_nu.Checked)
            {
                valid = "Nu";
            }
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update Tabel set nume='" + num + "',nr_buc='" + nr_buc + "',pret='" + pret + "',Reteta='" + ret + "',Valabilitate='" + valid + "' where nume='" + richTextBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Entitatea a fost editata");
        }
    }
}
