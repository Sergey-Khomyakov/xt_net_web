using System;
using System.Collections.Generic;
using System.Linq;
using Training.Task6.BLL.Interfaces;
using Training.Task6.DAL.Interfaces;
using Training.Task6.Entity;

namespace Training.Task6.BLL
{
    public class UserAndAwardLogic : IUserAndAwardLogic
    {
        private readonly IUserAndAwardsDAL _userAwardDAL;
        public UserAndAwardLogic(IUserAndAwardsDAL userAwardDAL)
        {
            _userAwardDAL = userAwardDAL;
        }
        public void AddUserRewards(int userId, int awardId)
        {
            _userAwardDAL.AddUserRewards(userId, awardId);
        }

        public void DeleteUser(int userId)
        {
            _userAwardDAL.DeleteUser(userId);
        }

        public void DeleteUserRewards(int userId, int awardId)
        {
            _userAwardDAL.DeleteUserRewards(userId, awardId);
        }

        public IEnumerable<UsersAndAward> GetAllAwardUser(int userId)
        {
            return _userAwardDAL.GetAllAwardUser(userId);
        }
    }
}
