using AuthenticationExample.Authorization;
using AuthenticationExample.IServices;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationExample.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[Controller]")]
    public class BasicAuthenticationExample : ControllerBase
    {
        IDatabaseService _databaseService;
        public BasicAuthenticationExample(IDatabaseService databaseService)
        {
            _databaseService=databaseService;
        }

        [HttpGet]
        public JsonResult Get()
        {
            _databaseService.GetAll();
            return new JsonResult(_databaseService.GetAll());
        }
    }
}
