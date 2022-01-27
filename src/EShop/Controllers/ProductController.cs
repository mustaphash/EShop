using Core.Entity;
using Core.Queries;
using DAL.Queries;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        private readonly IQueryHandler<GetAllProductsQuery, IList<Product>> _getAllProductsQuery;
        public ProductController(
            IQueryHandler<GetAllProductsQuery, IList<Product>> getAllProductsQuery)
        {
            _getAllProductsQuery = getAllProductsQuery;
        }

        [HttpGet(Name = "GetAllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            IList<Product> products = await _getAllProductsQuery.HandleAsync(new GetAllProductsQuery());

            return Ok(products);
        }
    }
}
