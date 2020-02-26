using System;
using System.Collections.Generic;
using System.Linq;
using Training.Task6.BLL.Interfaces;
using Training.Task6.DAL.Interfaces;
using Training.Task6.Entity;

namespace Training.Task6.BLL
{
    public class RegistUserLogic : IRegistUserLogic
    {
        private readonly IRegistUserDAL _registUserDAL;

        public RegistUserLogic(IRegistUserDAL registUserDAL)
        {
            _registUserDAL = registUserDAL;
        }
        public void AddNewUser(RegistUser registUser)
        {
            _registUserDAL.AddNewUser(registUser);
        }

        public void AddUserRoleAdmin(int id)
        {
            _registUserDAL.AddUserRoleAdmin(id);
        }

        public void AddUserRoleUser(int id)
        {
            _registUserDAL.AddUserRoleUser(id);
        }

        public bool CheckUser(string Login, string Password)
        {
            var user = GetByLodin(Login);

            return user == null ? false : user.Password == Password;
        }

        public IEnumerable<RegistUser> GetAll()
        {
            return _registUserDAL.GetAll();
        }

        public RegistUser GetByLodin(string Login)
        {
            return _registUserDAL.GetAll().FirstOrDefault(item => item.Login == Login);
        }

        public string[] GetRolesForUser(string username)
        {
            var user = GetByLodin(username);

            return user == null ? new string[] { } : user.Role;
        }

        public bool IsUserInRole(string username, string role)
        {
            var user = GetByLodin(username);

            return user == null ? false : user.Role.Contains(role);
        }
    }
}
