using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Training.Task6.DAL.Interfaces;
using Training.Task6.Entity;
using System.Configuration;

namespace Training.Task11.DAL
{
    public class UserDAL : IUserDAL
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
        public int Add(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.AddUser";

                var idParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.Int32,
                    ParameterName = "@Id",
                    Value = user.Id,
                    Direction = System.Data.ParameterDirection.Output
                };

                command.Parameters.Add(idParameter);
                var nameParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.String,
                    ParameterName = "@Name",
                    Value = user.Name,
                    Direction = System.Data.ParameterDirection.Input
                };

                command.Parameters.Add(nameParameter);

                var ageParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.Int32,
                    ParameterName = "@Age",
                    Value = DateTime.Now.Year - user.DateOfBirth.Year,
                    Direction = System.Data.ParameterDirection.Input
                };

                command.Parameters.Add(ageParameter);

                var dateOfBirthParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.DateTime,
                    ParameterName = "@DateOfBirth",
                    Value = user.DateOfBirth,
                    Direction = System.Data.ParameterDirection.Input
                };

                command.Parameters.Add(dateOfBirthParameter);

                var imageParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.Binary,
                    ParameterName = "@Image",
                    Value = user.image,
                    Direction = System.Data.ParameterDirection.Input
                };

                command.Parameters.Add(imageParameter);

                connection.Open();
                command.ExecuteNonQuery();

                return (int) idParameter.Value;
            }
        }

        public void DeleteById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM [User] WHERE [Id] = @param1";
                command.Parameters.AddWithValue("@param1", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void EditingUser(int userId, string Name, DateTime DateOfBirth, byte[] Image)
        {
            var newAge = DateTime.Now.Year - DateOfBirth.Year;

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE [User] SET [Name] = @param2, [Age] = @param3, [DateOfBirth] = @param4, [Image] = @param5 WHERE [Id] = @param1";
                command.Parameters.AddWithValue("@param1", userId);
                command.Parameters.AddWithValue("@param2", Name);
                command.Parameters.AddWithValue("@param3", newAge);
                command.Parameters.AddWithValue("@param4", DateOfBirth);
                command.Parameters.AddWithValue("@param5", Image);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<User> GetAll()
        {
            var users = new List<User>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT [Id], [Name], [Age], [DateOfBirth], [Image] FROM [User]";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    users.Add( new User() {
                        Id = (int) reader["Id"],
                        Name = reader["Name"] as string,
                        Age = (int) reader["Age"],
                        DateOfBirth = (DateTime) reader["DateOfBirth"],
                        image = Convert.IsDBNull(reader["Image"]) ? new byte[] { } : (byte[]) reader["Image"]
                    });
                }
            }
            return users;
        }
    }
}
