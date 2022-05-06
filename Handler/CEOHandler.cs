using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Handler
{
    internal class CEOHandler : AbstractHandler
    {

        public override double Handle(double request)
        {
            if (request >= 1001 || request <= 2500)
                return request;
            else
                return base.Handle(request);
        }

    }
}
