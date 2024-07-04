using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryPlus.DataAccess.Entities.Misc
{
    public class StationeryInfo
    {
        public int Id { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ContactEmail { get; set; }
        public string WebsiteLink { get; set; }
        public string Image { get; set; }
    }
}
