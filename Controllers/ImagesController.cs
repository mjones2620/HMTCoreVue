using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SendGrid.Helpers.Mail;
using SendGrid;
using HMTCoreVue.Models;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.FileProviders;
using System.Linq;

namespace HMTCoreVue.Controllers
{
    [Route("api/[controller]")]
    public class ImagesController : Controller
    {
        private readonly IFileProvider _fileProvider;
        public ImagesController(IFileProvider fileProvider)
        {
            this._fileProvider = fileProvider;
        }


        [HttpGet]
        public IActionResult GetImages()
        {
            var images = _fileProvider.GetDirectoryContents("ClientApp/images/office");
            return Ok(images.Select(s => s.Name).ToList());
        }
    }
}
