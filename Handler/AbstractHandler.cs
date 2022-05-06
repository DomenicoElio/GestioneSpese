using System;
using GestioneSpese.Handler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Handler
{
    public abstract class AbstractHandler : Ihandler
    {
        private Ihandler _nextHandler;
        public virtual double Handle(double request)
        {
            if (_nextHandler != null)
                //se il nextHandler è diverso da null vuol dire che c'è un componente
                //in grado di prendere in carico la richiesta, per cui gliela invio
                return _nextHandler.Handle(request);
            else
                //la richiesta non può essere presa in carico da nessuno quindi cade nel vuoto
                return request;
        }

        public Ihandler SetNext(Ihandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
    }
}
