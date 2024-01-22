using BLL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface ILocationDataAccess
	{
		public void AddChildAnimalLocation(string name, int? parentId);
		public void AddParentAnimalLocation(string name);
		public void DeleteLocation(int id);
		public List<AnimalLocation> ReadLocations();
		public DataTable LoadLocations();
		public List<AnimalLocation> ReadSubLocations();
		bool AreAnimalsInLocationExist(int locationId);
		bool AreChildLocationsExist(int parentId);

    }
}
