namespace BillboardAPIFromScratch.Abstract
{
    public interface IWriter
    {
        Task<int?> WriteInDB<TDto>(string query, TDto objectToWrite);
        Task<int> DeleteInDB(string query, object parameters);
    }
}
