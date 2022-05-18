using GestioneSpese.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Handlers
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        Refund Handle(Expense expense);
    }
}
