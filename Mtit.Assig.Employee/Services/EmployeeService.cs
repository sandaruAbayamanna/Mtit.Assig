using Mtit.Assig.Employee.Data;
using Mtit.Assig.Employee.Models;

namespace Mtit.Assig.Employee.Services
{
    public class EmployeeService : IEmployeeService 
    {
        public List<Models.Employee> GetEmployees()
        {
            return EmployeeMockDataService.employees;
        }

        public Models.Employee? GetEmployee(int id)
        {
            return EmployeeMockDataService.employees.FirstOrDefault(x => x.Id == id);
        }

        public Models.Employee? AddEmployee(Models.Employee employee)
        {
            EmployeeMockDataService.employees.Add(employee);
            return employee;
        }

        public Models.Employee? UpdateEmployee(Models.Employee employee)
        {
            Models.Employee selectedEmployee = EmployeeMockDataService.employees.FirstOrDefault(x =>x.Id == employee.Id);
            if (selectedEmployee != null)
            {
                selectedEmployee.Address = employee.Address;
                selectedEmployee.Age = employee.Age;
                selectedEmployee.Name = employee.Name;
                selectedEmployee.Email = employee.Email;
                selectedEmployee.Type = employee.Type;
                return selectedEmployee;
            }
            return selectedEmployee;
        }

        public bool? DeleteEmployee(int id)
        {
            Models.Employee selectedEmployee = EmployeeMockDataService.employees.FirstOrDefault(x=>x.Id == id);
            if (selectedEmployee != null)
            {
                EmployeeMockDataService.employees.Remove(selectedEmployee);
                return true;
            }
            return false;
        }

    }
}
