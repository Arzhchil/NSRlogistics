using Microsoft.AspNetCore.Mvc;

namespace backend.Interfaces
{
    public interface IFileUpload
    {
        public Task<int> UploadFile(IFormFile formFile);
    }
}
