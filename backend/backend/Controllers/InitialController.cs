using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InitialController : ControllerBase
    {
        private readonly IInitial _initial;
        public InitialController(IInitial initial)
        {
            _initial = initial;
        }

        /// <summary>
        /// просто пустой контроллер, для будущей архитектуры
        /// </summary>
        /// <returns></returns>
        [HttpGet("/initial")]
        public int Get()
        {
            return _initial.Hello();
        }
    }
}
