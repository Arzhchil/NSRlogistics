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
        public virtual IEnumerable<T> Get()
        {
            return _service.GetList();
        }

        // GET api/<GameServersController>/5
        [HttpGet("{id}")]
        public virtual T Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST api/<GameServersController>
        [HttpPost]
        public virtual void Post([FromBody] T value)
        {
            _service.Add(value);
        }

        // PUT api/<GameServersController>/5
        [HttpPut("{id}")]
        public virtual void Put(Guid id, [FromBody] T value)
        {
            _service.Change(id, value);
        }

        // DELETE api/<GameServersController>/5
        [HttpDelete("{id}")]
        public virtual void Delete(Guid id)
        {
            _service.Delete(id);
        }
    }
}
