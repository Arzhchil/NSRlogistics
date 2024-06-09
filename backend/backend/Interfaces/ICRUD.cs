using Microsoft.AspNetCore.Mvc;

namespace backend.Interfaces
{
    public interface ICRUD<T>
    {
        Task<T> Get(Guid id);
        Task<ICollection<T>> GetList();
        Task<ActionResult<bool>> Change(Guid id, T newData);
        Task<ActionResult<bool>> Delete(Guid id);
        Task<ActionResult<bool>> Add(T newData);
    }
}
