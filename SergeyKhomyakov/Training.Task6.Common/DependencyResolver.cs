using System;
using Training.Task6.BLL;
using Training.Task6.BLL.Interfaces;
using Training.Task6.DAL;
using Training.Task6.DAL.Interfaces;

namespace Training.Task6.Common
{
    public static class DependencyResolver
    {
        public static IUserLogic UserLogic { get; private set; }
        public static IUserDAL UserDal { get; private set; }
        public static IAwardLogic AwardLogic { get; private set; }
        public static IAwardDAL AwardDAL { get; private set; }
        public static IUserAndAwardLogic UserAwardLogic { get; private set; }
        public static IRegistUserLogic RegistUserLogic { get; private set; }
        public static IRegistUserDAL RegistUserDAL { get; private set; }
        public static IUserAndAwardsDAL UserAwardsDAL { get; private set; }
        static DependencyResolver()
        {
            UserDal = new UserDAL();
            UserLogic = new UserLogic(UserDal);
            AwardDAL = new AwardDAL();
            AwardLogic = new AwardLogic(AwardDAL);
            UserAwardsDAL = new UserAndAwardsDAL();
            UserAwardLogic = new UserAndAwardLogic(UserAwardsDAL);
            RegistUserDAL = new RegistUserDAL();
            RegistUserLogic = new RegistUserLogic(RegistUserDAL);            
        }
    }
}
