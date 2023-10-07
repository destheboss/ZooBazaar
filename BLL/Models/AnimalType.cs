using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
	public class AnimalType
	{
		private string name;
		private int id;
		private int? parentID;

		public AnimalType(int id, string name, int? parentID)
		{
			this.name = name;
			this.id = id;
			this.parentID = parentID;
		}

		public AnimalType() { }

		public int? GetParentID()
		{
			return parentID;
		}

		public string GetName()
		{
			return name;
		}

		public int GetID()
		{
			return id;
		}

		public override string ToString()
		{
			return name;
		}
	}
}
