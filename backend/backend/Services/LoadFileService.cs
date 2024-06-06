using backend.Data;
using backend.Interfaces;
using backend.Models;
using backend.Static;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace backend.Services
{
    /// <summary>
    /// Сервис сохранения файла на сервер
    /// </summary>
    public class LoadFileService : IFileUpload
    {
        DataContext _context;
        IWebHostEnvironment _appEnvironment;
        public LoadFileService(DataContext context, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        /// <summary>
        /// Метод сохранения файла на сервер
        /// </summary>
        /// <param name="formFile"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> UploadFile(IFormFile formFile)
        {
            if (!IsValidFile(formFile))
            {
                return false;
            }

            // путь к файлу
            string filePath = StaticData.FilePath + formFile.FileName;

            using (var fileStream = new FileStream(_appEnvironment.WebRootPath + filePath, FileMode.Create))
            {
                // копируем файл в папку Files
                await formFile.CopyToAsync(fileStream);
            }

            Models.File file = new Models.File()
            {
                FileName = Path.GetFileNameWithoutExtension(formFile.FileName),
                FilePath = filePath,
                NameExtension = formFile.FileName
            };

            // сохранение файла в базу
            _context.File.Add(file);
            await _context.SaveChangesAsync();

            return true;
        }

        private bool IsValidFile(IFormFile formFile)
        {
            if (formFile == null)
            {
                return false;
            }
            if (string.IsNullOrEmpty(Path.GetFileNameWithoutExtension(formFile.FileName)))
            {
                return false;
            }

            return true;
        }
    }
}
