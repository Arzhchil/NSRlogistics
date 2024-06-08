using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{

    public class RouteController : BaseController<Models.Route>
    {
        public RouteController(ICRUD<Models.Route> service) : base(service)
        {
        }
    }
}
