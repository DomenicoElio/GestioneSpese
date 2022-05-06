using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Interfaces
{
    internal interface IRepository<T>
    {
        public List<T> GetAll();

        bool Add(T item); 

    }
}
