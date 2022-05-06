using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Handler
{
    public interface Ihandler
    {

        //Metodo per settare l'anello successivo della catena
        Ihandler SetNext(Ihandler handler);

        //Metodo per gestire la richiesta
        double Handle(double request);


    }
}
