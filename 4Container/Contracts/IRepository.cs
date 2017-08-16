using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Container.Contracts
{
    internal interface IRepository
    {
        void Create(string str);
        void Remove(int id);
        void Update(string str);
        void Delete(int id);


    }
}
