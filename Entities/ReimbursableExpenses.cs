using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Entities
{
    internal class ReimbursableExpenses : Expenses
    {
        bool approved = true;

        string approvalLevel { get; set; }

        double reimbursementValue { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Date: {Date}. Category= {Category}, Desc.= {Description}, Costs= {Costs}, Approved?={approved}" +
                $", By who?= {approvalLevel}{reimbursementValue}");
        }


    }
}
