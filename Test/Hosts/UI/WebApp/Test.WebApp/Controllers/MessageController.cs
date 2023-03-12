using Microsoft.AspNetCore.Mvc;
using System.Net;
using Test.Api.Models;
using Test.Api.Models.Web;
using Test.BusinessLogic.Interfaces;
using Test.Core.Web;

namespace Test.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : CrudControllerBase<MessageController, IMessageManager, Context.Message, int>
    {
        public MessageController(IMessageManager manager, ILogger<MessageController> loggingManager)
           : base(manager, loggingManager)
        {

        }
    }
}