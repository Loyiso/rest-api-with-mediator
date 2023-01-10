using Microsoft.AspNetCore.Mvc;

namespace UserAddress.API.Controllers
{ 
    public class ApiBaseController : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public ObjectResult Error()
        {
            return StatusCode(500, "The server encounted an internal error and was unable to complete your request.");
        }
    }
}
