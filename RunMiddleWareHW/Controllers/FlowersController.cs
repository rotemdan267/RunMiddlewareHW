using Microsoft.AspNetCore.Mvc;

namespace FlowersHW.Controllers
{
    [ApiController]
    [Route("flower/[action]")]
    public class FlowersController : ControllerBase
    {
        public string Rose()
        {
            return "Roses are red...";
        }

        public string Violet()
        {
            return "Violets are blue...";
        }

        public string Lily()
        {
            return "Lily";
        }

        public string Tulip()
        {
            return "Tulip";
        }
    }
}
