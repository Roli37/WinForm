using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ComboBoxes(Szerelonevek(OpenConnection()), Megrendelonevek(OpenConnection()));
        }
        private void btn_kuldes_Click(object sender, EventArgs e)
        {
            Insert(OpenConnection());
        }

        public void Insert(IDbConnection connection)
        {
            DateTime datum = dateTimePicker1.Value.Date;
            if (datum < DateTime.Now)
            {
                string message = "Nem adhatsz meg már elmúlt dátumot!";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
            else
            {
                string szereloid = SzereloID(OpenConnection());
                string megrendeloid = MegrendeloID(OpenConnection());
                int javido = int.Parse(comboBox3.SelectedItem.ToString());

                using var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO karbantartasok (szerelo_id, megrendelo_id, datum, javido) VALUES (@id, @id2, @datum, @javido)";

                var param = command.CreateParameter();
                param.ParameterName = "@id";
                param.Value = szereloid;

                var param2 = command.CreateParameter();
                param2.ParameterName = "@id2";
                param2.Value = megrendeloid;

                var param3 = command.CreateParameter();
                param3.ParameterName = "@datum";
                param3.Value = datum;

                var param4 = command.CreateParameter();
                param4.ParameterName = "@javido";
                param4.Value = javido;

                command.Parameters.Add(param);
                command.Parameters.Add(param2);
                command.Parameters.Add(param3);
                command.Parameters.Add(param4);
                command.ExecuteNonQuery();
            }

        }
        public string SzereloID(IDbConnection connection)
        {
            using var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT DISTINCT szerelok.szerelo_id " +
                "FROM szerelok " +
                "WHERE szerelok.nev like @Name";
            var param = command.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = comboBox1.SelectedItem.ToString();
            command.Parameters.Add(param);
            using var reader = command.ExecuteReader();
            reader.Read();
            string result = reader["szerelo_id"].ToString();
            reader.Close();
            return result;
        }
        public string MegrendeloID(IDbConnection connection)
        {
            using var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT DISTINCT megrendelok.megrendelo_id " +
                "FROM megrendelok " +
                "WHERE megrendelok.nev like @Name";
            var param = command.CreateParameter();
            param.ParameterName = "@Name";
            param.Value = comboBox2.SelectedItem.ToString();
            command.Parameters.Add(param);
            using var reader = command.ExecuteReader();
            reader.Read();
            string result = reader["megrendelo_id"].ToString();
            reader.Close();
            return result;
        }
        public void ComboBoxes(List<string> szerelonevek, List<string> megrendelonevek)
        {
            comboBox1.DataSource = szerelonevek;
            comboBox2.DataSource = megrendelonevek;
        }
        public List<string> Szerelonevek (IDbConnection connection)
        {
            using var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT DISTINCT szerelok.nev as 'Szerelő nevek' FROM `szerelok`";
            using var reader = command.ExecuteReader();
            List<string> szerelok = new List<string>();
            while(reader.Read())
            {
                szerelok.Add((string)reader["Szerelő nevek"]);
            }
            return szerelok;
        }
        public List<string> Megrendelonevek (IDbConnection connection)
        {
            using var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT DISTINCT megrendelok.nev as 'Megrendelő nevek' FROM `megrendelok`";
            using var reader = command.ExecuteReader();
            List<string> megrendelok = new List<string>();
            while(reader.Read())
            {
                megrendelok.Add((string)reader["Megrendelő nevek"]);
            }
            return megrendelok;
        }

        public IDbConnection OpenConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "karbantarto";
            builder.Password = "";
            builder.AllowUserVariables = true;
            IDbConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();
            return connection;
        }

    }
}
