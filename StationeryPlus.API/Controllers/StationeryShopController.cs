using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StationeryPlus.IBusiness.Misc;

namespace StationeryPlus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationeryShopController : ControllerBase
    {
        private readonly IStationeryPlusService _stationaryShopService;

        public StationeryShopController(IStationeryPlusService stationaryShopService)
        {
            _stationaryShopService = stationaryShopService;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var stationaryShopInfo = await _stationaryShopService.List();
            return Ok(stationaryShopInfo);
        }
    }

}
