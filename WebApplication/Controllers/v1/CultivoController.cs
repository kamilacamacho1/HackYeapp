using Aplication.Feactures.Cultivo.Commands.CreateCultivoCommand;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplication.Controllers.v1
{
    [ApiVersion("1")]
    
    public class CultivoController : BaseApiController
    {
        //POST api/<controller>

        [HttpPost]
        public async Task<IActionResult> Post(CreateCultivoCommand command)
        {
            //var res = await Mediator.Send(command);
            return Ok(await Mediator.Send(command));
        }
    }
}
