using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Entities
{
    public enum Cat
    {
        Viaggio,
        Alloggio,
        Vitto,
        Altro
    }
    public class Expenses
    {
        public DateTime Date { get; set; }
        public Cat Category { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }


        public virtual string ToRow() {return $"{Date.ToShortDateString};{Category};{Description};{Amount}";}

        public override string ToString()
        {return $"this is when he spent: {Date.ToShortDateString}" +$"this is the type of expense: {Category}" +$"this is what he did: {Description}" + $"The cost was: €{Amount}\n";}
    }
}
