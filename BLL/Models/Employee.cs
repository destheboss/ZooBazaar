using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Employee : Person
    {
        private int bsn;
        private double wage;
        private Role role;
        private string city;
        private string street;
        private string zipCode;
        private string houseNumber;
        public int Bsn { get => this.bsn; set => this.bsn = value; }
        public double Wage { get => this.wage; set => this.wage = value; }
        public Role Role { get => this.role; set => this.role = value; }
        public string City { get => this.city; set => this.city = value; }
        public string Street { get => this.street; set => this.street = value; }
        public string ZipCode { get => this.zipCode; set => this.zipCode = value; }
        public string HouseNumber { get => this.houseNumber; set => this.houseNumber = value; }
        public List<Employee> employees { get; set; }

        //public Employee(int id, string email, string password, string firstName, string lastName,
        //    DateTime birthDate, int phoneNumber, int bsn, double wage, Role role, string city,
        //     string street, string zipCode, string houseNumber)
        //    : base(id, email, password, firstName, lastName, birthDate, phoneNumber)
        //{
        //    this.Bsn = bsn;
        //    this.Wage = wage;
        //    this.Role = role;
        //    this.City = city;
        //    this.Street = street;
        //    this.ZipCode = zipCode;
        //    this.HouseNumber = houseNumber;
        //}
        //Current Employee Creation
        public Employee(int id, string email, string password, string firstName, string lastName,
             int phoneNumber, int bsn, double wage, Role role, string city,
             string street, string zipCode, string houseNumber)
            : base(id, email, password, firstName, lastName, phoneNumber)
        {
            this.Bsn = bsn;
            this.Wage = wage;
            this.Role = role;
            this.City = city;
            this.Street = street;
            this.ZipCode = zipCode;
            this.HouseNumber = houseNumber;
        }
        public Employee(int id, string firstName, string lastName, int phoneNumber, string email, int wage)
            : base(id, email, firstName, lastName,  phoneNumber)
        {
            this.wage = wage;
        }
        
    }
}
