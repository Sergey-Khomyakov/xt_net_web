using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Training.Task6.DAL.Interfaces;
using Training.Task6.Entity;
using System.Configuration;
using System.Linq;

namespace Training.Task11.DAL
{
    public class RegistUserDAL : IRegistUserDAL
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
        public void AddNewUser(RegistUser registUser)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.AddRegistUser";

                var idParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.Int32,
                    ParameterName = "@Id",
                    Value = registUser.Id,
                    Direction = System.Data.ParameterDirection.Output
                };

                command.Parameters.Add(idParameter);

                var loginParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.String,
                    ParameterName = "@Login",
                    Value = registUser.Login,
                    Direction = System.Data.ParameterDirection.Input
                };

                command.Parameters.Add(loginParameter);

                var passwordParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.String,
                    ParameterName = "@Password",
                    Value = registUser.Password,
                    Direction = System.Data.ParameterDirection.Input
                };

                command.Parameters.Add(passwordParameter);

                var roleParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.String,
                    ParameterName = "@Role",
                    Value = registUser.Role[0],
                    Direction = System.Data.ParameterDirection.Input
                };

                command.Parameters.Add(roleParameter);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void AddUserRoleAdmin(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var user = GetAll().Where(item => item.Id == id);

                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE [RegistUser] SET [Role]='Admin' WHERE [Id]=@param1";
                command.Parameters.AddWithValue("@param1", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void AddUserRoleUser(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var user = GetAll().Where(item => item.Id == id);

                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE [RegistUser] SET [Role]='User' WHERE [Id]=@param1";
                command.Parameters.AddWithValue("@param1", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<RegistUser> GetAll()
        {
            var registUser = new List<RegistUser>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT [Id], [Login], [Password], [Role] FROM [RegistUser]";

                connection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    registUser.Add(new RegistUser()
                    {
                        Id = (int)reader["Id"],
                        Login = reader["Login"] as string,
                        Password = reader["Password"] as string,
                        Role = new string[] { reader["Role"] as string }
                    });
                }
            }
            return registUser;
        }
    }
}
