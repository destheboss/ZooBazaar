using BLL.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public class ContractManager
    {
        private IContractDataAccess _ContractData;

        public ContractManager(IContractDataAccess contractDataAccess)
        {
            _ContractData = contractDataAccess;
        }
        public bool CreateContract(int id, string name, int length, int amountofhours)
        {
            try
            {
                Contract contract = new Contract(0, name, length, amountofhours);
                _ContractData.CreateContract(contract);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public Contract GetContract(int id)
        {
            Contract contract = _ContractData.GetContract(id);
            return contract;
        }

        public List<Contract> GetContracts()
        {
            List<Contract> contracts = _ContractData.GetAllContracts();
            return contracts;
        }

        public bool DeleteContract(int id)
        {
            if (_ContractData.DeleteContract(id) != true)
            {
                return false;
            }
            return true;
        }

        public bool UpdateContract(int id, string name, int length, int amountofhours)
        {
            try
            {
                _ContractData.UpdateContract(id, name, length, amountofhours);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public int GetLastAssignedContractId()
        {
            return _ContractData.GetLastAssignedContractId();
        }
    }
}
