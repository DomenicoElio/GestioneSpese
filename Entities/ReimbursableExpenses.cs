using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Entities
{
    public enum Level
    {
        manager,
        operationalManager,
        CEO
    }
    public class ProcessedExpence : Expenses
    {
        public bool Approved { get; set; }
        public Level approvedBy { get; set; }
        public double Refund { get; set; }

        public string RefundApproved() {return Approved ? "your refund has been issued" : "refund denied";}

        public override string ToRow() {return $"{base.ToRow()};{Approved};{approvedBy};{Refund}";}

        public override string ToString(){return base.ToString() +$"Stato: {RefundApproved()}" +$"Livello: {approvedBy}" +$"Importo rimborsato: €{Refund}";}
    }
}
