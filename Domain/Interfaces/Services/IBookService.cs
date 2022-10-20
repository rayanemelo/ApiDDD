using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IBookService
    {
        Task<BookEntity> Get(Guid id);
        Task<IEnumerable<BookEntity>> GetAll();
        Task<BookEntity> Post(BookEntity book);
        Task<BookEntity> Put(BookEntity book);
        Task<bool> Delete(Guid id);
    }
}
