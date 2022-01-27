using Core.Entity;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries
{
    public class GetAllClientsQueryHandler : IQueryHandler<GetAllClientsQuery, IList<Client>>
    {
        private readonly ShopContext _shopContext;
        public GetAllClientsQueryHandler(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }
        public async Task<IList<Client>> HandleAsync(GetAllClientsQuery query, CancellationToken cancellationToken = default)
        {
            List<Client> clients = await _shopContext.Clients.ToListAsync(cancellationToken);

            return clients;
        }
    }
}
