using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Persistence
{
    public class Context: IContext
    {
        private readonly string _connection;
        public Context()
        {
            _connection = DBConnection.ConnectionString;
        }
        public async Task<T> ExceProcAsync<T>(string prodName, object param, CommandType commandType)
        {
            using (SqlConnection db = new SqlConnection(_connection))
            {
                var res = await db.QueryFirstAsync<T>(prodName, param, commandType: commandType);
                return res;
            }
        }
    }
}
