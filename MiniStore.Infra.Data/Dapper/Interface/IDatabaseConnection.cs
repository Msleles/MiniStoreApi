using System.Data;

namespace MiniStore.Infra.Data.Dapper.Interface
{
    public interface IDatabaseConnection : IDisposable
    {
        IEnumerable<T> Query<T>(string sql, object parameters = null);
        int Execute(string sql, object parameters = null);
        T ExecuteScalar<T>(string sql, object parameters = null);
        IDbTransaction BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
    }
}
