using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SendGrid.Helpers.Mail;
using SendGrid;
using HMTCoreVue.Models;
using System.Threading.Tasks;

namespace HMTCoreVue.Controllers
{
    [Route("api/[controller]")]
    public class AppointmentsController : Controller
    {
        public AppointmentsController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IConfiguration configuration;

        [HttpPost]
        public async Task<IActionResult> SendEmail([FromBody] Email request)
        {
            var Requester = $"<strong>Request from</strong>:<span> { request.Name }</span><br />";
            var PhoneNumber = $"<strong>Contact Phone Number</strong>:<span> { request.PhoneNumber }</span><br />";
            var ContactEmail = $"<strong>Contact Email</strong>:<span> { request.EmailAddress }</span><br />";
            var DesiredDate = $"<strong>Desired Date</strong>:<span> { request.DesiredDate.Value }</span><br />";
            var Message = $"<strong>Message</strong>:<span> { request.Message }</span>";

            var apiKey = System.Environment.GetEnvironmentVariable("SendGrid");
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(request.EmailAddress, request.Name),
                Subject = "A New Appointment Inquiry from HealthyMindsTherapy.com.",
                HtmlContent = $"{ Requester + PhoneNumber + ContactEmail + DesiredDate + Message  }"
            };
            msg.AddTo(new EmailAddress("info@healthyminds-therapy.com", "info@healthyminds-therapy.com"));
            var response = await client.SendEmailAsync(msg);

            return Ok("Message Sent");
        }
    }
}
