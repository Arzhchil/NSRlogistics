using Microsoft.AspNetCore.Mvc;

namespace backend.Interfaces
{
    public interface IFileUpload
    {
        public Task<Guid> UploadFile(IFormFile formFile);
    }
}
