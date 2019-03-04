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
    public partial class AddMovie : Form
    {
        ConectionStr str = new ConectionStr();
        public AddMovie()
        {
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

        private void AddMovie_Load(object sender, EventArgs e)
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
                country.Items.Add(Convert.ToString(reader.GetValue(0)));
            reader.Close();
            command = new NpgsqlCommand("SELECT \"IndexRestrictions\" FROM \"AgeRestrictions\"", Conection);
            reader = command.ExecuteReader();
            while (reader.Read())
                restriction.Items.Add(Convert.ToString(reader.GetValue(0)));
            reader.Close();
            command = new NpgsqlCommand("SELECT \"NameHall\" FROM \"Hall\"", Conection);
            reader = command.ExecuteReader();
            while (reader.Read())
                hall.Items.Add(Convert.ToString(reader.GetValue(0)));
            reader.Close();
            #endregion
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void AddRec_Click(object sender, EventArgs e)
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
                if (control is DateTimePicker)
                {
                    DateTimePicker dp = control as DateTimePicker;
                    if (dp.Value.Date <= DateTime.Now)
                    {
                        MessageBox.Show("Некорректные данные!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            Logical.Movie movie = new Logical.Movie();
            if (movie.CheckForAdd(Genre.SelectedIndex + 1, country.SelectedIndex + 1, name_movie.Text))
            {
                movie.Add(Genre.SelectedIndex + 1, country.SelectedIndex + 1, Convert.ToInt32(duration.Text), restriction.SelectedIndex + 1, name_movie.Text, hall.SelectedIndex + 1, Convert.ToInt32(price.Text), dateTimePicker1.Value.Date);
                MessageBox.Show("Данные успешно занесены в БД!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Такой фильм уже есть в БД!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #region Очистка формы после добавления
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
    }
}