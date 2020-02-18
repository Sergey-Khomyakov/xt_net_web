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
        private string path; 

        public UserDAL()
        {
            CreateFile();
            ReadFileDataBase();
            
        }

        public int Add(User user)
        {
            var lastid = _allUser.Keys.Count > 0 ? _allUser.Keys.Max() : 0;
            user.Id = lastid + 1;
            user.Age = DateTime.Now.Year - user.DateOfBirth.Year;

            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine(JsonConvert.SerializeObject(user));
                _allUser.Add(user.Id,user);
            }
            return user.Id;
        }

        public void DeleteById(int id)
        {
            _allUser.Remove(id);
            WriterFileDateBase();
        }

        public void EditingUser(int userId, string Name, DateTime DateOfBirth, string pathImage)
        {
            _allUser[userId] = new User()
            {
                Id = userId,
                Name = Name,
                DateOfBirth = DateOfBirth,
                Age = DateTime.Now.Year - DateOfBirth.Year,
                Path_image = pathImage
            };
            WriterFileDateBase();
        }

        public IEnumerable<User> GetAll()
        {
            return _allUser.Values;
        }

        private void CreateFile()
        {
              
            try
            {               
                path = Path.GetFullPath("../../../Training.Task6.BD/DateBaseUser.txt");
                using (var wreater = new StreamWriter(path, true)) { }    
            }
            catch (Exception) 
            {
                path = Path.Combine(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName, "Training.Task6.BD\\DateBaseUser.txt");
                using (var wreater = new StreamWriter(path, true)) { }
            }
        }
        /// <summary>
        /// Get all users from database
        /// </summary>
        private void ReadFileDataBase() 
        {
            using (var reader = new StreamReader(path))
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
            using (var writer = new StreamWriter(path))
            {
                foreach (var item in _allUser.Values)
                {

                    writer.WriteLine(JsonConvert.SerializeObject(item));
                }
            }
        }
    }
}
