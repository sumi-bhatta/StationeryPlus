using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryPlus.DataAccess.Entities.Misc
{
	public class FaqItem
	{
		public string Question { get; set; }
		public string Answer { get; set; }
	}

	public class GetFaqResponse
	{
		public List<FaqItem> Faqs { get; set; }
	}
}
