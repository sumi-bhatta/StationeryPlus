using Microsoft.EntityFrameworkCore;
using StationeryPlus.CommonLibrary.Models.Misc;
using StationeryPlus.DataAccess.Data;
using StationeryPlus.IBusiness.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StationeryPlus.Business.Misc
{
    public class StationeryPlusService : IStationeryPlusService
    {
        private readonly ApplicationDBContext dbContext;

        public StationeryPlusService(ApplicationDBContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<List<StationeryInfoModel>> List()
        {
            var StationeryShops = await(from shop in dbContext.StationeryInfos
                                        select new StationeryInfoModel()
                                        {
                                            Id = shop.Id,
                                            SiteName = shop.SiteName,
                                            Description = shop.Description,
                                            Address = shop.Address,
                                            Phone = shop.Phone,
                                            ContactEmail = shop.ContactEmail,
                                            WebsiteLink = shop.WebsiteLink,
                                            Image = shop.Image,
                                        }

                                         ).ToListAsync();
            return StationeryShops;
        }

    }
}
