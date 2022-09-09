namespace MoneyPlanning.Models;

public class Payment
{
    /// <summary>
    /// Ид выплаты
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Дата выплаты
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Сумма выплаты
    /// </summary>
    public decimal Sum { get; set; }
}