using backend.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace backend.Interfaces
{
    public interface IFindPoints
    {
        public Task<List<Points>> FindPoints(FindPointsDTO findPointsDTO);
    }
}
