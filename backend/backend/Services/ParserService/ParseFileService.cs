using Aspose.Cells;
using Aspose.Cells.Charts;
using AutoMapper;
using backend.Data;
using backend.DTOs;
using backend.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace backend.Services.Parser
{
    public class ParseFileService : BaseService, IFileParser
    {
        public ParseFileService(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<double[,]> FileParser(ParserDTO parser)
        {
            double[,] parseData;

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
                    Worksheet worksheet = wb.Worksheets[parser.WorkBookSheet];

                    parseData = await ParseData(worksheet);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return parseData;
        }

        /// <summary>
        /// Парсим данные с файла
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private async Task<double[,]> ParseData(Worksheet sheet)
        {
            double[,] data = new double[sheet.Cells.MaxDataRow, sheet.Cells.MaxDataColumn];
            double rows = sheet.Cells.MaxDataRow;
            double cols = sheet.Cells.MaxDataColumn;

            // каждая строка
            for (int i = 0; i < rows; i++)
            {
                // каждый столбец
                for (int j = 0; j < cols; j++)
                {
                    data[i, j] = sheet.Cells[i, j].DoubleValue;
                }
            }

            return data;
        }

        /// <summary>
        /// Поиск точек
        /// </summary>
        /// <param name="graphDataDTO"></param>
        /// <param name="fileId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        public async Task<Points> GetPoints(GraphDataDTO graphDataDTO, Guid fileId)
        {
            Points? points = new Points();

            // получение файла из бд
            Models.File file = context.File.FirstOrDefault(x => x.Id == fileId);

            if (file == null)
            {
                throw new Exception("Файл не найден");
            }

            try
            {
                GraphData graphData = await context.GraphData.FirstOrDefaultAsync(x => x.Id == graphDataDTO.GraphDataId);

                List<Points> x = PointX(file, graphData.Longitude);
                List<Points> y = PointY(file, graphData.Latitude);

                points = x.Where(num => y.Contains(num)).Distinct().FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw;
            }

            return points;
        }

        /// <summary>
        /// Находим строку по заданному значению
        /// </summary>
        /// <returns></returns>
        private List<Points> PointX(Models.File file, double point)
        {
            List<Points> x = new List<Points>();

            Workbook wb = new Workbook(file.FilePath);

            // лочим файл, с которым работаем
            using (FileLock fileLock = new FileLock(file.FilePath))
            {
                Worksheet ws = wb.Worksheets[0];

                foreach (Row row in ws.Cells.Rows)
                {
                    foreach (Cell cell in row)
                    {
                        if ((cell.Value.ToString() == Math.Round(point, 0).ToString()))
                        {
                            x.Add(new Points() { PointX = cell.Row , PointY = cell.Column});
                            break;
                        }
                    }
                }
            }

            return x;
        }

        /// <summary>
        /// Находим столбец по заданному значению
        /// </summary>
        /// <returns></returns>
        private List<Points> PointY(Models.File file, double point)
        {
            List<Points> y = new List<Points>();

            Workbook wb = new Workbook(file.FilePath);

            // лочим файл, с которым работаем
            using (FileLock fileLock = new FileLock(file.FilePath))
            {
                Worksheet ws = wb.Worksheets[1];

                foreach (Row row in ws.Cells.Rows)
                {
                    foreach (Cell cell in row)
                    {
                        if ((Math.Round(cell.DoubleValue, 0).ToString() == Math.Round(point, 0).ToString()))
                        {
                            y.Add(new Points() { PointX = cell.Row, PointY = cell.Column });
                            break;
                        }
                    }
                }
            }

            return y;
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
