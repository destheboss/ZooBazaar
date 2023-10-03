using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Customer : Person
    {
        private int age;
        public int Age { get => this.age; set => this.age = value; }
        public Customer(int id, string email, string password, string firstName, string lastName,
             DateTime birthDate, int phoneNumber, int age)
             : base(id, email, password, firstName, lastName, birthDate, phoneNumber)
        {
            this.Age = age;
        }
    }
}
