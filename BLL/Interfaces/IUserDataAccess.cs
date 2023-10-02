using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserDataAccess
    {






        //DESKTOP AUTHENTICATION
        void SetSetting(string key, dynamic? value);
        dynamic? GetSetting(string key);
    }
}
