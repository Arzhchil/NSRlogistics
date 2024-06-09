using AutoMapper;
using backend.Data;
using backend.Interfaces;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Services.CRUDService
{
    public class RouteService : BaseService, ICRUD<Models.Route>
    {
        public RouteService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ActionResult<bool>> Add(Models.Route newData)
        {
            context.Add(newData);
            await context.SaveChangesAsync();

            return true;
        }

        public async Task<ActionResult<bool>> Change(Guid id, Models.Route newData)
        {
            context.Routes.Update(newData);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            var route = await Get(id);
            context.Routes.Remove(route);
            await context.SaveChangesAsync();

            return true;
        }

        public async Task<Models.Route> Get(Guid id)
        {
            return await context.Routes.FindAsync(id);
        }

        public Task<ICollection<Models.Route>> GetList()
        {
            throw new NotImplementedException();
        }
    }
    
}
