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
    public partial class Farmacie_lab8 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Madalin\Desktop\desk\piu\proiect\Farmacie\Farmacie\bin\Debug\Database2.mdb");
        public Farmacie_lab8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_actualizare f = new Form_actualizare();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_stergere f = new Form_stergere();
            f.Show();
        }

        private void adauga_Click(object sender, EventArgs e)
        {
            Form_adaugare f = new Form_adaugare();
            f.Show();
        }

        private void but_afis_Click(object sender, EventArgs e)
        {
            this.Width = 700;
            data.Visible = true;
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Tabel";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            data.DataSource = dt;
            con.Close();

        }

        private void info_Click(object sender, EventArgs e)
        {
            Form_info F = new Form_info();
            F.Show();
        }
    }
}
