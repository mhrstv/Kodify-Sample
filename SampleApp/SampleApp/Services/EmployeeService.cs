using SampleApp.Models;

namespace SampleApp.Services
{
    public class EmployeeService
    {
        private readonly List<Employee> _employees;
        private readonly Department _department;

        public EmployeeService(Department department)
        {
            _department = department;
            _employees = department.Employees;
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public Employee GetEmployeeById(string id)
        {
            return _employees.FirstOrDefault(e => e.EmployeeId == id);
        }
    }
}