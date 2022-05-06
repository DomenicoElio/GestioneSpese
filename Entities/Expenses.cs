using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Entities
{
    public class Expenses
    {

        public DateTime Date { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }
        
        public double Costs { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Generica figura geometrica");
        }

    }
}
