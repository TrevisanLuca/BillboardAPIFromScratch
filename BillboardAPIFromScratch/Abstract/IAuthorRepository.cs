using BillboardAPIFromScratch.Domain;
using BillboardAPIFromScratch.Dtos;

namespace BillboardAPIFromScratch.Abstract
{
    public interface IAuthorRepository
    {
        IAsyncEnumerable<SimpleAuthorDto> GetAllAsync();
        Task<SimpleAuthorDto?> GetByIdAsync(int id);
        Task<int?> CreateAsync(AuthorForCreateDto author);
        Task<int> DeleteAsync(int id);
        Task<int?> UpdateAsync(AuthorForUpdateDto author);
    }
}
