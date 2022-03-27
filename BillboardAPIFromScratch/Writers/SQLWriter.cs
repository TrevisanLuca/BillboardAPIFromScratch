using BillboardAPIFromScratch.Abstract;
using BillboardAPIFromScratch.Options;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace BillboardAPIFromScratch.Writers
{
    public class SQLWriter : IWriter
    {
        private readonly string _connectionstring;
        public SQLWriter(IOptions<ConnectionStringOptions> options) => _connectionstring = options.Value.DefaultDatabase;

        public async Task<int?> WriteInDB<TDto>(string query, TDto objectToWrite) =>
            (await new SqlConnection(_connectionstring).ExecuteScalarAsync(query, objectToWrite, commandTimeout: 10)) as int?;

        public async Task<int> DeleteInDB(string query, object parameters)
        {
            try
            {                
                return await new SqlConnection(_connectionstring).ExecuteAsync(query, parameters);
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
