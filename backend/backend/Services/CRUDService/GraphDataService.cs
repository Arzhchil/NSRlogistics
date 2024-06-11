using AutoMapper;
using backend.Data;
using backend.DTOs;
using backend.Interfaces;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Services.CRUDService
{
    public class GraphDataService : BaseService, ICRUD<GraphDataDTO>
    {
        public GraphDataService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public Task<ActionResult<bool>> Add(GraphDataDTO newData)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<bool>> Change(Guid id, GraphDataDTO newData)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<bool>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<GraphDataDTO> Get(Guid id)
        {
            GraphData? graphData = await context.GraphData.FirstOrDefaultAsync(x => x.Id == id);

            if (graphData == null)
            {
                throw new Exception("Не удалось найти точку");
            }

            GraphDataDTO graphDataDTO = mapper.Map(graphData, new GraphDataDTO());

            return graphDataDTO;
        }

        public async Task<ICollection<GraphDataDTO>> GetList()
        {
            List<GraphData> lGraphData = await context.GraphData.ToListAsync();

            List<GraphDataDTO> lGraphDataDTO = mapper.Map(lGraphData, new List<GraphDataDTO>());

            if (lGraphDataDTO == null)
            {
                throw new Exception("Smth went wrong");
            }

            return lGraphDataDTO;
        }
    }
}
