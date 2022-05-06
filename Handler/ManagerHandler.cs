using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Handler
{
    internal class ManagerHandler : AbstractHandler
    {

        public override double Handle(double request)
        {
            if (request <= 400)
                return request;
            else
                return base.Handle(request);
        }

    }
}
