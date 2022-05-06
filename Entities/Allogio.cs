using GestioneSpese.Entities;
using GestioneSpese.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Entities
{
    internal class Allogio : ICategory
    {
        public double Reimbursment { get; set; }

        public double BaseCosts { get; set; }

    }
}
