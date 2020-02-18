using System;
using System.Collections.Generic;
using Training.Task6.Entity;
using Training.Task6.DAL.Interfaces;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace Training.Task6.DAL
{
    public class UserAndAwardsDAL : IUserAndAwardsDAL
    {
        private static List<UsersAndAward> _allUserAwards = new List<UsersAndAward>();
        private string path;
        public UserAndAwardsDAL()
        {      
            CreateFile();
            ReadFileUserAward();         
        }
        public void AddUserRewards(int userId, int awardId)
        {
            var user = new UsersAndAward()
            {
                UserId = userId,
                AwardId = awardId
            };

            using (var wreater = new StreamWriter(path, true))
            {
                var jsontxt = JsonConvert.SerializeObject(user);
                wreater.WriteLine(jsontxt);
                _allUserAwards.Add(user);
            }
        }

        public void DeleteUserRewards(int userId, int awardId)
        {
            _allUserAwards.Remove(_allUserAwards.Find(n => n.UserId == userId && n.AwardId == awardId));
            WriterFileUserAward();
        }

        public IEnumerable<UsersAndAward> GetAllAwardUser(int userId)
        {
            return _allUserAwards.Where(n => n.UserId == userId);
        }   
        public void DeleteUser(int userId)
        {
            foreach (var item in _allUserAwards.FindAll(n => n.UserId == userId))
            {
             _allUserAwards.Remove(item);
            }
            WriterFileUserAward();
        }
        public void DeleteAward(int awardId)
        {
            foreach (var item in _allUserAwards.FindAll(n => n.AwardId == awardId))
            {
                _allUserAwards.Remove(item);
            }
            WriterFileUserAward();
        }
        private void CreateFile() 
        {
            try
            {
                path = Path.GetFullPath("../../../Training.Task6.BD/UserAward.txt");
                using (var wreater = new StreamWriter(path, true)) { }
            }
            catch (Exception)
            {
                path = Path.Combine(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName, "Training.Task6.BD\\UserAward.txt");
                using (var wreater = new StreamWriter(path, true)) { }
            }
        }
        private void WriterFileUserAward()
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var item in _allUserAwards)
                {

                    writer.WriteLine(JsonConvert.SerializeObject(item));
                }
            }
        }
        private void ReadFileUserAward()
        {
            using (var reader = new StreamReader(path))
            {
                while (reader.Peek() >= 0)
                {
                    var user = JsonConvert.DeserializeObject<UsersAndAward>(reader.ReadLine());
                    _allUserAwards.Add(user);
                }
            }
        }
    }
}
