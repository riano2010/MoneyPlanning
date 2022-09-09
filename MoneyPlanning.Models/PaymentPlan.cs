namespace MoneyPlanning.Models;

public class PaymentPlan
{
    public PaymentPlan(Payment payment)
    {
        Payment = payment;
    }

    /// <summary>
    /// Список расходов на выплату
    /// </summary>
    public IEnumerable<Expense> Expenses { get; set; } = new List<Expense>();
    
    /// <summary>
    /// Выплата
    /// </summary>
    public Payment Payment { get; set; }
}