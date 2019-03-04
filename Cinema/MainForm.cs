using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Cinema
{
    public partial class MainForm : Form
    {
        ConectionStr str = new ConectionStr();
        Logical.Ticket work_with_tickets = new Logical.Ticket();
        Logical.Movie work_with_movies = new Logical.Movie();
        string table = "", type_value = "";
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddRecord_Click_1(object sender, EventArgs e)
        {
            add.BackColor = Color.Crimson;
            edit.BackColor = stat.BackColor = find.BackColor = Color.Gray;
            Choise choise = new Choise("add", 0);
            choise.Show();
        }

        private void EditRecord_Click_1(object sender, EventArgs e)
        {
            edit.BackColor = Color.Crimson;
            add.BackColor = stat.BackColor = find.BackColor = Color.Gray;
            if (ID.Text == "")
                ID.Text = "0";
            Choise choise = new Choise("edit", Convert.ToInt32(ID.Text));
            choise.Show();
        }

        private void Statistics_Click_1(object sender, EventArgs e)
        {
            stat.BackColor = Color.Crimson;
            add.BackColor = edit.BackColor = find.BackColor = Color.Gray;
            Statistics statistic = new Statistics();
            statistic.Show();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string table_for_find = "", where = "", value = "";
            if (Type.SelectedItem != null & Data.Text.Trim() != "")
            {
                switch (table)
                {
                    case "Movies":
                        table_for_find = table;
                        where = work_with_movies.values_for_delete_movie[Type.SelectedIndex];
                        value = Data.Text;
                        MainTable.Rows.Clear();
                        var ConectionMovie = new NpgsqlConnection(str.Con);
                        ConectionMovie.Open();
                        var commandMovie = new NpgsqlCommand(String.Format("SELECT * FROM \"{0}\" INNER JOIN \"Country\" ON (\"Movies\".\"Country\" = \"Country\".\"IDCountry\") INNER JOIN \"Genre\" ON (\"Movies\".\"Genre\" = \"Genre\".\"IDGenre\") INNER JOIN \"AgeRestrictions\" ON (\"Movies\".\"AgeRestrictions\" = \"AgeRestrictions\".\"IDRestrictions\") WHERE \"{1}\"='{2}'", table_for_find, where, value), ConectionMovie);
                        NpgsqlDataReader readerMovie = commandMovie.ExecuteReader();
                        while (readerMovie.Read())
                            MainTable.Rows.Add(readerMovie.GetInt32(4), readerMovie.GetString(5), readerMovie.GetInt32(2), readerMovie.GetString(9) + " [" + readerMovie.GetInt32(8) + "]", readerMovie.GetString(7) + " [" + readerMovie.GetInt32(6) + "]", readerMovie.GetString(11) + " [" + readerMovie.GetInt32(10) + "]");
                        readerMovie.Close();
                        ConectionMovie.Close();
                        break;
                    case "Tickets":
                        table_for_find = table;
                        where = work_with_tickets.values_for_delete_ticket[Type.SelectedIndex];
                        value = Data.Text;
                        MainTable.Rows.Clear();
                        var ConectionTickets = new NpgsqlConnection(str.Con);
                        ConectionTickets.Open();
                        var commandTickets = new NpgsqlCommand(String.Format("SELECT * FROM \"{0}\" INNER JOIN \"Movies\" ON (\"Tickets\".\"VisitorMovie\" = \"Movies\".\"IDMovie\") INNER JOIN \"Hall\" ON (\"Tickets\".\"Hall\" = \"Hall\".\"IDHall\") INNER JOIN \"Place\" ON (\"Tickets\".\"Place\" = \"Place\".\"Place\") WHERE \"{1}\"='{2}'", table_for_find, where, value), ConectionTickets);
                        NpgsqlDataReader readerTickets = commandTickets.ExecuteReader();
                        while (readerTickets.Read())
                            MainTable.Rows.Add(readerTickets.GetInt32(0), readerTickets.GetString(1), readerTickets.GetInt32(15), readerTickets.GetInt32(2), readerTickets.GetInt32(3), readerTickets.GetString(12) + " [" + readerTickets.GetInt32(4) + "]", readerTickets.GetString(14) + " [" + readerTickets.GetInt32(13) + "]", readerTickets.GetDateTime(6));
                        readerTickets.Close();
                        ConectionTickets.Close();
                        break;
                }
                    
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MinWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadMoviesFromDB();
            table = "Movies";
        }
        private void tables_from_BD_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tables_from_BD.SelectedIndex)
            {
                case 0: ReadMoviesFromDB(); table = "Movies"; break;
                case 1: ReadTicketsFromDB(); table = "Tickets"; break;
                case 2: ReadGenreFromDB(); break;
                case 3: ReadCountryFromDB(); break;
                case 4: ReadHallFromDB(); break;
                case 5:ReadAgeRestrictionsFromDB(); break;
            }
        }
        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            switch (table)
            {
                case "Movies":
                    if (ID.Text.Trim() == "")
                    {
                        var Conection_Movie = new NpgsqlConnection(str.Con);
                        Conection_Movie.Open();
                        var command_movie = new NpgsqlCommand("SELECT \"IDMovie\" FROM \"Movies\"", Conection_Movie);
                        NpgsqlDataReader reader_movie = command_movie.ExecuteReader();
                        reader_movie.Read();
                        try
                        {
                            id = (int)reader_movie.GetValue(0);
                            reader_movie.Close();
                            Conection_Movie.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Таблица пуста!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    else
                        id = Convert.ToInt32(ID.Text);
                    work_with_movies.Delete(id);
                    ReadMoviesFromDB();
                    break;
                case "Tickets":
                    if (ID.Text.Trim() == "")
                    {
                        var Conection_Ticket = new NpgsqlConnection(str.Con);
                        Conection_Ticket.Open();
                        var command_ticket = new NpgsqlCommand("SELECT * FROM \"Tickets\"", Conection_Ticket);
                        NpgsqlDataReader reader_ticket = command_ticket.ExecuteReader();
                        reader_ticket.Read();
                        try
                        {
                            id = (int)reader_ticket.GetValue(0);
                            reader_ticket.Close();
                            Conection_Ticket.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Таблица пуста!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    else
                        id = Convert.ToInt32(ID.Text);
                    work_with_tickets.Delete(id);
                    ReadTicketsFromDB();
                    break;
            }
        }
        private void DeleteRow_Click(object sender, EventArgs e)
        {
            string table_for_delete = "", where = "", value = "";
            if (Type.SelectedItem != null & Data.Text.Trim() != "") 
            {
                switch (table)
                {
                    case "Movies":
                        table_for_delete = table;
                        where = work_with_movies.values_for_delete_movie[Type.SelectedIndex];
                        value = Data.Text;
                        break;
                    case "Tickets":
                        table_for_delete = table;
                        where = work_with_tickets.values_for_delete_ticket[Type.SelectedIndex];
                        value = Data.Text;
                        break;
                }
                var Conection = new NpgsqlConnection(str.Con);
                Conection.Open();
                var command = new NpgsqlCommand(String.Format("DELETE FROM \"{0}\" WHERE \"{1}\"='{2}'", table_for_delete, where, value), Conection);
                command.ExecuteNonQuery();
                Conection.Close();
                if (table == "Movies")
                    ReadMoviesFromDB();
                else
                    ReadTicketsFromDB();
            }
        }
        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (table)
            {
                case "Movies":
                    if (Type.SelectedIndex != 1)
                        type_value = "number";
                    Data.Visible = true;
                    break;
                case "Tickets":
                    if (Type.SelectedIndex != 1)
                        type_value = "number";
                    else
                        type_value = "string";
                    Data.Visible = true;
                    break;
            }
        }
        private void Data_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (table)
            {
                case "Movies":
                    if (type_value == "number")
                        if ((e.KeyChar < 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                            e.Handled = true;
                    break;
                case "Tickets":
                    if (type_value == "number")
                    {
                        if ((e.KeyChar < 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                            e.Handled = true;
                    }
                    else
                        if ((e.KeyChar < 'А' | e.KeyChar > 'я') & e.KeyChar != '\b' & e.KeyChar != '.' & e.KeyChar != 32)
                            e.Handled = true;
                    break;
            }
        }
        #region Выбор отображаемой таблицы на главной форме
        public void ReadMoviesFromDB()
        {
            Type.Items.Clear();
            string[] values = { "Код", "Название", "Длительность", "Жанр", "Страна", "Ограничения" };
            for (int i = 0; i < values.Length; i++)
                Type.Items.Add(values[i]);
            MainTable.Columns.Clear();
            MainTable.ColumnCount = 6;
            MainTable.Columns[0].Name = values[0];
            MainTable.Columns[1].Name = values[1];
            MainTable.Columns[2].Name = values[2];
            MainTable.Columns[3].Name = values[3];
            MainTable.Columns[4].Name = values[4];
            MainTable.Columns[5].Name = values[5];
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand("SELECT * FROM \"Movies\" INNER JOIN \"Country\" ON (\"Movies\".\"Country\" = \"Country\".\"IDCountry\") INNER JOIN \"Genre\" ON (\"Movies\".\"Genre\" = \"Genre\".\"IDGenre\") INNER JOIN \"AgeRestrictions\" ON (\"Movies\".\"AgeRestrictions\" = \"AgeRestrictions\".\"IDRestrictions\")", Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MainTable.Rows.Add((int)reader.GetValue(4), (string)reader.GetValue(5), (int)reader.GetValue(2), (string)reader.GetValue(9) + " [" + (int)reader.GetValue(8) + "]", (string)reader.GetValue(7) + " [" + (int)reader.GetValue(6) + "]", (string)reader.GetValue(11) + " [" + (int)reader.GetValue(10) + "]");
            }
            reader.Close();
        }
        public void ReadTicketsFromDB()
        {
            Type.Items.Clear();
            string[] values = { "Код", "Имя", "Место", "Цена", "Фильм", "Зал" };
            for (int i = 0; i < values.Length; i++)
                Type.Items.Add(values[i]);
            MainTable.Columns.Clear();
            MainTable.ColumnCount = 8;
            MainTable.Columns[0].Name = "Код";
            MainTable.Columns[1].Name = "Имя";
            MainTable.Columns[2].Name = "Ряд";
            MainTable.Columns[3].Name = "Место";
            MainTable.Columns[4].Name = "Цена";
            MainTable.Columns[5].Name = "Фильм";
            MainTable.Columns[6].Name = "Зал";
            MainTable.Columns[7].Name = "Время";
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand("SELECT * FROM \"Tickets\" INNER JOIN \"Movies\" ON (\"Tickets\".\"VisitorMovie\" = \"Movies\".\"IDMovie\") INNER JOIN \"Hall\" ON (\"Tickets\".\"Hall\" = \"Hall\".\"IDHall\") INNER JOIN \"Place\" ON (\"Tickets\".\"Place\" = \"Place\".\"Place\")", Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MainTable.Rows.Add((int)reader.GetValue(0), (string)reader.GetValue(1), (int)reader.GetValue(15), (int)reader.GetValue(2), (int)reader.GetValue(3), (string)reader.GetValue(12) + " [" + (int)reader.GetValue(4) + "]", (string)reader.GetValue(14) + " [" + (int)reader.GetValue(13) + "]", (DateTime)reader.GetValue(6));
            }
            reader.Close();
        }
        public void ReadGenreFromDB()
        {
            MainTable.Columns.Clear();
            MainTable.ColumnCount = 2;
            MainTable.Columns[0].Name = "Код";
            MainTable.Columns[1].Name = "Название";
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand("SELECT * FROM \"Genre\"", Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MainTable.Rows.Add((int)reader.GetValue(0), (string)reader.GetValue(1));
            }
            reader.Close();
        }
        public void ReadCountryFromDB()
        {
            MainTable.Columns.Clear();
            MainTable.ColumnCount = 2;
            MainTable.Columns[0].Name = "Код";
            MainTable.Columns[1].Name = "Название";
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand("SELECT * FROM \"Country\"", Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MainTable.Rows.Add((int)reader.GetValue(0), (string)reader.GetValue(1));
            }
            reader.Close();
        }
        public void ReadHallFromDB()
        {
            MainTable.Columns.Clear();
            MainTable.ColumnCount = 2;
            MainTable.Columns[0].Name = "Код";
            MainTable.Columns[1].Name = "Название";
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand("SELECT * FROM \"Hall\"", Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MainTable.Rows.Add((int)reader.GetValue(0), (string)reader.GetValue(1));
            }
            reader.Close();
        }
        public void ReadAgeRestrictionsFromDB()
        {
            MainTable.Columns.Clear();
            MainTable.ColumnCount = 2;
            MainTable.Columns[0].Name = "Код";
            MainTable.Columns[1].Name = "Название";
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand("SELECT * FROM \"AgeRestrictions\"", Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MainTable.Rows.Add((int)reader.GetValue(0), (string)reader.GetValue(1));
            }
            reader.Close();
        }
        #endregion
    }
}