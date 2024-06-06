namespace backend.Models
{
    /// <summary>
    /// Модель файла
    /// </summary>
    /// <param name="id"></param>
    /// <param name="fileName"></param>
    /// <param name="filePath"></param>
    public class File
    {
        public int Id { get; set; }

        /// <summary>
        /// Имя файла без расширения
        /// </summary>
        public string FileName { get; set; } = null!;

        /// <summary>
        /// Имя файла с расширением
        /// </summary>
        public string NameExtension { get; set; } = null!;

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string FilePath { get; set; } = null!;
    }
}
