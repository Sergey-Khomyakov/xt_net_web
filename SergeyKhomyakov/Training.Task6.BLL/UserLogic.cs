using System;
using System.Collections.Generic;
using System.Linq;
using Training.Task6.BLL.Interfaces;
using Training.Task6.DAL.Interfaces;
using Training.Task6.Entity;

namespace Training.Task6.BLL
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserDAL _userDAL;

        public UserLogic(IUserDAL userDAL) 
        {
            _userDAL = userDAL;
        }
        public int Add(User user)
        {
            return _userDAL.Add(user);
        }
        public void DeleteById(int id)
        {
            _userDAL.DeleteById(id);
        }

        public void EditingUser(int userId, string Name, DateTime DateOfBirth, byte[] Image)
        {
            _userDAL.EditingUser(userId, Name, DateOfBirth, Image);
        }

        public IEnumerable<User> GetAll()
        {
            return _userDAL.GetAll();
        }

        public User GetById(int id)
        {
            return _userDAL.GetAll().FirstOrDefault(item => item.Id == id);
        }
    }
}
