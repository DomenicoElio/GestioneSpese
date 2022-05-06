using GestioneSpese.Entities;
using GestioneSpese.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneSpese.Repositories
{
    internal class RepositoryExpensesFile : IRepositorySpese
    {

        string path = @"C:\Users\domeb\source\repos\GestioneSpese\Repositories\spese.txt";

        public bool Add(Expenses item)
        {
            throw new NotImplementedException();
        }

        public List<Expenses> GetAll()
        {
            List<Expenses> expenses = new List<Expenses>();
            using (StreamReader sr = new StreamReader(path))
            {
                string contenutoFile = sr.ReadToEnd();

                if (string.IsNullOrEmpty(contenutoFile))//(contenutoFile==null || contenutoFile == "")
                {
                    return expenses;
                }
                else
                {
                    Console.WriteLine("Your Employees have not sustained any costs this week.");
                }
                return expenses;
            }
        }

        /*string path = @"C:\Users\domeb\source\repos\GestioneSpese\Repositories\spese_elaborate.txt";
        public bool Add(Rettangolo item)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"{item.Name},{item.Base},{item.Altezza}");
            }
            return true;
        }*/

    }
}
