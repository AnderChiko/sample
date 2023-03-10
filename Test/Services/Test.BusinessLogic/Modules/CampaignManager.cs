using Test.BusinessLogic.Interfaces;
using Test.Core.Data;

namespace Test.BusinessLogic
{
    public class CampaignManager : DataManagerBase<Context.Campaign, int, Context.testContext>, ICampaignManager
    {
        public CampaignManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}