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

        public static IUserLogic UserLogic => _userLogic;
        public static IUserDAL UserDal => _userDAL;
        static DependencyResolver()
        {
            _userDAL = new UserDAL();
            _userLogic = new UserLogic(_userDAL);
        }
    }
}
