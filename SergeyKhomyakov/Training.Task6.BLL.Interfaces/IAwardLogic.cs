using System;
using System.Collections.Generic;
using Training.Task6.Entity;

namespace Training.Task6.BLL.Interfaces
{
    public interface IAwardLogic
    {
        void Add(Award award);
        void DeleteById(int id);
        IEnumerable<Award> GetAll();
        Award GetById(int id);
        void EditingAward(int awardId, string title, byte[] Image);
    }
}
