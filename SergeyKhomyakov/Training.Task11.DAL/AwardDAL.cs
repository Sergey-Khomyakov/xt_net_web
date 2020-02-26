using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Training.Task6.DAL.Interfaces;
using Training.Task6.Entity;
using System.Configuration;

namespace Training.Task11.DAL
{
    public class AwardDAL : IAwardDAL
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
        public void Add(Award award)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.AddAward";

                var idParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.Int32,
                    ParameterName = "@Id",
                    Value = award.Id,
                    Direction = System.Data.ParameterDirection.Output
                };

                command.Parameters.Add(idParameter);
                var titleParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.String,
                    ParameterName = "@Title",
                    Value = award.Title,
                    Direction = System.Data.ParameterDirection.Input
                };

                command.Parameters.Add(titleParameter);

                var imageParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.Binary,
                    ParameterName = "@Image",
                    Value = award.image,
                    Direction = System.Data.ParameterDirection.Input
                };

                command.Parameters.Add(imageParameter);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM [Award] WHERE [Id] = @param1";
                command.Parameters.AddWithValue("@param1", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EditingAward(int awardId, string title, byte[] Image)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE [Award] SET [Title] = @param2, [Image] = @param3 WHERE [Id] = @param1";
                command.Parameters.AddWithValue("@param1", awardId);
                command.Parameters.AddWithValue("@param2", title);
                command.Parameters.AddWithValue("@param3", Image);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Award> GetAll()
        {
            var award = new List<Award>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT [Id], [Title], [Image] FROM [Award]";

                connection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    award.Add(new Award()
                    {
                        Id = (int)reader["Id"],
                        Title = reader["Title"] as string,
                        image = Convert.IsDBNull(reader["Image"]) ? new byte[] { } : (byte[])reader["Image"]
                    });
                }
            }
            return award;
        }
    }
}
