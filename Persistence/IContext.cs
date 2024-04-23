using System.Data;

namespace Persistence
{
    public interface IContext
    {
        Task<T> ExceProcAsync<T>(string prodName, object param, CommandType commandType);
    }
}
