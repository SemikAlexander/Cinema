using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Cinema.Logical
{
    class Movie
    {
        ConectionStr str = new ConectionStr();
        public string[] values_for_delete_movie = { "IDMovie", "NameMovie", "Duration", "Genre", "Country", "AgeRestrictions" };
        public void Add(int genre, int country, int duration, int age, string name_movie, int hall_for_session, int price_ticket, DateTime Date)
        {
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand("INSERT INTO \"Movies\" (\"Genre\",\"Country\",\"Duration\",\"AgeRestrictions\",\"IDMovie\",\"NameMovie\") VALUES (@Genre, @Country, @Duration, @AgeRestrictions, nextval('cinema_sequence'), @NameMovie)", Conection);
            command.Parameters.AddWithValue("@Genre", genre);
            command.Parameters.AddWithValue("@Country", country);
            command.Parameters.AddWithValue("@Duration", duration);
            command.Parameters.AddWithValue("@AgeRestrictions", age);
            command.Parameters.AddWithValue("@NameMovie", name_movie);
            command.ExecuteNonQuery();
            Conection.Close();

            Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            command = new NpgsqlCommand(String.Format("SELECT \"IDMovie\" FROM \"Movies\" WHERE \"NameMovie\"='{0}'", name_movie), Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int id_movie = (int)reader.GetValue(0);
            reader.Close();

            Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            command = new NpgsqlCommand("INSERT INTO \"Session\" (\"UsingHall\",\"WhatMovie\",\"PriceMovie\", \"Date\") VALUES (@UsingHall, @WhatMovie, @PriceMovie, @Date)", Conection);
            command.Parameters.AddWithValue("@UsingHall", hall_for_session);
            command.Parameters.AddWithValue("@WhatMovie", id_movie);
            command.Parameters.AddWithValue("@PriceMovie", price_ticket);
            command.Parameters.AddWithValue("@Date", Date);
            command.ExecuteNonQuery();
            Conection.Close();
        }
        public void Delete(int ID)
        {
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand(String.Format("DELETE FROM \"Movies\" WHERE \"IDMovie\"={0}", ID), Conection);
            command.ExecuteNonQuery();
            Conection.Close();
        }
        public void Edit(int id, int genre, int country, int duration, int ageRestrictions, string nameMovie, int usingHall, int priceMovie)
        {
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand(String.Format("UPDATE \"Movies\" SET \"Genre\"= {0}, \"Country\"= {1}, \"Duration\"= {2}, \"AgeRestrictions\"= {3}, \"NameMovie\"= '{4}' WHERE \"IDMovie\"= '{5}';", genre, country, duration, ageRestrictions, nameMovie, id), Conection);
            command.ExecuteNonQuery();
            command = new NpgsqlCommand(String.Format("UPDATE \"Session\" SET \"UsingHall\"= {0}, \"PriceMovie\"= {1} WHERE \"WhatMovie\"= '{2}';", usingHall, priceMovie, id), Conection);
            command.ExecuteNonQuery();
            Conection.Close();
        }
        public bool CheckForAdd(int genre, int country, string name_movie)
        {
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand(String.Format("SELECT \"NameMovie\",\"Genre\",\"Country\" FROM \"Movies\" WHERE \"NameMovie\"='{0}' AND \"Genre\"= {1} AND \"Country\"={2}", name_movie, genre, country), Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                string read = reader.GetString(0);
                reader.Close();
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
        public bool CheckForEdit(int ID)
        {
            var Conection = new NpgsqlConnection(str.Con);
            Conection.Open();
            var command = new NpgsqlCommand(String.Format("SELECT \"NameMovie\" FROM \"Movies\" WHERE \"IDMovie\"= {0}", ID), Conection);
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
            var command = new NpgsqlCommand("SELECT * FROM \"Movies\"", Conection);
            NpgsqlDataReader reader = command.ExecuteReader();
            reader.Read();
            result = (int)reader.GetValue(4);
            reader.Close();
            return result;
        }
    }
}