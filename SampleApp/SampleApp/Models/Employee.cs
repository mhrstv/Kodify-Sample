using SampleApp.Interfaces;
namespace SampleApp.Models
{
    public class Employee : Person, IEmployee
    {
        public string EmployeeId { get; set; }
        public Department Department { get; set; }
        public decimal Salary { get; set; }

        public decimal CalculateYearlyBonus()
        {
            return Salary * 0.1m;
        }
    }
}