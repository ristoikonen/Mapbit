using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mapbit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //UnMark if you need : 
    //[Consumes("application/json")]
    //[Produces("application/json")]
    //[EnableCors("AllowAll")]
    public abstract class BaseController : ControllerBase
    {
        protected ActionResult<TResult> OkOrNotFound<TResult>(TResult result)
            => result is null ? NotFound() : Ok(result);
    }
}
