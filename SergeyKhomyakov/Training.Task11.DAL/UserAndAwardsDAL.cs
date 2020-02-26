using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Training.Task6.DAL.Interfaces;
using Training.Task6.Entity;
using System.Configuration;

namespace Training.Task11.DAL
{
    public class UserAndAwardsDAL : IUserAndAwardsDAL
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
        public void AddUserRewards(int userId, int awardId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "dbo.AddUserAward";

                var userIdParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.Int32,
                    ParameterName = "@UserId",
                    Value = userId,
                    Direction = System.Data.ParameterDirection.Input
                };

                command.Parameters.Add(userIdParameter);

                var awardIdParameter = new SqlParameter()
                {
                    DbType = System.Data.DbType.Int32,
                    ParameterName = "@AwardId",
                    Value = awardId,
                    Direction = System.Data.ParameterDirection.Input
                };

                command.Parameters.Add(awardIdParameter);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteAward(int awardId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM [UserAward] WHERE [AwardId] = @param1";
                command.Parameters.AddWithValue("@param1", awardId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int userId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM [UserAward] WHERE [UserId] = @param1";
                command.Parameters.AddWithValue("@param1", userId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteUserRewards(int userId, int awardId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM [UserAward] WHERE [AwardId] = @param1 AND [UserId] = @param2";
                command.Parameters.AddWithValue("@param1", awardId);
                command.Parameters.AddWithValue("@param2", userId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<UsersAndAward> GetAllAwardUser(int userId)
        {
            var registUser = new List<UsersAndAward>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT [AwardId] FROM [UserAward] WHERE [UserId] = @param1";
                command.Parameters.AddWithValue("@param1", userId);

                connection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    registUser.Add(new UsersAndAward()
                    {
                        UserId = userId,
                        AwardId = (int) reader["AwardId"]
                    });
                }
            }
            return registUser;
        }
    }
}
