using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryPlus.DataAccess.Entities.Misc
{
	public class ContactUsRequest
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Message { get; set; }
	}

	public class ContactUsResponse
	{
		public string Status { get; set; }
		public string Message { get; set; }
	}
}
