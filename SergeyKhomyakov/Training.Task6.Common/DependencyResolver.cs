using System;
using Training.Task6.BLL;
using Training.Task6.BLL.Interfaces;
using Training.Task6.DAL;
using Training.Task6.DAL.Interfaces;

namespace Training.Task6.Common
{
    public static class DependencyResolver
    {
        private static readonly IUserLogic _userLogic;
        private static readonly IUserDAL _userDAL;
        private static readonly IAwardLogic _awardLogic;
        private static readonly IAwardDAL _awardDAL;
        private static readonly IUserAndAwardLogic _userAwardLogic;
        private static readonly IUserAndAwardsDAL _userAwardsDAL;

        public static IUserLogic UserLogic => _userLogic;
        public static IUserDAL UserDal => _userDAL;
        public static IAwardLogic AwardLogic => _awardLogic;
        public static IAwardDAL AwardDAL => _awardDAL;
        public static IUserAndAwardLogic UserAwardLogic => _userAwardLogic;

        public static IUserAndAwardsDAL UserAwardsDAL => _userAwardsDAL;
        static DependencyResolver()
        {
            _userDAL = new UserDAL();
            _userLogic = new UserLogic(_userDAL);
            _awardDAL = new AwardDAL();
            _awardLogic = new AwardLogic(_awardDAL);
            _userAwardsDAL = new UserAndAwardsDAL();
            _userAwardLogic = new UserAndAwardLogic(_userAwardsDAL);
        }
    }
}
