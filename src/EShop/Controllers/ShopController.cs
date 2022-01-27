using Core.Entity;
using Core.Queries;
using DAL.Queries;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IQueryHandler<GetAllShopsQuery, IList<Shop>> _getAllShopsQuery;
        public ShopController(
            IQueryHandler<GetAllShopsQuery, IList<Shop>> getAllShopsQuery)
        {
            _getAllShopsQuery = getAllShopsQuery;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllShops()
        {
            IList<Shop> shops = await _getAllShopsQuery.HandleAsync(new GetAllShopsQuery());

            return Ok(shops);
        }
    }
}
