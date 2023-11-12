using BLL.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
	public class CredentialsManager
	{
		private readonly ICredentialsDataAccess _cda;

		public CredentialsManager(ICredentialsDataAccess cda) 
		{
			_cda = cda;
		}

		public void AddProfile(int empID, string pass, string salt)
		{
			_cda.AddProfile(empID, pass, salt);
		}

		public List<Credentials> ReadCredentials()
		{
			return _cda.ReadCredentials();
		}
	}
}
