namespace backend.Interfaces
{
    public interface ICRUD<T>
    {
        T Get(string id);
        ICollection<T> GetList();
        void Change(string id, T newData);
        void Delete(string id);
        void Add(T newData);
    }
}
