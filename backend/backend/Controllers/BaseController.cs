using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase
    {
        public readonly ICRUD<T> _service;

        public BaseController(ICRUD<T> service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        // GET: api/<GameServersController>
        [HttpGet]
        public async virtual Task<IEnumerable<T>> Get()
        {
            return await _service.GetList();
        }

        // GET api/<GameServersController>/5
        [HttpGet("{id}")]
        public async virtual Task<T> Get(Guid id)
        {
            return await _service.Get(id);
        }

        // POST api/<GameServersController>
        [HttpPost]
        public async virtual Task<ActionResult<bool>> Post([FromBody] T value)
        {
            return await _service.Add(value);
        }

        // PUT api/<GameServersController>/5
        [HttpPut("{id}")]
        public async virtual Task<ActionResult<bool>> Put(Guid id, [FromBody] T value)
        {
            return await _service.Change(id, value);
        }

        // DELETE api/<GameServersController>/5
        [HttpDelete("{id}")]
        public async virtual Task<ActionResult<bool>> Delete(Guid id)
        {
            return await _service.Delete(id);
        }
    }
}
