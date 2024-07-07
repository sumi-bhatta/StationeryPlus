using Microsoft.EntityFrameworkCore;

namespace StationeryPlus.DataAccess.Data
{
	public class ApplicationDBContext :DbContext
	{
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options)
		{
                    
        }

		public DbSet<Entities.Misc.StationeryInfo> StationeryInfos { get; set; }
	}
}
