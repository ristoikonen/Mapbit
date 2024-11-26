using Mapbit.Abstractions.Queries;
using Mapbit.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;


namespace Mapbit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapbitController : BaseController
    {
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<MapbitDto>> Get([FromRoute] IQuery query)
        {
            // var result = await _queryDispatcher.QueryAsync(query);
            MapbitDto mapbit = new MapbitDto("","",0,0,Color.Black);
            var result = mapbit;
            return OkOrNotFound(result);
        }
    }



}
