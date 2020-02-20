using System;
using System.Collections.Generic;
using Training.Task6.Entity;

namespace Training.Task6.BLL.Interfaces
{
    public interface IRegistUserLogic
    {
        void AddNewUser(RegistUser registUser);
        void AddUserRoleUser(int id);
        void AddUserRoleAdmin(int id);
        bool IsUserInRole(string username,string role);
        string[] GetRolesForUser(string username);
        IEnumerable<RegistUser> GetAll();
        void ChangeUserRole(int id, string login, string password, string[] role);
        bool CheckUser(string Login, string Password);
        RegistUser GetByLodin(string Login);
    }
}
