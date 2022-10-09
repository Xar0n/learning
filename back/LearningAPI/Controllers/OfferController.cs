using LearningAPI.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearningAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IHubContext<NotificationHub> _hubContext;

        public OfferController(IHubContext<NotificationHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", message);

            return Ok(new
            {
                Status = "OK",
                Message = "Уведомление успешно отправлено"
            });
        }
    }
}
