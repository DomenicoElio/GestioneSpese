using GestioneSpese.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Factory
{
    public interface ICategory
    {
        string Name { get; set; }

        double GetRefund(Expense expense);
    }
}
