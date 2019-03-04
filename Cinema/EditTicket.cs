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
    public partial class EditTicket : Form
    {
        ConectionStr str = new ConectionStr();
        int id_movie = 0, ID = 0;
        public EditTicket(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void EditTicket_Load(object sender, EventArgs e)
        {
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand("SELECT \"NameMovie\" FROM \"Movies\"", Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                movies.Items.Add(Convert.ToString(reader.GetValue(0)));
            reader.Close();
            Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            command = new NpgsqlCommand(String.Format("SELECT * FROM \"Tickets\" WHERE \"IDTicket\"= {0}", ID), Conection);
            reader = command.ExecuteReader();
            reader.Read();
            NameVisitor.Text = (string)reader.GetValue(1);
            int index = (int)reader.GetValue(4);
            dateTimePicker1.Value = (DateTime)reader.GetValue(6);
            reader.Close();
            command = new NpgsqlCommand(String.Format("SELECT \"NameMovie\" FROM \"Movies\" WHERE \"IDMovie\"={0}", index), Conection);
            reader = command.ExecuteReader();
            reader.Read();
            movies.SelectedItem = (string)reader.GetValue(0);
            reader.Close();
            command = new NpgsqlCommand(String.Format("SELECT \"Place\" FROM \"Tickets\" WHERE \"VisitorMovie\"={0}", index), Conection);
            reader = command.ExecuteReader();
            reader.Read();
            Place.Text = Convert.ToString(reader.GetInt32(0));
            reader.Close();
        }

        private void NameVisitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' | l > 'я') & l != '\b' & l != '.' & l != 32)
            {
                e.Handled = true;
            }
        }

        private void movies_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> using_places = new List<int>();
            Place.Text = "";
            #region Обновляем кнопки
            foreach (Control control in this.panel1.Controls)
            {
                if (control is Button)
                {
                    Button b = control as Button;
                    if (b.BackColor == Color.LightSalmon)
                    {
                        b.BackColor = Color.Silver;
                    }
                }
            }
            #endregion
            #region Обновляем форму при выборе фильма
            string sel_movie = movies.SelectedItem.ToString();
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            string find = "SELECT \"IDMovie\" FROM \"Movies\" WHERE \"NameMovie\"='" + sel_movie + "'";
            var command = new NpgsqlCommand(find, Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            reader.Read();
            id_movie = (int)reader.GetValue(0);
            reader.Close();
            find = "SELECT \"UsingHall\", \"PriceMovie\" FROM \"Session\" WHERE \"WhatMovie\"=" + id_movie;
            command = new NpgsqlCommand(find, Conection);
            reader = command.ExecuteReader();
            reader.Read();
            int UsingHall = (int)reader.GetValue(0);
            int Price = (int)reader.GetValue(1);
            reader.Close();
            Hall.Text = Convert.ToString(UsingHall);
            price.Text = Convert.ToString(Price);
            Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            find = "SELECT \"Place\" FROM \"Tickets\" WHERE \"VisitorMovie\"=" + id_movie;
            command = new NpgsqlCommand(find, Conection);
            reader = command.ExecuteReader();
            while (reader.Read())
                using_places.Add((int)reader.GetValue(0));
            reader.Close();
            foreach (Control control in this.panel1.Controls)
            {
                if (control is Button)
                {
                    Button b = control as Button;
                    for (int i = 0; i < using_places.Count; i++)
                    {
                        if (Convert.ToInt32(b.Text) == using_places[i])
                        {
                            b.BackColor = Color.LightSalmon;
                            b.Enabled = false;
                        }
                    }
                }
            }
            command = new NpgsqlCommand(String.Format("SELECT \"Date\" FROM \"Session\" WHERE \"WhatMovie\"={0}", id_movie), Conection);
            reader = command.ExecuteReader();
            reader.Read();
            dateTimePicker1.Value = (DateTime)reader.GetValue(0);
            reader.Close();
            #endregion
        }

        private void AddRec_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Дата некорректна!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (NameVisitor.Text.Trim() == "" | movies.SelectedItem == null | Place.Text.Trim() == "")
            {
                MessageBox.Show("Вы не ввели некоторые данные!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Logical.Ticket ticket = new Logical.Ticket();
                ticket.Edit(ID, NameVisitor.Text, Convert.ToInt32(Place.Text), Convert.ToInt32(price.Text), id_movie, Convert.ToInt32(Hall.Text), dateTimePicker1.Value.Date);
                MessageBox.Show("Данные успешно занесены в БД!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox t = control as TextBox;
                        t.Clear();
                    }
                    if (control is CheckBox)
                    {
                        ComboBox cb = control as ComboBox;
                        cb.SelectedItem = null;
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #region Работа с кнопками
        private void button1_Click_1(object sender, EventArgs e)
        {
            Place.Text = button1.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Place.Text = button2.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Place.Text = button3.Text;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Place.Text = button4.Text;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Place.Text = button5.Text;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Place.Text = button6.Text;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Place.Text = button7.Text;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Place.Text = button8.Text;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Place.Text = button9.Text;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Place.Text = button10.Text;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Place.Text = button11.Text;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Place.Text = button12.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Place.Text = button24.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Place.Text = button23.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Place.Text = button22.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Place.Text = button21.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Place.Text = button20.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Place.Text = button19.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Place.Text = button18.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Place.Text = button17.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Place.Text = button16.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Place.Text = button15.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Place.Text = button14.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Place.Text = button13.Text;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Place.Text = button36.Text;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Place.Text = button35.Text;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Place.Text = button34.Text;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Place.Text = button33.Text;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Place.Text = button32.Text;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Place.Text = button31.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Place.Text = button30.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Place.Text = button29.Text;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Place.Text = button28.Text;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Place.Text = button27.Text;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Place.Text = button26.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Place.Text = button25.Text;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Place.Text = button48.Text;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Place.Text = button47.Text;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Place.Text = button46.Text;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Place.Text = button45.Text;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Place.Text = button44.Text;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Place.Text = button43.Text;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Place.Text = button42.Text;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Place.Text = button41.Text;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Place.Text = button40.Text;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Place.Text = button39.Text;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Place.Text = button38.Text;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Place.Text = button37.Text;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            Place.Text = button60.Text;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            Place.Text = button59.Text;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            Place.Text = button58.Text;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Place.Text = button57.Text;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Place.Text = button56.Text;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Place.Text = button55.Text;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Place.Text = button54.Text;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Place.Text = button53.Text;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Place.Text = button52.Text;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Place.Text = button51.Text;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Place.Text = button50.Text;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Place.Text = button49.Text;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            Place.Text = button72.Text;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            Place.Text = button71.Text;
        }

        private void button70_Click(object sender, EventArgs e)
        {
            Place.Text = button70.Text;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            Place.Text = button69.Text;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            Place.Text = button68.Text;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            Place.Text = button67.Text;
        }

        private void button66_Click(object sender, EventArgs e)
        {
            Place.Text = button66.Text;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Place.Text = button65.Text;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Place.Text = button64.Text;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            Place.Text = button63.Text;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            Place.Text = button62.Text;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            Place.Text = button61.Text;
        }

        private void button84_Click(object sender, EventArgs e)
        {
            Place.Text = button84.Text;
        }

        private void button83_Click(object sender, EventArgs e)
        {
            Place.Text = button83.Text;
        }

        private void button82_Click(object sender, EventArgs e)
        {
            Place.Text = button82.Text;
        }

        private void button81_Click(object sender, EventArgs e)
        {
            Place.Text = button81.Text;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            Place.Text = button80.Text;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            Place.Text = button79.Text;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            Place.Text = button78.Text;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            Place.Text = button77.Text;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            Place.Text = button76.Text;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            Place.Text = button75.Text;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            Place.Text = button74.Text;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            Place.Text = button73.Text;
        }
        #endregion
    }
}