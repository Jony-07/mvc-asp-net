using ticketEccommerce.Data.Base;
using ticketEccommerce.Models;

namespace ticketEccommerce.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDBContext context) : base(context)
        {

        }
    }
}
