using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public abstract class Person
    {
        private int id;
        private string email;
        private string password;
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private int phoneNumber;

        public int Id { get => this.id; set => this.id = value; }
        public string Email { get => this.email; set => this.email = value; }
        public string Password { get => this.password; set => this.password = value; }
        public string FirstName { get => this.firstName; set => this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public DateTime BirthDate { get => this.birthDate; set => this.birthDate = value; }
        public int PhoneNumber { get => this.phoneNumber; set => this.phoneNumber = value; }

        public Person(int id, string email, string password, string firstName, string lastName, DateTime birthDate, int phoneNumber)
        {
            this.Id = id;
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.PhoneNumber = phoneNumber;
        }
    }
}
