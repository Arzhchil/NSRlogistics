using AutoMapper;
using backend.Data;
using backend.Interfaces;
using backend.Static;
using static System.Net.Mime.MediaTypeNames;

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
        public async Task<Guid> UploadFile(IFormFile formFile)
        {
            // bad request
            if (!IsValidFile(formFile))
            {
                throw new Exception("Некорректный тип файла");
            }

            // путь к файлу
            string filePath = StaticData.FilePath/* + formFile.FileName*/;

            var path = Path.Combine(_appEnvironment.WebRootPath + filePath);

            DirectoryInfo dirInfo = new DirectoryInfo(path);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            using (FileStream fileStream = new FileStream(Path.Combine(path, formFile.FileName), FileMode.Create))
            {
                // копируем файл в папку Files
                await formFile.CopyToAsync(fileStream);
            }
            
            Models.File file = new Models.File()
            {
                FileName = Path.GetFileNameWithoutExtension(formFile.FileName),
                FilePath = Path.Combine(filePath, formFile.FileName),
                NameExtension = formFile.FileName
            };

            // сохранение файла в базу
            context.File.Add(file);
            await context.SaveChangesAsync();

            Guid response = context.File.FirstOrDefault(x => x.NameExtension == formFile.FileName).Id;
            return response;
        }

        /// <summary>
        /// Проверка валидности загружаемого файла
        /// </summary>
        /// <param name="formFile"></param>
        /// <returns></returns>
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
            if (!Path.GetExtension(formFile.FileName).Equals(".xlsx"))
            {
                return false;
            }

            return true;
        }
    }
}
