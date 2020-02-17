﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Task6.Entity;

namespace Training.Task6.DAL.Interfaces
{
    public interface IUserDAL
    {
        int Add(User note);
        void DeleteById(int id);
        IEnumerable<User> GetAll();
    }
}