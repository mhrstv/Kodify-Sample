namespace SampleApp.Interfaces
{
    public interface IEmployee
    {
        string EmployeeId { get; set; }
        decimal Salary { get; set; }
        decimal CalculateYearlyBonus();
    }
}