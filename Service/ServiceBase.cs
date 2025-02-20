namespace BikeRentalApp.Services
{
    public abstract class ServiceBase<T>
    {
        public abstract void Add(T item);
        public abstract void Delete(int id);
        public abstract List<T> GetAll();
    }
}
