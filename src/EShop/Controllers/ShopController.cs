using Core.Entity;
using Core.Queries;
using DAL.Queries;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Controllers
{
    [ApiController]
    [Route("shops")]
    public class ShopController : ControllerBase
    {
        private readonly IQueryHandler<GetAllShopsQuery, IList<Shop>> _getAllShopsQuery;
        public ShopController(
            IQueryHandler<GetAllShopsQuery, IList<Shop>> getAllShopsQuery)
        {
            _getAllShopsQuery = getAllShopsQuery;
        }

        [HttpGet(Name = "GetAllShops")]
        public async Task<IActionResult> GetAllShops()
        {
            IList<Shop> shops = await _getAllShopsQuery.HandleAsync(new GetAllShopsQuery());

            return Ok(shops);
        }
    }
}
