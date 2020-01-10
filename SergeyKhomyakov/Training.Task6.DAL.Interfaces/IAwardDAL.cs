using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Task6.Entity;

namespace Training.Task6.DAL.Interfaces
{
    public interface IAwardDAL
    {
        void Add(Award award);
        void DeleteById(int id);
        IEnumerable<Award> GetAll();
    }
}
