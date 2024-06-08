using backend.DTOs;
using backend.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    /// <summary>
    /// НУЖЕН ТОЛЬКО ДЛЯ ТЕСТОВ ПАРСИНГА
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ParseDataController : ControllerBase
    {
        private readonly IFileParser _fileParser;
        public ParseDataController(IFileParser fileParser)
        {
            _fileParser = fileParser;
        }

        /// <summary>
        /// парсинг файла(нужен для тестов, так то нахуй не сдался)
        /// </summary>
        /// <returns></returns>
        [HttpPost("/parseData")]
        public async Task<IActionResult> LoadFile([FromBody] ParserDTO parserDTO)
        {
            int[,] parseData = await _fileParser.FileParser(parserDTO);

            return Ok(parseData);
        }
    }
}
