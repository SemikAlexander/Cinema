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
    public partial class Statistics : Form
    {
        struct Movies : IComparable
        {
            public int CompareTo(object obj)
            {
                Movies arr = (Movies)obj;
                return this.Count.CompareTo(arr.Count);
            }
            public int IDMovie, Count;
            public string Name;
        }
        ConectionStr str = new ConectionStr();
        public Statistics()
        {
            InitializeComponent();
        }

        private void MinWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            List<int> IDValue = new List<int>(), Count = new List<int>();
            List<string> NameValue = new List<string>();
            #region Статистика покупок билетов фильма
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand("SELECT \"IDMovie\", \"NameMovie\" FROM \"Movies\"", Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                IDValue.Add(reader.GetInt32(0));
                NameValue.Add(reader.GetString(1));

            }
            reader.Close();
            Movies [] Films = new Movies[IDValue.Count];
            for (int i = 0; i < IDValue.Count; i++)
            {
                command = new NpgsqlCommand(String.Format("SELECT COUNT(\"IDTicket\") FROM \"Tickets\" WHERE \"VisitorMovie\"={0}", IDValue[i]), Conection);
                reader = command.ExecuteReader();
                reader.Read();
                Films[i].Count = reader.GetInt32(0);
                Films[i].IDMovie = IDValue[i];
                Films[i].Name = NameValue[i];
                reader.Close();
            }
            Array.Sort(Films);
            for (int i = Films.Length - 1; i > Films.Length - 6; i--) 
                TicketsStat.Series["Series1"].Points.AddXY(Films[i].Name+" ("+Films[i].Count+")", Films[i].Count);
            #endregion
        }
    }
}