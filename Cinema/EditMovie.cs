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
    public partial class EditMovie : Form
    {
        ConectionStr str = new ConectionStr();
        Logical.Movie movies = new Logical.Movie();
        int index_movie;
        public EditMovie(int ID)
        {
            index_movie = ID;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void EditRec_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox t = control as TextBox;
                    if (t.Text.Trim() == "")
                    {
                        MessageBox.Show("Заполните все поля", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (t.Name == "price")
                        if (Convert.ToInt32(t.Text) < 150 & Convert.ToInt32(t.Text) > 3000)
                        {
                            MessageBox.Show("Некорректные данные!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            t.Clear();
                            return;
                        }
                    if (t.Name == "duration")
                        if (Convert.ToInt32(t.Text) < 45 & Convert.ToInt32(t.Text) > 150)
                        {
                            MessageBox.Show("Некорректные данные!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            t.Clear();
                            return;
                        }
                }
                if (control is CheckBox)
                {
                    ComboBox cb = control as ComboBox;
                    if (cb.SelectedItem == null)
                    {
                        MessageBox.Show("Заполните все поля", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            movies.Edit(index_movie, Genre.SelectedIndex + 1, Country.SelectedIndex + 1, Convert.ToInt32(Duration.Text), AgeRestrictions.SelectedIndex + 1, Name_Movie.Text, Hall.SelectedIndex + 1, Convert.ToInt32(Price.Text));
            MessageBox.Show("Данные успешно занесены в БД!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            #region Очистка формы после изменения данных
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox t = control as TextBox;
                    t.Text = "";
                }
                if (control is CheckBox)
                {
                    ComboBox cb = control as ComboBox;
                    cb.SelectedItem = null;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker dp = control as DateTimePicker;
                    dp.Value = DateTime.Now;
                }
            }
            #endregion
        }

        private void EditMovie_Load(object sender, EventArgs e)
        {
            #region Загрузка данных  combobox из БД
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand("SELECT \"NameGenre\" FROM \"Genre\"", Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Genre.Items.Add(Convert.ToString(reader.GetValue(0)));
            reader.Close();
            command = new NpgsqlCommand("SELECT \"NameCountry\" FROM \"Country\"", Conection);
            reader = command.ExecuteReader();
            while (reader.Read())
                Country.Items.Add(Convert.ToString(reader.GetValue(0)));
            reader.Close();
            command = new NpgsqlCommand("SELECT \"IndexRestrictions\" FROM \"AgeRestrictions\"", Conection);
            reader = command.ExecuteReader();
            while (reader.Read())
                AgeRestrictions.Items.Add(Convert.ToString(reader.GetValue(0)));
            reader.Close();
            command = new NpgsqlCommand("SELECT \"NameHall\" FROM \"Hall\"", Conection);
            reader = command.ExecuteReader();
            while (reader.Read())
                Hall.Items.Add(Convert.ToString(reader.GetValue(0)));
            reader.Close();
            #endregion
            #region Выгрузка изменяемых данных
            command = new NpgsqlCommand(String.Format("SELECT \"Genre\", \"Country\", \"Duration\", \"NameMovie\", \"AgeRestrictions\"  FROM \"Movies\" WHERE \"IDMovie\"={0}", index_movie), Conection);
            reader = command.ExecuteReader();
            reader.Read();
            Genre.SelectedIndex = (int)reader.GetValue(0) - 1;
            Country.SelectedIndex = (int)reader.GetValue(1) - 1;
            Duration.Text = Convert.ToString((int)reader.GetValue(2));
            Name_Movie.Text = (String)reader.GetValue(3);
            AgeRestrictions.SelectedIndex = (int)reader.GetValue(4) - 1;
            reader.Close();
            command = new NpgsqlCommand(String.Format("SELECT \"UsingHall\", \"PriceMovie\" FROM \"Session\" WHERE \"WhatMovie\"={0}", index_movie), Conection);
            reader = command.ExecuteReader();
            reader.Read();
            Hall.SelectedIndex = (int)reader.GetValue(0) - 1;
            Price.Text = Convert.ToString((int)reader.GetValue(1));
            reader.Close();
            #endregion
        }

        private void Duration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}