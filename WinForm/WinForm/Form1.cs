using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinForm
{
    public partial class Form1 : Form
    {
        private Figyelmeztet _figyelmeztet = new Figyelmeztet();

        public Form1()
        {
            InitializeComponent();
        }
        public class Adat
        {
            public string Megrendelo_neve { get; set; }
            public string Megrendelo_cime { get; set; }
            public string Munka_tipusa { get; set; }
            public string Megrendelo_telefonszama { get; set; }
            public string Szerelo_neve { get; set; }
            public DateTime Karbantartas_datuma { get; set; }

            public string Karbantartas_ara { get; set; }
        }
        public class Figyelmeztet : INotifyPropertyChanged
        {
            private string str ;

            public string Str
            {
                get { return str ; }
                set 
                {
                    str = value;
                    OnPropertyChanged("Str");
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;


            private void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
        private void btn_megjelenit_Click(object sender, EventArgs e)
        {
            Megjelenit(AllData(OpenConnection()));
        }
        private void btn_exportal_Click(object sender, EventArgs e)
        {
            Exportal(AllData(OpenConnection()));
            Warning();
        }

        private void btn_szures_Click(object sender, EventArgs e)
        {
            Megjelenit(FilteredData(AllData(OpenConnection())));
        }
        private void btn_ujadat_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void btn_ujadat_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Arial", 15, FontStyle.Bold);
            Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(10, 0);
            e.Graphics.RotateTransform(36);
            e.Graphics.DrawString("Új karbantartás felvétele", font, brush, 0, 0);
        }
        public void Megjelenit(List<Adat> data)
        {
            bindingSourceAllData.DataSource = data;
            dataGridView2.DataSource = bindingSourceAllData;
            dataGridView2.Visible = true;
        }
        public void Exportal(List<Adat> alldata)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string filename = Path.Combine(
                folderBrowserDialog1.SelectedPath,
                $"karbantartasok_{DateTime.Now:yyyy-MM-dd_HH-mm}.csv");

            File.WriteAllLines(filename,
                alldata.Select(x => String.Join(";",
                    x.Megrendelo_neve,
                    x.Megrendelo_cime,
                    x.Munka_tipusa,
                    x.Megrendelo_telefonszama,
                    x.Szerelo_neve,
                    x.Karbantartas_datuma,
                    x.Karbantartas_ara))
                );
        }
        public void Warning()
        {
            lb_valtozott.DataBindings.Add("", _figyelmeztet, "Str", true, DataSourceUpdateMode.OnPropertyChanged);
            _figyelmeztet.Str = "A fájl felül lett írva";
            lb_valtozott.Text = _figyelmeztet.Str;
        }
        public List<Adat> FilteredData(List<Adat> AllData)
        {
            List<Adat> lista2 = new List<Adat>();
            if (tb_nev.Text == "" || tb_ar.Text == "")
            {
                string message = "Írj be egy szerelő nevet és egy árat!";
                string title = "Warning";
                MessageBox.Show(message, title);
                return lista2;
            }
            string nev = tb_nev.Text;
            int ar = int.Parse(tb_ar.Text);
            List<Adat> lista = new List<Adat>();
            foreach (var item in AllData)
            {
                item.Karbantartas_ara = new String(item.Karbantartas_ara.Where(Char.IsDigit).ToArray());
                lista.Add(item);
            }
            if ((AllData.Any(x => x.Szerelo_neve == nev) == true) && (ar > 5000 && ar % 1000 == 0))
            {
                lista2 = lista.Where(x => x.Szerelo_neve == nev).Where(x => int.Parse(x.Karbantartas_ara) > ar).OrderBy(x => int.Parse(x.Karbantartas_ara)).ToList();
            }
            else
            {
                string message = "Csak olyan szerelőt adhatsz meg, aki már fent van a listán! Csak 5000-nél nagyobb, és 1000-el osztható számot adhatsz meg!";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
            return lista2;
        }

        public List<Adat> AllData(IDbConnection connection)
        {
            using var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT megrendelok.nev as 'Név', " +
                "megrendelok.cim as 'Cím', " +
                "szakteruletek.megnevezes as 'Munka típusa', " +
                "megrendelok.telefon as 'Telefonszám', " +
                "szerelok.nev as 'Szerelő neve', " +
                "karbantartasok.datum as 'Dátum', " +
                "CONCAT(FORMAT((karbantartasok.javido*szerelok.oradij*(100-megrendelok.kedvezmeny)/100), '#,#'), ' Ft') as 'Ár' " +
                "FROM karbantartasok " +
                "INNER JOIN megrendelok on karbantartasok.megrendelo_id = megrendelok.megrendelo_id " +
                "INNER JOIN szerelok on karbantartasok.szerelo_id = szerelok.szerelo_id " +
                "INNER JOIN szakteruletek on szerelok.szakterulet_id = szakteruletek.szakterulet_id " +
                "ORDER BY szerelok.nev ASC, karbantartasok.datum ASC";

            using var reader = command.ExecuteReader();
            List<Adat> adatok = new List<Adat>();
            while (reader.Read())
            {
                Adat adat = new Adat()
                {
                    Megrendelo_neve = (string)reader["Név"],
                    Megrendelo_cime = (string)reader["Cím"],
                    Munka_tipusa = (string)reader["Munka típusa"],
                    Megrendelo_telefonszama = (string)reader["Telefonszám"],
                    Szerelo_neve = (string)reader["Szerelő neve"],
                    Karbantartas_datuma = (DateTime)reader["Dátum"],
                    Karbantartas_ara = (string)reader["Ár"]
                };
                adatok.Add(adat);
            }
            return adatok;
        }
        public IDbConnection OpenConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "karbantarto";
            builder.Password = "";
            IDbConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            return connection;
        }

    }
}
