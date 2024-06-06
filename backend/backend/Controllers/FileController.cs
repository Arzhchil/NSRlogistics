using backend.Data;
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
        public FileController(IFileUpload fileUpload)
        {
            _fileUpload = fileUpload;
        }

        /// <summary>
        /// сохранение файла на сервер
        /// </summary>
        /// <returns></returns>
        [HttpPost("/loadFile")]
        public async Task<IActionResult> LoadFile(IFormFile uploadFile)
        {
            bool isFileUpload = await _fileUpload.UploadFile(uploadFile);

            if (isFileUpload)
            {
                return Ok(isFileUpload);
            }

            return BadRequest(isFileUpload);
        }
    }
}
