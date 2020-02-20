using System;
using System.Collections.Generic;
using Training.Task6.Entity;

namespace Training.Task6.DAL.Interfaces
{
    public interface IRegistUserDAL
    {
        void AddNewUser(RegistUser registUser);
        void AddUserRoleUser(int id);
        void AddUserRoleAdmin(int id);
        IEnumerable<RegistUser> GetAll();
        void ChangeUserRole(int id, string login, string password, string[] role);
    }
}
