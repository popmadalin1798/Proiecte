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
    public partial class Form_adaugare : Form
    {
        public string num_, pret_, nr_buc_;
        public string vand = string.Empty, valid = string.Empty;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Madalin\Desktop\desk\piu\proiect\Farmacie\Farmacie\bin\Debug\Database2.mdb");
        public Form_adaugare()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void anulare_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void adaugare_Click(object sender, EventArgs e)
        {

            num_ = txt_num.Text;
            pret_ = txt_pret.Text;
            nr_buc_ = txt_nr.Text;
            if(reteta.Checked)
            {
                fara_reteta.Checked = false;
                vand = "Da";
            }
            else if(fara_reteta.Checked)
            {
                reteta.Checked = false;
                vand = "Nu";
            }
            if(radioButton_da.Checked)
            {
                valid = radioButton_da.Text;
            }
            else if(radioButton_nu.Checked)
            {
                valid = radioButton_nu.Text;
            }
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Tabel values('" + num_ + "','" + nr_buc_+ "','" + pret_ + "','" + vand + "','" + valid + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Valorile au fost introduse");

        }
    }
}
