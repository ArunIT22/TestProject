using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class EmployeeService
    {
        private readonly Employee _employee = null;

        public EmployeeService()
        {
            _employee = new Employee();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employee.GetEmployees();
        }

        public Employee GetEmployee(int id)
        {
            return _employee.GetEmployees().FirstOrDefault(e => e.Id == id);
        }

        public void AddEmployee(Employee employee)
        {
            if (employee != null)
            {
                _employee.GetEmployees().Add(employee);
            }
        }

        public void DeleteEmployee(int id)
        {
            var searchedEmployee = GetEmployee(id);
            if(searchedEmployee != null)
            {
                _employee.GetEmployees().Remove(searchedEmployee);
            }
        }
    }
}
