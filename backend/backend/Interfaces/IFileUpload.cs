using Microsoft.AspNetCore.Mvc;

namespace backend.Interfaces
{
    public interface IFileUpload
    {
        public Task<bool> UploadFile(IFormFile formFile);
    }
}
