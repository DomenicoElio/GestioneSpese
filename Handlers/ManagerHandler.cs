using GestioneSpese.Entities;


namespace GestioneSpese.Handlers
{
    public class ManagerHandler : AbstractHandler
    {
        public override Refund Handle(Expense expense)
        {
            if (expense.Amount > 0 && expense.Amount <= 400)
            {
                return new Refund()
                {
                    Expense = expense,
                    Approved = true,
                    ApprovationLevel = "Manager",
                    RefundAmount = expense.Category.GetRefund(expense)
                };
            }
            else
            {
                return base.Handle(expense);
            }
        }
    }
}
