using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }
        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }

        public Worker(string firstname, string lastname, decimal weekSalary, decimal hoursPerDay)
            : base(firstname, lastname)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = hoursPerDay;
        }

        private decimal SalaryPerHour()
        {
            var daySalary = WeekSalary / 5;
            var hourSalary = daySalary / WorkHoursPerDay;
            return hourSalary;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"Week Salary: {WeekSalary:F2}\n" +
                $"Hours per day: {WorkHoursPerDay:F2}\n" +
                $"Salary per hour: {SalaryPerHour():F2}";
        }
    }
}
