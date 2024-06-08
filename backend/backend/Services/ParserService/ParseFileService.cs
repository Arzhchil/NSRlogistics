using Aspose.Cells;
using AutoMapper;
using backend.Data;
using backend.DTOs;
using backend.Interfaces;
using backend.Models;

namespace backend.Services.Parser
{
    public class ParseFileService : BaseService, IFileParser
    {
        public ParseFileService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<int[,]> FileParser(ParserDTO parser)
        {
            int[,] parseData;

            // получение файла из бд
            Models.File file = context.File.FirstOrDefault(x => x.Id == parser.FileId);

            if (file == null)
            {
                throw new Exception("Файл не найден");
            }

            try
            {
                Workbook wb = new Workbook(file.FilePath);

                // лочим файл, с которым работаем
                using (FileLock fileLock = new FileLock(file.FilePath))
                {
                    Worksheet worksheet = wb.Worksheets[0];

                    parseData = await ParseData(worksheet);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return parseData;
        }

        /// <summary>
        /// Парсим данные с файла
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private async Task<int[,]> ParseData(Worksheet sheet)
        {
            int[,] data = new int[269, 269];
            int rows = sheet.Cells.MaxDataRow;
            int cols = sheet.Cells.MaxDataColumn;

            // каждая строка
            for (int i = 0; i < rows; i++)
            {
                // каждый столбец
                for (int j = 0; j < cols; j++)
                {
                    data[i, j] = (int)sheet.Cells[i, j].Value;
                }
            }

            return data;
        }

        /// <summary>
        /// Лок файла с которым работаем
        /// </summary>
        private class FileLock : IDisposable
        {
            private FileStream _lock;
            public FileLock(string path)
            {
                if (System.IO.File.Exists(path))
                {
                    _lock = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
                    IsLocked = true;
                }
            }
            public bool IsLocked { get; set; }
            public void Dispose()
            {
                if (_lock != null)
                {
                    _lock.Dispose();
                    IsLocked = false;
                }
            }
        }
    }
}
