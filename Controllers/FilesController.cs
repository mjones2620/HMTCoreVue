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
    public class FilesController : Controller
    {
        private readonly IFileProvider _fileProvider;
        public FilesController(IFileProvider fileProvider)
        {
            this._fileProvider = fileProvider;
        }


        [HttpGet]
        public IActionResult GetFiles()
        {
            var files = _fileProvider.GetDirectoryContents("wwwroot/docs");
            return Ok(files.ToList());
        }
    }
}
