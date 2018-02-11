using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event.Repository
{
    class EventRepository
    {
         private string connectionString= @"Server = .\SQLICO; Initial Catalog = Events; Integrated Security = True";
        //public EventRepository(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //}
        public void Insert(Entity.Event myEvent)
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = @"INSERT INTO Events(Name, Location,BeginningDate,EndDate) 
                                          VALUES(@name, @location,@beginningDate,@endDate)";

            IDataParameter parameter = command.CreateParameter();
            parameter.ParameterName = "@name";
            parameter.Value = myEvent.name;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@location";
            parameter.Value = myEvent.location;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@beginningDate";
            parameter.Value = myEvent.beginningDate;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@endDate";
            parameter.Value = myEvent.endDate;
            command.Parameters.Add(parameter);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        public void Update(Entity.Event myEvent)
        {
           
            IDbConnection connection = new SqlConnection(connectionString);
            IDbCommand command = connection.CreateCommand();
            command.CommandText = @"UPDATE Events SET Name=@name, Location=@location, BeginningDate=@beginningDate, EndDate=@endDate WHERE Id=@id";

            IDataParameter parameter = command.CreateParameter();
            parameter.ParameterName = "@name";
            parameter.Value = myEvent.name;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@location";
            parameter.Value = myEvent.location;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@beginningDate";
            parameter.Value = myEvent.beginningDate;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@endDate";
            parameter.Value = myEvent.endDate;
            command.Parameters.Add(parameter);

            parameter = command.CreateParameter();
            parameter.ParameterName = "@id";
            parameter.Value = myEvent.id;
            command.Parameters.Add(parameter);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
        public List<Entity.Event> GetAllEvent()
        {
            List<Entity.Event> eventResultList = new List<Entity.Event>();
            IDbConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                IDbCommand command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM Events";
                IDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Entity.Event myEvent = new Entity.Event();
                        myEvent.id = (int)reader["Id"];
                        myEvent.name = (string)reader["Name"];
                        myEvent.location = (string)reader["Location"];
                        myEvent.beginningDate = reader["BeginningDate"].ToString();
                        myEvent.endDate = reader["EndDate"].ToString();

                        eventResultList.Add(myEvent);
                    }
                }

            }
            finally
            {
                connection.Close();
            }
            return eventResultList;
        }
        public void Delete(int id)
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = @"DELETE FROM Events WHERE Id=@id";

            IDataParameter parameter = command.CreateParameter();
            parameter.ParameterName = "@id";
            parameter.Value = id;
            command.Parameters.Add(parameter);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
