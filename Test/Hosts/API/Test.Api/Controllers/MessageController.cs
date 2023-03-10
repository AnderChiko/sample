using Microsoft.AspNetCore.Mvc;
using Test.BusinessLogic.Interfaces;
using Test.Core.Web;

namespace Test.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : CrudControllerBase<MessageController, IMessageManager,Context.Message, int>
    {
        public MessageController(IMessageManager manager, ILogger<MessageController> loggingManager)
           : base(manager, loggingManager)
        { 
        
        }
    }
}