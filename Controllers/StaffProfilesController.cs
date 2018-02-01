using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SendGrid.Helpers.Mail;
using SendGrid;
using HMTCoreVue.Models;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.FileProviders;
using System.Linq;
using HMTCoreVue.Infrastructure;

namespace HMTCoreVue.Controllers
{
    [Route("api/[controller]")]
    public class StaffProfilesController : Controller
    {
        private readonly StaffProfilesHelper staffProfilesHelper;
        public StaffProfilesController(StaffProfilesHelper _staffProfilesHelper)
        {
            this.staffProfilesHelper = _staffProfilesHelper;
        }


        [HttpGet]
        public IActionResult GetProfiles()
        {
            var profiles = this.staffProfilesHelper.init();
            return Ok(profiles);
        }
    }
}
