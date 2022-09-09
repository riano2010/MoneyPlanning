using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyPlanning.Models;

namespace MoneyPlanning.Tests
{
    [TestClass]
    public class MoneyPlanTests
    {
        [TestMethod]
        public void When_AddYearPlan_Then_CanReadIt()
        {
            var moneyPlan = new MoneyPlan();
            moneyPlan.YearPlans.Add(new YearPlan
            {
                Year = 2022
            });

            Assert.AreEqual(1, moneyPlan.YearPlans.Count());

            var plan = moneyPlan.YearPlans.Single();

            Assert.AreEqual(2022, plan.Year);
        }

        [TestMethod]
        public void When_AddMonthPlan_Then_CanReadIt()
        {
            var yearPlan = new YearPlan
            {
                Year = 2022
            };

            yearPlan.MonthPlans.Add(new MonthPlan()
            {
                Month = 5
            });

            var moneyPlan = new MoneyPlan();
            moneyPlan.YearPlans.Add(yearPlan);

            var foundYear = moneyPlan.YearPlans.Single(_ => _.Year == 2022);
            var monthPlan = foundYear.MonthPlans.Single(_ => _.Month == 5);
        }
    }
}