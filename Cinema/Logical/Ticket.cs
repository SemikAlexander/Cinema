using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Cinema.Logical
{
    class Ticket
    {
        public string[] values_for_delete_ticket = { "IDTicket", "NameVisitor", "Place", "Price", "VisitorMovie", "Hall" };
        ConectionStr str = new ConectionStr();
        public void Add(string NameVisitor, int Place, int Price, int VisitiorMovie, int Hall, DateTime DateSession)
        {
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand("INSERT INTO \"Tickets\" (\"IDTicket\",\"NameVisitor\",\"Place\",\"Price\",\"VisitorMovie\",\"Hall\",\"DateSession\") VALUES (nextval('ticket_sequence'), @NameVisitor, @Place, @Price, @VisitorMovie, @Hall, @DateSession)", Conection);
            command.Parameters.AddWithValue("@NameVisitor", NameVisitor);
            command.Parameters.AddWithValue("@Place", Place);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@VisitorMovie", VisitiorMovie);
            command.Parameters.AddWithValue("@Hall", Hall);
            command.Parameters.AddWithValue("@DateSession", DateSession.Date);
            command.ExecuteNonQuery();
            Conection.Close();
        }
        public void Edit(int id, string NameVisitor, int Place, int Price, int VisitorMovie, int Hall, DateTime DateSession)
        {
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand(String.Format("UPDATE \"Tickets\" SET \"NameVisitor\"= '{0}', \"Place\"= {1}, \"Price\"= {2}, \"VisitorMovie\" = {2}, \"Hall\"= {3}, \"DateSession\"= '{4}' WHERE \"IDTicket\"= '{5}';", NameVisitor, Place, VisitorMovie, Hall, DateSession, id), Conection);
            command.ExecuteNonQuery();
            Conection.Close();
        }
        public void Delete(int ID)
        {
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand(String.Format("DELETE FROM \"Tickets\" WHERE \"IDTicket\"={0}", ID), Conection); 
            command.ExecuteNonQuery();
            Conection.Close();
        }
        public bool Check(int ID)
        {
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand(String.Format("SELECT \"NameVisitor\" FROM \"Tickets\" WHERE \"IDTicket\"= {0}", ID), Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                string read = (string)reader.GetValue(0);
                reader.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int IDRecord()
        {
            int result = 0;
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand("SELECT * FROM \"Tickets\"", Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                result = reader.GetInt32(0);
                reader.Close();
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }
    }
}