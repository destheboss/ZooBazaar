using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
	public interface ICredentialsDataAccess
	{
		public void AddProfile(int empID, string pass, string salt);
		public List<Credentials> ReadCredentials();
	}
}
