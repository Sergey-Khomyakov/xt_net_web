using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Task6.Entity;

namespace Training.Task6.BLL.Interfaces
{
    public interface IUserAndAwardLogic
    {
        void AddUserRewards(int userId, int awardId);
        void DeleteUserRewards(int userId, int awardId);
        void DeleteUser(int userId);
        IEnumerable<UsersAndAward> GetAllAwardUser(int userId);
    }
}
