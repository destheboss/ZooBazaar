using BLL.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public class UserManager
    {
        public IUserDataAccess data;

        public UserManager(IUserDataAccess data)
        {
            this.data = data;
        }
        public bool CreateEmployee(Employee employee)
        {
            return data.CreateEmployee(employee);
        }

        public bool CreateCustomer(Customer customer)
        {
            return data.CreateCustomer(customer);
        }
        public bool CheckLogIn(string username, string password, out int id)
        {
            return data.CheckLogIn(username, password, out id);
        }
        public Employee? GetEmployeeById(int id)
        {
            return data.GetEmployeeById(id);
        }
        public List<Employee> GetAllEmployees() {
            return data.GetAllEmployees();
        }
        public bool UpdateEmployee(Employee employee) { 
            return data.UpdateEmployee(employee);
        }
        public bool DeleteEmployee(int id) { 
            return data.DeleteEmployee(id); 
        }





        //DESKTOP AUTHENTICATION
        public dynamic? GetSetting(string key)
        {
            return data.GetSetting(key);
        }
        public void SetSetting(string key, dynamic? value)
        {
            data.SetSetting(key, value);
        }
    }
}
