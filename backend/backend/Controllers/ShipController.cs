using backend.DTOs;
using backend.Interfaces;

namespace backend.Controllers
{
    public class ShipController : BaseController<ShipCrudDTO>
    {
        public ShipController(ICRUD<ShipCrudDTO> service) : base(service)
        {
        }
    }
}
