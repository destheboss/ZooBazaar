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
	public class LocationManager
	{
		private readonly ILocationDataAccess _lda;

		public LocationManager(ILocationDataAccess lda)
		{
			_lda = lda;
		}
		public void AddChildLocationToDB(string name, int? parentID)
		{
			_lda.AddChildAnimalLocation(name, parentID);
		}

		public void AddParentLocationToDB(string name)
		{
			_lda.AddParentAnimalLocation(name);
		}

		public void RemoveLocationFromDB(int id)
		{
			_lda.DeleteLocation(id);
		}

		public List<AnimalLocation> GetLocations()
		{
			List<AnimalLocation> location = _lda.ReadLocations();
			return location;
		}
		public DataTable LoadLocations()
		{
			return _lda.LoadLocations();
		}

		public List<AnimalLocation> GetAnimalSubLocation()
		{
			return _lda.ReadSubLocations();
		}
	}
}
