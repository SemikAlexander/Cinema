using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Choise : Form
    {
        string load;
        int ID;
        Logical.Ticket ticket = new Logical.Ticket();
        Logical.Movie movies = new Logical.Movie();
        AddMovie add_movie = new AddMovie();
        AddTicket add_ticket = new AddTicket();
        public Choise(string LoadForm, int index)
        {
            load = LoadForm;
            ID = index;
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ticket_Click(object sender, EventArgs e)
        {
            switch (load)
            {
                case "add":
                    this.Hide();
                    add_ticket.Show();
                    break;
                case "edit":
                    if (ID == 0)
                    {
                        int index = ticket.IDRecord();
                        if (ticket.Check(index))
                        {
                            EditTicket edit_ticket = new EditTicket(index);
                            this.Hide();
                            edit_ticket.Show();
                        }
                        else
                        {
                            MessageBox.Show("Таблица пуста!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            return;
                        }
                        this.Hide();
                    }
                    else
                        if (ticket.Check(ID))
                        {
                            EditTicket edit_ticket = new EditTicket(ID);
                            this.Hide();
                            edit_ticket.Show();
                        }
                        else
                        {
                            MessageBox.Show("В БД нет билета с таким индексом!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            return;
                        }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (load)
            {
                case "add":
                    this.Hide();
                    add_movie.Show();
                    break;
                case "edit":
                    if (ID == 0)
                    {
                        int index = movies.IDRecord();
                        if (movies.CheckForEdit(index))
                        {
                            EditMovie edit_movie = new EditMovie(index);
                            this.Hide();
                            edit_movie.Show();
                        }
                        else
                        {
                            MessageBox.Show("Таблица пуста!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        this.Hide();
                    }
                    else
                        if (movies.CheckForEdit(ID))
                        {
                            EditMovie edit_movie = new EditMovie(ID);
                            this.Hide();
                            edit_movie.Show();
                        }
                        else
                        {
                            MessageBox.Show("В БД нет билета с таким индексом!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    break;
            }
        }
    }
}