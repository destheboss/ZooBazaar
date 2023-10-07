using BLL.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
	public class AnimalTypeManager
	{
		private readonly IAnimalTypeDataAccess _atda;

		public AnimalTypeManager(IAnimalTypeDataAccess atda)
		{
			_atda = atda;
		}
		public void AddChildTypeToDB(string name, int? parentID)
		{
			_atda.AddChildAnimalType(name, parentID);
		}

		public void AddParentTypeToDB(string name)
		{
			_atda.AddParentAnimalType(name);
		}

		public void RemoveTypeFromDB(int id)
		{
			_atda.DeleteType(id);
		}
		public List<AnimalType> GetAnimalTypes()
		{
			List<AnimalType> type = _atda.ReadAnimalTypes();
			return type;
		}
		public DataTable LoadTypes()
		{
			return _atda.LoadTypes();
		}

		public List<AnimalType> GetAnimalSubTypes()
		{
			return _atda.ReadSubAnimalTypes();
		}
	}
}
