namespace backend.Interfaces
{
    public interface ICRUD<T>
    {
        T Get(Guid id);
        ICollection<T> GetList();
        void Change(Guid id, T newData);
        void Delete(Guid id);
        void Add(T newData);
    }
}
