using BLL.Models;
using BLL.Models.AutoSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserDataAccess
    {
        bool CreateEmployee(Employee employee);
        bool CreateCustomer(Customer customer);
        bool CheckLogIn(string username, string password, out int id);
        Employee? GetEmployeeById(int id);
        List<Employee> GetAllEmployees();
        bool UpdateEmployee(Employee employee);
        void EmployeeSelfUpdate(int Id, string Email, int PhoneNumber, string City, string Street, string ZipCode, string HouseNumber);
        bool DeleteEmployee(int id);
        //DESKTOP AUTHENTICATION
        void SetSetting(string key, dynamic? value);
        dynamic? GetSetting(string key);
        bool CanEmpBeScheduled(DateTime day, int empid);
        bool DeleteEmployeeShift(int id);
        int DoesEmployeehaveMaxHours(DateTime startofweek, int empid);
        List<Employee> GetAllAssignedEmployees(Shift shift);
        List<Employee> GetAllAvailableEmployees(Shift shift);
        List<int> GetEmployeeswithleastshifts(DateTime startofweek);
    }
}
