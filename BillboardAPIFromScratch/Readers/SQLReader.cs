using BillboardAPIFromScratch.Abstract;
using BillboardAPIFromScratch.Options;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace BillboardAPIFromScratch.Readers
{
    public class SQLReader : IReader
    {
        private readonly string _connectionstring;
        public SQLReader(IOptions<ConnectionStringOptions> options) => _connectionstring = options.Value.DefaultDatabase;
        public async Task<IEnumerable<TEntity>> QueryTEntityAsync<TEntity>(string query) => 
            await new SqlConnection(_connectionstring).QueryAsync<TEntity>(query, commandType: CommandType.Text, commandTimeout: 10);

        public async Task<TEntity> QuerySingleTEntityAsync<TEntity>(string query, object parameters) =>
            await new SqlConnection(_connectionstring).QuerySingleOrDefaultAsync<TEntity>(query, parameters, commandType: CommandType.Text, commandTimeout: 10);
    }
}