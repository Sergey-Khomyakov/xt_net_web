using System;
using System.Collections.Generic;
using System.Linq;
using Training.Task6.BLL.Interfaces;
using Training.Task6.DAL.Interfaces;
using Training.Task6.Entity;

namespace Training.Task6.BLL
{
    public class AwardLogic : IAwardLogic
    {
        private readonly IAwardDAL _awardDAL;
        public AwardLogic(IAwardDAL awardDAL)
        {
            _awardDAL = awardDAL;
        }

        public void Add(Award award)
        {
            _awardDAL.Add(award);
        }

        public void DeleteById(int id)
        {
            _awardDAL.DeleteById(id);
        }

        public void EditingAward(int awardId, string title, byte[] Image)
        {
            _awardDAL.EditingAward(awardId, title, Image);
        }

        public IEnumerable<Award> GetAll()
        {
            return _awardDAL.GetAll();
        }

        public Award GetById(int id)
        {
            return _awardDAL.GetAll().FirstOrDefault(item => item.Id == id);
        }
    }
}
