using Microsoft.Extensions.Logging;

namespace MiniStore.Application.Services
{
    public abstract class BaseService
    {
        protected readonly ILogger<BaseService> _logger;
        protected readonly List<string> _notifications;

        public BaseService(ILogger<BaseService> logger, List<string> notifications)
        {
            _logger = logger;
            _notifications = notifications;
        }

        protected void AddNotification(string message)
        {
            _notifications.Add(message);
        }

        protected IEnumerable<string> GetNotifications()
        {
            return _notifications;
        }

        protected void ClearNotifications()
        {
            _notifications.Clear();
        }

        protected void LogInformation(string message)
        {
            _logger.LogInformation(message);
        }

        protected void LogWarning(string message)
        {
            _logger.LogWarning(message);
        }

        protected void LogError(string message)
        {
            _logger.LogError(message);
        }

        protected void LogException(Exception ex, string message = null)
        {
            if (!string.IsNullOrEmpty(message))
                _logger.LogError(ex, message);
            else
                _logger.LogError(ex, ex.Message);
        }

        protected async Task<T> ExecuteWithExceptionHandlingAsync<T>(Func<Task<T>> action)
        {
            try
            {
                return await action.Invoke();
            }
            catch (Exception ex)
            {
                LogException(ex);
                throw;
            }
        }

        protected async Task ExecuteWithExceptionHandlingAsync(Func<Task> action)
        {
            try
            {
                await action.Invoke();
            }
            catch (Exception ex)
            {
                LogException(ex);
                throw;
            }
        }
    }

}
