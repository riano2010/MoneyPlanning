namespace MoneyPlanning.Models;

/// <summary>
/// План на месяц
/// </summary>
public class MonthPlan
{
    /// <summary>
    /// Месяц
    /// </summary>
    public int Month { get; set; }

    /// <summary>
    /// Выплаты
    /// </summary>
    public IEnumerable<PaymentPlan> Plans { get; set; } = new List<PaymentPlan>();
}