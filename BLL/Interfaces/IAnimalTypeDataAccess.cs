using BLL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface IAnimalTypeDataAccess
	{
		public void AddChildAnimalType(string name, int? parentId);
		public void AddParentAnimalType(string name);
		public void DeleteType(int id);
		public List<AnimalType> ReadAnimalTypes();
		public DataTable LoadTypes();
		public List<AnimalType> ReadSubAnimalTypes();
	}
}
