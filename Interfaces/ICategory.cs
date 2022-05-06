using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Entities
{
    public interface ICategory
    {
        double Reimbursment { get; set; }

        double BaseCosts { get; set; }

    }
}
