using AutoMapper;
using backend.Data;
using backend.Interfaces;
using backend.Models;

namespace backend.Services.CRUDService
{
    public class RouteService : BaseService, ICRUD<Models.Route>
    {
        public RouteService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public void Add(Models.Route newData)
        {
            context.Add(newData);
            context.SaveChanges();
        }

        public void Change(Guid id, Models.Route newData)
        {
            context.Routes.Update(newData);
        }

        public void Delete(Guid id)
        {
            var route = Get(id);
            context.Routes.Remove(route);
            context.SaveChanges();
        }

        public Models.Route Get(Guid id)
        {
            return context.Routes.Find(id);
        }

        public ICollection<Models.Route> GetList()
        {
            throw new NotImplementedException();
        }
    }
    
}
