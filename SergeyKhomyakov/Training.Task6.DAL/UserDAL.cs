using System;
using System.Collections.Generic;
using Training.Task6.Entity;
using Training.Task6.DAL.Interfaces;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace Training.Task6.DAL
{
    public class UserDAL : IUserDAL
    {
        private static Dictionary<int, User> _allUser = new Dictionary<int, User>();
        public UserDAL()
        {
            ReadFileDataBase();
        }

        public int Add(User user)
        {
            var lastid = _allUser.Keys.Count > 0 ? _allUser.Keys.Max() : 0;
            user.Id = lastid + 1;
            var age = DateTime.Now.Year - user.DateOfBirth.Year;
            user.Age = age;
            using (var writer = new StreamWriter(@"DateBaseUser.txt", true))
            {
                writer.WriteLine(JsonConvert.SerializeObject(user));
                _allUser.Add(user.Id,user);
            }
            return user.Id;
        }

        /// <summary>
        /// Get all users from database
        /// </summary>
        private void ReadFileDataBase() 
        {
            using (var reader = new StreamReader(@"DateBaseUser.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    var user = JsonConvert.DeserializeObject<User>(reader.ReadLine());
                    _allUser.Add(user.Id,user);
                }
            }
        }
        private void WriterFileDateBase() 
        {
            using (var writer = new StreamWriter(@"DateBaseUser.txt"))
            {
                foreach (var item in _allUser.Values)
                {

                    writer.WriteLine(JsonConvert.SerializeObject(item));
                }
            }
        }
        public void DeleteById(int id)
        {
            _allUser.Remove(id);
            WriterFileDateBase();
        }

        public IEnumerable<User> GetAll()
        {
            return _allUser.Values;
        }
    }
}
