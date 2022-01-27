using Core.Entity;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries
{
    public class GetAllProductsQueryHandler : IQueryHandler<GetAllProductsQuery, IList<Product>>
    {
        private readonly ShopContext _shopContext;
        public GetAllProductsQueryHandler(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }
        public async Task<IList<Product>> HandleAsync(GetAllProductsQuery query, CancellationToken cancellationToken = default)
        {
            List<Product> products = await _shopContext.Products.ToListAsync(cancellationToken);

            return products;
        }
    }
}
