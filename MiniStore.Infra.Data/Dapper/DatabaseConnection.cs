using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using MiniStore.Infra.Data.Dapper.Interface;
using System.Data;

namespace MiniStore.Infra.Data.Dapper
{
    public class DatabaseConnection : IDatabaseConnection
    {
        private  IDbConnection _connection;
        private IDbTransaction _transaction;
        private readonly IOptions<DataBaseConnectionStringOptions> _options;

        public DatabaseConnection(IDbConnection connection, 
            IOptions<DataBaseConnectionStringOptions> options, IDbTransaction transaction)
        {
            _options = options;
            _connection = connection;
            _transaction = transaction;
        }

        public IDbConnection GetOpenConnection()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(_options.Value.ConnectionString);
                _connection.Open();
            }
            else if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }

            return _connection;
        }

        public void CloseConnection()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public int Execute(string sql, object parameters = null)
        {
            using (var connection = GetOpenConnection())
            {
                return connection.Execute(sql, parameters);
            }
        }

        public T ExecuteScalar<T>(string sql, object parameters = null)
        {
            using (var connection = GetOpenConnection())
            {
                return connection.ExecuteScalar<T>(sql, parameters);
            }
        }

        public IEnumerable<T> Query<T>(string sql, object parameters = null)
        {
            using (var connection = GetOpenConnection())
            {
                return connection.Query<T>(sql, parameters);
            }
        }

        public IDbTransaction BeginTransaction()
        {
            if (_transaction == null)
            {
                _transaction = GetOpenConnection().BeginTransaction();
            }

            return _transaction;
        }

        public void CommitTransaction()
        {
            _transaction?.Commit();
            _transaction = null;
        }

        public void RollbackTransaction()
        {
            _transaction?.Rollback();
            _transaction = null;
        }

        public void Dispose()
        {
            CloseConnection();
            _connection.Dispose();
        }      
    }
}
