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

            using (var wreater = new StreamWriter(@"UserAward.txt",true))
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
        private void CreateFile() 
        {
            using (var wreater = new StreamWriter(@"UserAward.txt", true)) { }
        }
        private void WriterFileUserAward()
        {
            using (var writer = new StreamWriter(@"UserAward.txt"))
            {
                foreach (var item in _allUserAwards)
                {

                    writer.WriteLine(JsonConvert.SerializeObject(item));
                }
            }
        }
        private void ReadFileUserAward()
        {
            using (var reader = new StreamReader(@"UserAward.txt"))
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
