using GestioneSpese.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Factory
{
    public class Other : ICategory
    {
        public string Name { get; set; } = "Other";

        public double GetRefund(Expense expense)
        {
            return expense.Amount * 0.1;
        }
    }
}
