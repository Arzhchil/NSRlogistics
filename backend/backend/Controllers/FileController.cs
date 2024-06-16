using backend.Data;
using backend.DTOs;
using backend.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly IFileUpload _fileUpload;
        private readonly IFindPoints _findPoints;
        public FileController(IFileUpload fileUpload, IFindPoints findPoints)
        {
            _fileUpload = fileUpload;
            _findPoints = findPoints;
        }

        /// <summary>
        /// сохранение файла на сервер
        /// </summary>
        /// <returns></returns>
        [HttpPost("/loadFile")]
        public async Task<IActionResult> LoadFile(IFormFile uploadFile)
        {
            Guid uploadedFileId = await _fileUpload.UploadFile(uploadFile);

            if (!string.IsNullOrEmpty(uploadedFileId.ToString()))
            {
                return Ok(uploadedFileId);
            }

            return BadRequest("Не удалось загрузить файл на сервер");
        }

        /// <summary>
        /// сохранение файла на сервер
        /// </summary>
        /// <returns></returns>
        [HttpGet("/getPoints")]
        public async Task<IActionResult> GetPoints(Guid StartId, Guid FinishId, Guid FileLongId, Guid FileLatId)
        {
            FindPointsDTO findPointsDTO = new FindPointsDTO();
            findPointsDTO.FileIds.AddRange([FileLongId, FileLatId]);
            findPointsDTO.GraphDataPoints.Add(new GraphDataDTO() { GraphDataId = StartId });
            findPointsDTO.GraphDataPoints.Add(new GraphDataDTO() { GraphDataId = FinishId });

            List<Points> points = await _findPoints.FindPoints(findPointsDTO);

            if (points != null)
            {
                return Ok(points);
            }

            return BadRequest("Не удалось загрузить файл на сервер");
        }
    }
}
