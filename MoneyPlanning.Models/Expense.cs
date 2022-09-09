namespace MoneyPlanning.Models
{
    public class Expense
    {
        public Expense(Payment payment)
        {
            Payment = payment;
        }

        /// <summary>
        /// Ид покупки
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Цена покупки
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Дата покупки
        /// </summary>
        public DateTime Date{ get; set; }

        /// <summary>
        /// Выплата, к которой относится покупка
        /// </summary>
        public Payment Payment { get; set; }
    }
}
