using Core.Entity;
using Core.Queries;
using DAL.Queries;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Controllers
{
    [ApiController]
    [Route("clients")]
    public class ClientController : ControllerBase
    {
        private readonly IQueryHandler<GetAllClientsQuery, IList<Client>> _getAllClientsQuery;
        public ClientController(
            IQueryHandler<GetAllClientsQuery, IList<Client>> getAllClientsQuery)
        {
            _getAllClientsQuery = getAllClientsQuery;
        }

        [HttpGet(Name = "GetAllClients")]
        public async Task<IActionResult> GetAllClients()
        {
            IList<Client> clients = await _getAllClientsQuery.HandleAsync(new GetAllClientsQuery());

            return Ok(clients);
        }
    }
}
