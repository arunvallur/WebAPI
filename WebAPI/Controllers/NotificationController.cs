using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Domain_Contract;

namespace WebAPI.Controllers
{
    [Route("api/notification")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationManager _notificationManger;
        public NotificationController(INotificationManager notificationManger)
        {
            _notificationManger = notificationManger;
        }

        [HttpGet]
        public async Task<bool> pushNotification(string message)
        {
            bool test = await _notificationManger.pushNotification(message);
            return test;
        }
    }
}
