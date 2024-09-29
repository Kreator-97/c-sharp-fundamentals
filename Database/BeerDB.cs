using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class BeerDB: DB
    {
        public BeerDB(string server, string db, string user, string password): base(server, db, user, password){}

        public List<Beer> GetAll()
        {
            Connect();
            List<Beer> beers = new List<Beer>();
            string query = "SELECT ID, Name, BrandID from Beer";

            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader reader = command.ExecuteReader();

            while( reader.Read() )
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int brandId = reader.GetInt32(2);

                beers.Add( new Beer(id, name, brandId) );
            }

            Disconnect();
            return beers;
        }

        public void Add(Beer beer)
        {
            Connect();

            string query = "INSERT INTO beer (Name, BrandId) " +
                "VALUES(@name, @brandId)"
            ;

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@name", beer.Name);
            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            command.ExecuteNonQuery();

            Disconnect();
        }

        public Beer? GetById(int id)
        {
            Connect();

            Beer? beer = null;

            string query = "SELECT Id, Name, BrandId FROM Beer " +
                "WHERE id = @id";

            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                string name = reader.GetString(1);
                int brandId = reader.GetInt32(2);

                beer = new Beer(id, name, brandId);
            }

            Disconnect();
            return beer;
        }

        public void Edit(Beer beer)
        {
            Connect();

            string query = "UPDATE beer SET Name=@name, BrandId=@brandId " +
                "WHERE ID=@id";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@brandId", beer.BrandId);
            command.Parameters.AddWithValue("@name", beer.Name);
            command.Parameters.AddWithValue("@id", beer.Id);

            command.ExecuteNonQuery();

            Disconnect();
        }

        public void Delete(int id)
        {
            Connect();

            string query = "DELETE FROM Beer WHERE id=@id";
            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            Disconnect();
        }
    }
}
