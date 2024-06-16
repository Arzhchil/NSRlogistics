using AutoMapper;
using backend.Data;
using backend.DTOs;
using backend.Interfaces;
using backend.Services.Parser;
using Microsoft.AspNetCore.Mvc;

namespace backend.Services.FindPathService
{
    public class FindPointsService : BaseService, IFindPoints
    {
        private readonly IFileParser _fileParser;
        public FindPointsService(DataContext context, IMapper mapper, IFileParser fileParser) : base(context, mapper)
        {
            _fileParser = fileParser;
        }

        public async Task<List<Points>> FindPoints(FindPointsDTO findPointsDTO)
        {
            List<Points> lPoints = new List<Points>();

            lPoints.Add(await _fileParser.GetPoints(findPointsDTO.GraphDataPoints[0], findPointsDTO.FileIds[0]));
            lPoints.Add(await _fileParser.GetPoints(findPointsDTO.GraphDataPoints[1], findPointsDTO.FileIds[1]));

            return lPoints;
        }
    }
}
