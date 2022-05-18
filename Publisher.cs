using GestioneSpese.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese
{
    public class Publisher
    {
        public delegate void Notify(IEnumerable<Expense> spese);

        //Evento
        public event Notify OnPublish;

        public void Publish(IEnumerable<Expense> spese)
        {
            if (OnPublish != null)
            {
                OnPublish(spese);
            }
        }
    }
}
