using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.OleDb;
using System.Data;
//din laboratorul 2 pana la 4 am lucrat pe consola.De la laboratorul 5 si 6 am utilizat interfata grafica.De asemenea am pastrat functionalitatea
//consolei dupa inchiderea form-ului pentru a demostra faptul ca ceea ce am lucrat pentru proiect din primele laboratoare este functional.
namespace Farmacie
{
    public class AppForm1 : Form
    {
        private Label Titlu;
        private PictureBox tit;
        private Button btnCalculeaza;
        private Label lblPerimetru;
        private Label continut;
        private Label nume;
        private Label nr_buc;
        private Label pret;
        private Label nume_inlocuit;
        private TextBox _nume_inlocuit;
        private TextBox _pret;
        private TextBox _nume;
        private TextBox _nr_buc;
        private Button adauga;
        private Button cauta;
        private ComboBox edit;
        private Button sterge;
        private Button editare;
        private DataGridView data;
        private const int LATIME_CONTROL = 120;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 150;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Madalin\Desktop\desk\piu\proiect\Farmacie\Farmacie\bin\Debug\Database1.mdb");

        public AppForm1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new System.Drawing.Point(100, 100);
            this.Text = "Farmacia inimii USV <3";
            this.BackgroundImage = new Bitmap("bkg.jpg");
            this.Size = this.BackgroundImage.Size;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            //baza de date
            data = new DataGridView();
            data.Width = LATIME_CONTROL*3;
            data.Height = LATIME_CONTROL+50 ;
            data.Visible = false;
            data.Location = new System.Drawing.Point(2 * DIMENSIUNE_PAS_X-60,2 * DIMENSIUNE_PAS_Y-20);
            this.Controls.Add(data);
            //titlu si imagine
            Titlu = new Label();
            Titlu.Width = 200;
            Titlu.Left = 100;
            Titlu.Text = "Farmacia inimii USV";
            Titlu.BackColor = Color.Transparent;
            Titlu.ForeColor = Color.Blue;
            Titlu.Font = new Font("Times New Roman", 16, FontStyle.Italic);
            Titlu.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 1);
            this.Controls.Add(Titlu);
            tit = new PictureBox();
            tit.Image = Image.FromFile("titlu.png");
            tit.SizeMode = PictureBoxSizeMode.AutoSize;
            tit.BackColor = Color.Transparent;
            tit.Location = new System.Drawing.Point(2 * DIMENSIUNE_PAS_X + 22, -20);
            this.Controls.Add(tit);
            //textbox continut;
            continut = new Label();
            continut.Width = LATIME_CONTROL * 2;
            continut.Height = LATIME_CONTROL * 2 - 50;
            continut.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X * 2, 5 * DIMENSIUNE_PAS_Y);
            continut.Visible = false;
            this.Controls.Add(continut);
            //adaugare vizualizare baza de date
            btnCalculeaza = new Button();
            btnCalculeaza.Width = LATIME_CONTROL + 50;
            btnCalculeaza.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X - 90, 3 * DIMENSIUNE_PAS_Y + 30);
            btnCalculeaza.Text = "Vizualizare baza de date";
            btnCalculeaza.Click += but1;
            this.Controls.Add(btnCalculeaza);
            //adaugare medicament
            btnCalculeaza = new Button();
            btnCalculeaza.Width = LATIME_CONTROL + 50;
            btnCalculeaza.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X - 90, 3 * DIMENSIUNE_PAS_Y + 60);
            btnCalculeaza.Text = "Adaugare medicament";
            btnCalculeaza.Click += but2;
            this.Controls.Add(btnCalculeaza);
            //adaugare editare date medicament
            btnCalculeaza = new Button();
            btnCalculeaza.Width = LATIME_CONTROL + 50;
            btnCalculeaza.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X - 90, 3 * DIMENSIUNE_PAS_Y + 90);
            btnCalculeaza.Text = "Editare date medicament";
            btnCalculeaza.Click += but3;
            this.Controls.Add(btnCalculeaza);
            //adaugare stergere medicament
            btnCalculeaza = new Button();
            btnCalculeaza.Width = LATIME_CONTROL + 50;
            btnCalculeaza.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X - 90, 3 * DIMENSIUNE_PAS_Y + 120);
            btnCalculeaza.Text = "Stergere medicament";
            btnCalculeaza.Click += but4;
            this.Controls.Add(btnCalculeaza);
            //adaugare cautare medicament
            btnCalculeaza = new Button();
            btnCalculeaza.Width = LATIME_CONTROL + 50;
            btnCalculeaza.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X - 90, 3 * DIMENSIUNE_PAS_Y + 150);
            btnCalculeaza.Text = "Cautare medicament";
            btnCalculeaza.Click += but5;
            this.Controls.Add(btnCalculeaza);
            //label nume inlocuit
            nume_inlocuit = new Label();
            nume_inlocuit.Visible = false;
            nume_inlocuit.Width = LATIME_CONTROL;
            nume_inlocuit.Text = "Entitatea de editat";
            nume_inlocuit.TextAlign = ContentAlignment.MiddleCenter;
            nume_inlocuit.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X-40 , DIMENSIUNE_PAS_Y*3 + 180);
            this.Controls.Add(nume_inlocuit);
            //textbox nume inlocuit
            _nume_inlocuit = new TextBox();
            _nume_inlocuit.Visible = false;
            _nume_inlocuit.Width = LATIME_CONTROL;
            _nume_inlocuit.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X -40, DIMENSIUNE_PAS_Y * 3+ 210);
            this.Controls.Add(_nume_inlocuit);
            //label nume
            nume = new Label();
            nume.Visible = false;
            nume.Width = LATIME_CONTROL - 50;
            nume.Text = "Nume";
            nume.TextAlign = ContentAlignment.MiddleCenter;
            nume.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X * 2 + 25, DIMENSIUNE_PAS_Y * 5+65);
            this.Controls.Add(nume);
            //textbox nume
            _nume = new TextBox();
            _nume.Width = LATIME_CONTROL;
            _nume.Visible = false;
            _nume.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X * 2, DIMENSIUNE_PAS_Y * 5 + 95);
            this.Controls.Add(_nume);
            //label nr buc
            nr_buc = new Label();
            nr_buc.Visible = false;
            nr_buc.Width = LATIME_CONTROL - 40;
            nr_buc.Text = "Numar bucati";
            nr_buc.TextAlign = ContentAlignment.MiddleCenter;
            nr_buc.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X * 3 + 35, DIMENSIUNE_PAS_Y * 5+65);
            this.Controls.Add(nr_buc);
            //textbox nr buc
            _nr_buc = new TextBox();
            _nr_buc.Visible = false;
            _nr_buc.Width = LATIME_CONTROL - 20;
            _nr_buc.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X * 3 + 25, DIMENSIUNE_PAS_Y * 5 + 95);
            this.Controls.Add(_nr_buc);
            //label pret
            pret = new Label();
            pret.Visible = false;
            pret.Width = LATIME_CONTROL - 50;
            pret.Text = "Pret(lei)";
            pret.TextAlign = ContentAlignment.MiddleCenter;
            pret.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X * 2 + 25, DIMENSIUNE_PAS_Y * 7+65);
            this.Controls.Add(pret);
            //textbox pret
            _pret = new TextBox();
            _pret.Visible = false;
            _pret.Width = LATIME_CONTROL - 20;
            _pret.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X * 2 + 10, DIMENSIUNE_PAS_Y * 7 + 95);
            this.Controls.Add(_pret);
            //buton adaugare
            adauga = new Button();
            adauga.Width = LATIME_CONTROL;
            adauga.Height = LATIME_CONTROL / 2;
            adauga.Visible = false;
            adauga.Text = "Adauga";
            adauga.TextAlign = ContentAlignment.MiddleCenter;
            adauga.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X * 3 + 25, DIMENSIUNE_PAS_Y * 7+65);
            adauga.Click += buta;
            this.Controls.Add(adauga);
            //buton stergere
            sterge = new Button();
            sterge.Width = LATIME_CONTROL;
            sterge.Height = LATIME_CONTROL / 2;
            sterge.Visible = false;
            sterge.Text = "Sterge";
            sterge.TextAlign = ContentAlignment.MiddleCenter;
            sterge.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X * 3 + 25, DIMENSIUNE_PAS_Y * 7 + 65);
            sterge.Click += buts;
            this.Controls.Add(sterge);
            //buton editare
            editare = new Button();
            editare.Width = LATIME_CONTROL;
            editare.Height = LATIME_CONTROL / 2;
            editare.Visible = false;
            editare.Text = "Editare";
            editare.TextAlign = ContentAlignment.MiddleCenter;
            editare.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X * 3 + 25, DIMENSIUNE_PAS_Y * 7 + 65);
            editare.Click += bute;
            this.Controls.Add(editare);
            //buton cautare
            cauta = new Button();
            cauta.Width = LATIME_CONTROL;
            cauta.Height = LATIME_CONTROL / 2;
            cauta.Visible = false;
            cauta.Text = "Cauta";
            cauta.TextAlign = ContentAlignment.MiddleCenter;
            cauta.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X * 3 + 25, DIMENSIUNE_PAS_Y * 7 + 65);
            cauta.Click += butc;
            this.Controls.Add(cauta);
            //combobox editare
            this.SizeChanged += OnFormSizeChanged;
            this.FormClosed += OnFormClosed;
        }
        private void but1(object sender, EventArgs e)
        {
            nume.Visible = false;
            _nume.Visible = false;
            nr_buc.Visible = false;
            _nr_buc.Visible = false;
            pret.Visible = false;
            _pret.Visible = false;
            adauga.Visible = false;
            data.Visible = true;
            sterge.Visible = false;
            editare.Visible = false;
            nume_inlocuit.Visible = false;
            _nume_inlocuit.Visible= false;
            cauta.Visible = false;
            _nume.Clear();
            _nr_buc.Clear();
            _pret.Clear();
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
        private void buta(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Tabel values('" + _nume.Text + "','" + _nr_buc.Text + "','" + _pret.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Valorile au fost introduse");
            _nume.Clear();
            _nr_buc.Clear();
            _pret.Clear();
        }
        private void but2(object sender, EventArgs e)
        {
            continut.Visible = false;
            nume.Visible = true;
            _nume.Visible = true;
            nr_buc.Visible = true;
            _nr_buc.Visible = true;
            pret.Visible = true;
            _pret.Visible= true;
            adauga.Visible = true;
            data.Visible = true;
            sterge.Visible = false;
            editare.Visible = false;
            nume_inlocuit.Visible = false;
            _nume_inlocuit.Visible = false;
            cauta.Visible = false;
            _nume.Clear();
            _nr_buc.Clear();
            _pret.Clear();
        }
        private void but3(object sender, EventArgs e)
        {
            continut.Visible = false;
            nume.Visible = true;
            _nume.Visible = true;
            nr_buc.Visible = true;
            _nr_buc.Visible = true;
            pret.Visible = true;
            _pret.Visible = true;
            adauga.Visible = false;
            data.Visible = true;
            sterge.Visible = false;
            editare.Visible = true;
            nume_inlocuit.Visible = true;
            _nume_inlocuit.Visible = true;
            cauta.Visible = false;
            _nume.Clear();
            _nr_buc.Clear();
            _pret.Clear();

        }
        private void bute(object sender,EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update Tabel set nume='" + _nume.Text  + "',nr_buc='"+_nr_buc.Text+ "',pret='" + _pret.Text + "' where nume='" + _nume_inlocuit.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Entitatea a fost editata");
            _nume.Clear();
            _nr_buc.Clear();
            _pret.Clear();
            _nume_inlocuit.Clear();
        }
        private void but4(object sender, EventArgs e)
        {
            nume.Visible = true;
            _nume.Visible = true;
            sterge.Visible = true;
            cauta.Visible = false;
            nr_buc.Visible = false;
            _nr_buc.Visible = false;
            pret.Visible = false;
            _pret.Visible = false;
            adauga.Visible = false;
            data.Visible = true;
            sterge.Visible = true;
            editare.Visible = false;
            nume_inlocuit.Visible = false;
            _nume_inlocuit.Visible = false;
            _nume.Clear();
            _nr_buc.Clear();
            _pret.Clear();
        }
        private void buts(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "DELETE from Tabel where nume = '"+_nume.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Entitatea a fost stearsa");
            _nume.Clear();
            _nr_buc.Clear();
            _pret.Clear();
        }
        private void but5(object sender, EventArgs e)
        {
            nume.Visible = true;
            _nume.Visible = true;
            nr_buc.Visible = false;
            _nr_buc.Visible = false;
            pret.Visible = false;
            _pret.Visible = false;
            adauga.Visible = false;
            data.Visible = true;
            sterge.Visible = false;
            editare.Visible = false;
            nume_inlocuit.Visible = false;
            _nume_inlocuit.Visible = false;
            cauta.Visible = true;
            _nume.Clear();
            _nr_buc.Clear();
            _pret.Clear();
        }
        private void butc(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Tabel where nume='"+_nume.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            data.DataSource = dt;
            con.Close();
            _nume.Clear();
        }
        private void OnFormSizeChanged(object sender, EventArgs e)
        {
            //obiectul *sender* este AppForm1
            //*e* reprezinta o lista de valori care se transmit la invocarea evenimentului SizeChanged al clasei AppForm1 catre subscriber-ul curent care este tot forma AppForm1 
            this.Text = "Latime=" + this.Width + " Inaltime= " + this.Height;
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void AppForm1_Load(object sender, EventArgs e)
        {

        }
    }
    class Program
    {
        [STAThread]
        static void Main()
        {
            AppForm1 form1 = new AppForm1();
            Farmacie_lab8 form2 = new Farmacie_lab8();
            form1.Show();
            form2.Show();
            Application.Run();
            Medicament m = new Medicament();
            string x;
            do
            {
                Console.Clear();
                Console.WriteLine("1.Afisare baza de date");
                Console.WriteLine("2.Adaugare medicament");
                Console.WriteLine("3.Editare detalii medicament");
                Console.WriteLine("4.Stergere medicament");
                Console.WriteLine("5.Cautare medicament");
                Console.WriteLine("6.Iesire din program");
                Console.WriteLine("Optiunea dvs:");
                x = Console.ReadLine();
                switch (x)
                {
                    case "1":
                        m.citire_bdd();
                        break;
                    case "2":
                        m.scrie_bdd();
                        break;
                    case "3":
                        m.editeaza_bdd();
                        break;
                    case "4":
                        m.sterge_bdd();
                        break;
                    case "5":
                        m.cauta_bbd();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Comanda inexistenta");
                        break;
                }
                Console.ReadLine();
            
            } while (true);
        }
    }
}
