using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MiniStore.Application.Interfaces.Notificador;

namespace MiniStoreApi.Controllers
{
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        protected MainController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        
        protected bool IsValidOperation()
        {
            return !_notificationService.HaveNotification();
        }

        protected ActionResult ServiceResponse(object result = null)
        {
            if (IsValidOperation())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = _notificationService
                .GetNotifications()
                .Select(n => n.Message)
            });
        }

        protected ActionResult ServiceResponse(ModelStateDictionary modelState)
        {
            if (!modelState.IsValid)
            {
                NotificationErrorInvalidModel(modelState);
            }

            var notifications = _notificationService.GetNotifications()
                .Select(n => n.Message);

            var errors = notifications.Concat(modelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage));

            if (errors.Any())
            {
                return BadRequest(new
                {
                    success = false,
                    errors = errors
                });
            }

            return ServiceResponse();
        }

        protected void NotificationErrorInvalidModel(ModelStateDictionary modelState)
        {
            var modelErrors = modelState.Values.SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage);

            foreach (var modelError in modelErrors)
            {
                ReportError(modelError);
            }
        }

        protected void ReportError(string mensagem)
        {
            _notificationService.Handle(new Notify(mensagem));
        }
    }
}