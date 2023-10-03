using BLL.Interfaces;
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
        public bool Create(User user)
        {
            return data.Create(user);
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
