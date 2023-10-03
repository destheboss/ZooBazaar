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
