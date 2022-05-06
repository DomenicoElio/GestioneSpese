using GestioneSpese.Entities;
using GestioneSpese.Interfaces;
using GestioneSpese.Repositories;
using GestioneSpese.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestioneSpese
{
    public class UserInteractions
    {

        static IRepository<Expenses> allExpenses = new RepositoryExpensesFile();

        static IRepository<Expenses> updatedExpenses = new RepositoryExpensesFile();

        internal static void Start()
        {
            bool continua = true;
            while (continua) 
            {
                int scelta = Menu();
                switch (scelta)
                {
                    case 1:
                        PrintAllExpenses();
                        break;
                    case 2:
                        SortExpenses();
                        break;
                    case 3:
                        CalculateReimbursement();
                        break;
                    case 4:
                        UpdateFile();
                        break;
                    case 0:
                        continua = false;
                        Console.WriteLine("Arrivederci");
                        break;
                    default:
                        Console.WriteLine("Scelta errata.");
                        break;
                }
            }
        }

        private static void PrintAllExpenses()
        {
            var listOfExpenses = allExpenses.GetAll();
            if (listOfExpenses.Count == 0)
            {
                Console.WriteLine("No Expenses");
            }
            else
            {
                Console.WriteLine("These are all the expenses, would you like to sort them?");
                foreach (var r in listOfExpenses)
                {
                    r.Print();
                }
            }

        }

        private static void SortExpenses()
        {
            ManagerHandler manager= new ManagerHandler();
            OperationalManager opManager = new OperationalManager();
            CEOHandler ceo = new CEOHandler();

            Expenses set = new Expenses();
            double request = set.Costs;
            manager.SetNext(opManager).SetNext(ceo);

        }

        public static double CalculateReimbursement()
        {

            Expenses set = new Expenses();
            double request = set.Costs;

            Expenses reCalculated = new Expenses();
            string cat = reCalculated.Category;

            if (cat == "Viaggio")
                return request + 50;
            else
                if (cat == "Allogio")
                return request;
            else
                if (cat == "Vitto")
                return 70%request;
            else
                if (cat == "Altro")
                return 10%request;


        }

        private static void UpdateFile()
        {
            throw new NotImplementedException();
        }

        private static int Menu()
        {
            Console.WriteLine("-----------MENU----------");
            Console.WriteLine("1.Check all of the Expenses");
            Console.WriteLine("2.See Who Approved Them");
            Console.WriteLine("3.Check for what Reimburment if owed");
            Console.WriteLine("4.Save the modifications in a file");
            Console.WriteLine("\n0.Exit");
            Console.WriteLine("\nInserisci la tua scelta:");
            //int sceltaUtente=int.Parse(Console.ReadLine());
            int sceltaUtente;
            while (!(int.TryParse(Console.ReadLine(), out sceltaUtente) /*&& sceltaUtente >= 0 && sceltaUtente <= 3*/))
            {
                Console.WriteLine("Please select a number from 1 to 4");
            }
            return sceltaUtente;
        }
    }
}
