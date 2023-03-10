using Microsoft.AspNetCore.Mvc;
using Test.BusinessLogic.Interfaces;
using Test.Core.Web;

namespace Test.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : CrudControllerBase<CampaignController, ICampaignManager, Context.Campaign, int>
    {
        public CampaignController(ICampaignManager manager, ILogger<CampaignController> loggingManager)
           : base(manager, loggingManager)
        {

        }
    }
}