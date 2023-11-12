using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Credentials
    {
        private int empID;
        public int EmpID { get { return empID; } set { empID = value; } }

        private string salt;
        public string Salt { get { return salt;} set { salt = value; } }

        private string hashPass;
        public string HashPass { get { return hashPass; } set { hashPass = value; } }

        public Credentials() { }

        public Credentials(int empID, string hashPass, string salt)
        {
            this.empID = empID;
            this.salt = salt;   
            this.hashPass = hashPass;
        }
    }
}
