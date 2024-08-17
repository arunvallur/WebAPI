using Microsoft.AspNetCore.Mvc;
using WebAPI_Domain_Contract;


namespace WebAPI.Controllers
{
    [Route("api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IDemoManager _demoManager;
        public DemoController(IDemoManager demoManager)
        {
            _demoManager = demoManager; 
        }

        [HttpGet]
        public string Get()
        {

            return _demoManager.getdemovalue();
        }

    }
}
