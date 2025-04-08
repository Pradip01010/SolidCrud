using SolidCrud.Models;

namespace SolidCrud.Data
{
    public interface IUnitOfWork
    {
        IRepository<Product> Products { get; }
        Task<int> CompleteAsync();
        Task<int> SaveAsync(); 
    }
}


