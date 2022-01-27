using Core.Entity;
using Core.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Queries
{
    public class GetAllShopsQueryHandler : IQueryHandler<GetAllShopsQuery, IList<Shop>>
    {
        private readonly ShopContext _shopContext;
        public GetAllShopsQueryHandler(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }
        public async Task<IList<Shop>> HandleAsync(GetAllShopsQuery query, CancellationToken cancellationToken = default)
        {
            List<Shop> shops = await _shopContext.Shops.ToListAsync(cancellationToken);
            return shops;
        }
    }
}
