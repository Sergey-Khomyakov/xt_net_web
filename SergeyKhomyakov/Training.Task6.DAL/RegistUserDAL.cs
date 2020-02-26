using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Training.Task6.DAL.Interfaces;
using Training.Task6.Entity;

namespace Training.Task6.DAL
{
    public class RegistUserDAL : IRegistUserDAL
    {
        private static Dictionary<int, RegistUser> _allRegistUser = new Dictionary<int, RegistUser>();
        private string path;
        public RegistUserDAL()
        {
            CreateFile();
            ReadFileDataBase();
        }
        public void AddNewUser(RegistUser registUser)
        {
            var lastid = _allRegistUser.Keys.Count > 0 ? _allRegistUser.Keys.Max() : 0;
            registUser.Id = lastid + 1;

            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine(JsonConvert.SerializeObject(registUser));
                _allRegistUser.Add(registUser.Id, registUser);
            }
        }

        public void AddUserRoleAdmin(int id)
        {
            var user = _allRegistUser[id];
            _allRegistUser[id] = new RegistUser()
            {
                Id = user.Id,
                Login = user.Login,
                Password = user.Password,
                Role = new string[] { "Admin" }
            };
            WriterFileDateBase();
        }

        public void AddUserRoleUser(int id)
        {
            var user = _allRegistUser[id];
            _allRegistUser[id] = new RegistUser()
            {
                Id = user.Id,
                Login = user.Login,
                Password = user.Password,
                Role = new string[] { "User" }
            };
            WriterFileDateBase();
        }

        public IEnumerable<RegistUser> GetAll()
        {
            return _allRegistUser.Values;
        }
        private void CreateFile()
        {

            try
            {
                path = Path.GetFullPath("../../../Training.Task6.BD/RegistUser.txt");
                using (var wreater = new StreamWriter(path, true)) { }
            }
            catch (Exception)
            {
                path = Path.Combine(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName, "Training.Task6.BD\\RegistUser.txt");
                using (var wreater = new StreamWriter(path, true)) { }
            }
        }
        private void ReadFileDataBase()
        {
            using (var reader = new StreamReader(path))
            {
                while (reader.Peek() >= 0)
                {
                    var registUser = JsonConvert.DeserializeObject<RegistUser>(reader.ReadLine());
                    _allRegistUser.Add(registUser.Id, registUser);
                }
            }
        }
        private void WriterFileDateBase()
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var item in _allRegistUser.Values)
                {

                    writer.WriteLine(JsonConvert.SerializeObject(item));
                }
            }
        }
    }
}
