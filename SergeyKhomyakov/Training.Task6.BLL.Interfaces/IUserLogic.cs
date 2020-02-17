using System;
using System.Collections.Generic;
using Training.Task6.Entity;

namespace Training.Task6.BLL.Interfaces
{
    public interface IUserLogic
    {
        int Add(User user);
        void DeleteById(int id);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
