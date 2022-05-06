using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Handler
{
    internal class OperationalManager : AbstractHandler
    {
        public override double Handle(double request)
        {
            if (request >= 401 || request <= 1001)
                return request;
            else
                return base.Handle(request);
        }

    }
}
