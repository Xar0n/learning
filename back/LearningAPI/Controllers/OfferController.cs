using DAL.Data;
using DAL.Dto;
using DAL.Models;
using LearningAPI.Hubs;
using LearningAPI.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Data.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearningAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IHubContext<NotificationHub> _hubContext;
        private readonly LearningContext _context;
        public OfferController(
            IHubContext<NotificationHub> hubContext, 
            LearningContext context)
        {
            _hubContext = hubContext;
            _context = context;
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


        [HttpPost]
        [Route("create")]
        [DisableRequestSizeLimit]
        /*[DisableRequestSizeLimit,
    RequestFormLimits(MultipartBodyLengthLimit = int.MaxValue,
        ValueLengthLimit = int.MaxValue)]*/
        public async Task<IActionResult> Create([FromForm] OfferCreateRequest offerCreateRequest)
        {
            Offer offer = new Offer {
                Name = offerCreateRequest.Name,
                Description = offerCreateRequest.Description
            };
            var file = offerCreateRequest.Photo;
            string fileName = Path.GetFileName(file.FileName);
            string contentType = file.ContentType;
            using (MemoryStream ms = new MemoryStream())
            {
                file.CopyTo(ms);
                FileDescription fileDescription = new FileDescription
                {
                    Name = fileName,
                    ContentType = contentType,
                    Data = ms.ToArray(),
                    Offer = offer
                };
                offer.Photo = fileDescription; 
            }
            await _context.Offers.AddAsync(offer);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        [Route("getById")]
        public async Task<IActionResult> DownloadFile(int offerId)
        {
            var offer = _context.Offers.Include(p => p.Photo).FirstOrDefault(x => x.Id == offerId);
            var file = offer.Photo;
            var offerDto = new OfferDto
            {
                Name = offer.Name,
                Description = offer.Description,
                Photo = File(file.Data, file.ContentType, file.Name)
            };
            return Ok(
                offerDto
            );
        }
    }
}
