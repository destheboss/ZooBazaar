using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Contract
    {
        public int ContractId { get; set; }
        public string ContractName { get; set; }
        public int Length { get; set; }
        public int AmountOfHours { get; set; }

        public Contract(int id, string name, int length, int amountofhours)
        {
            ContractId = id;
            ContractName = name;
            Length = length;
            AmountOfHours = amountofhours;
        }

        public Contract() { }

        public void Update(string name, int length, int amountofhours)
        {
            this.ContractName = name;
            this.Length = length;
            this.AmountOfHours = amountofhours;
        }
        public override string ToString()
        {
            return "Name: " + ContractName;
        }
    }
}
