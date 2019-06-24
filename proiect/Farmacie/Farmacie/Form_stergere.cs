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
    public partial class Form_stergere : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Madalin\Desktop\desk\piu\proiect\Farmacie\Farmacie\bin\Debug\Database2.mdb");
        public Form_stergere()
        {
           
            InitializeComponent();
            
        }

        private void but_anulare_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_stg_Click(object sender, EventArgs e)
        {
            if(checkedList_bad.CheckedItems.Count!=0 && checkedList_bad.CheckedItems.Count < 2 )
            {
                string alt = string.Empty;
                int select = checkedList_bad.SelectedIndex; ;
                alt = checkedList_bad.Items[select].ToString();
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE from Tabel where nume = '" + alt + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Entitatea a fost stearsa");
                this.Close();
            }
            else
            {
                MessageBox.Show("Alegeti doar o entitate!");
            }
        }
    }
}
