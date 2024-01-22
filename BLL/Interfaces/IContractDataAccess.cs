using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IContractDataAccess
    {
        bool CreateContract(Contract contract);
        Contract GetContract(int id);
        List<Contract> GetAllContracts();
        bool UpdateContract(int id, string name, int length, int amountofhours);
        bool DeleteContract(int id);
        int GetLastAssignedContractId();
    }
}
