using StationeryPlus.CommonLibrary.Models.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryPlus.IBusiness.Misc
{
    public interface IStationeryPlusService
    {
        Task<List<StationeryInfoModel>> List();
    }
}
