namespace MoneyPlanning.Models;

/// <summary>
/// План на год
/// </summary>
public class YearPlan
{
    /// <summary>
    /// Год
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// Месячные планы
    /// </summary>
    public ICollection<MonthPlan> MonthPlans { get; } = new List<MonthPlan>();
}