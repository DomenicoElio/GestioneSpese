using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Entities
{
    internal class NonReimbursableExpenses : Expenses
    {
        bool approved = false;

        public override void Print()
        {
            Console.WriteLine($"Date: {Date}. Category= {Category}, Desc.= {Description}, Costs= {Costs}, not Approved ={approved}");
        }


    }
}
