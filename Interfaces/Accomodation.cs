using GestioneSpese.Entities;

namespace GestioneSpese.Factory
{
    public class Accomodation : ICategory
    {
        public string Name { get; set; } = "Accomodation";

        public double GetRefund(Expense expense)
        {
            return expense.Amount;
        }
    }
}
