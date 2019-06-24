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
    public partial class Form_actualizare : Form
    {

        public string txt;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Madalin\Desktop\desk\piu\proiect\Farmacie\Farmacie\bin\Debug\Database2.mdb");
        public Form_actualizare()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form_actualizare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet.Tabel' table. You can move, or remove it, as needed.

        }

        private void butt_anulare_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butt_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_num_med.Text))
            {
                MessageBoxButtons but = MessageBoxButtons.OK;
                DialogResult res;
                res = MessageBox.Show("Introduceti un nume valid!", "Eroare la input", but);
            }
            else
            {
                Form_ediatare f = new Form_ediatare();
                Farmacie_lab8 frm = new Farmacie_lab8();
                string nume = txt_num_med.Text;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Tabel where nume='" + nume + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                frm.data.DataSource = dt;
                con.Close();
                f.richTextBox1.Text =frm.data.Rows[0].Cells[0].Value.ToString();
                this.Close();
                f.Show();
            }
        }
    }
}
