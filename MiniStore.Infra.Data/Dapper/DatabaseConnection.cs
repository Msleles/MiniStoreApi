using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using MiniStore.Infra.Data.Dapper.Interface;
using System.Data;

namespace MiniStore.Infra.Data.Dapper
{
    public class DatabaseConnection : IDatabaseConnection
    {
        private readonly string _connectionString;
        private IDbConnection _connection;
        private IDbTransaction _transaction;

        public DatabaseConnection(IOptions<DataBaseConnectionStringOptions> options)
        {
            _connectionString = options.Value.ConnectionString;
        }

        public IDbConnection GetOpenConnection()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
                _transaction = _connection.BeginTransaction();
            }
            else if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
                _transaction = _connection.BeginTransaction();
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
                return connection.Execute(sql, parameters, _transaction);
            }
        }

        public T ExecuteScalar<T>(string sql, object parameters = null)
        {
            using (var connection = GetOpenConnection())
            {
                return connection.ExecuteScalar<T>(sql, parameters, _transaction);
            }
        }

        public IEnumerable<T> Query<T>(string sql, object parameters = null)
        {
            using (var connection = GetOpenConnection())
            {
                return connection.Query<T>(sql, parameters, _transaction);
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
            _connection?.Dispose();
        }
    }
}
