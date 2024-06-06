using AutoMapper;
using backend.Data;
using backend.Interfaces;
using backend.Models;
using backend.Static;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace backend.Services.LoadService
{
    /// <summary>
    /// Сервис сохранения файла на сервер
    /// </summary>
    public class LoadFileService : BaseService, IFileUpload
    {
        IWebHostEnvironment _appEnvironment;

        public LoadFileService(DataContext context, IMapper mapper, IWebHostEnvironment appEnvironment)
            : base(context, mapper)
        {
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
            context.File.Add(file);
            await context.SaveChangesAsync();

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
