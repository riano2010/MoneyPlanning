using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPlanning.Models
{
    public class MoneyPlan
    {
        public ICollection<YearPlan> YearPlans { get; set; } = new List<YearPlan>();
    }
}
