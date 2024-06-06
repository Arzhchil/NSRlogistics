namespace backend.DTOs
{
    /// <summary>
    /// Модель файла DTO
    /// </summary>
    /// <param name="fileName"></param>
    /// <param name="filePath"></param>
    public record FileDTO(string FileName, string FileExtension, string FilePath);
}
