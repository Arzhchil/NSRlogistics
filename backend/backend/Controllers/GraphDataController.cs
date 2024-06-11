using backend.DTOs;
using backend.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphDataController : BaseController<GraphDataDTO>
    {
        public GraphDataController(ICRUD<GraphDataDTO> service) : base(service)
        {
        }
    }
}
