using Test.Core.Data;
using Test.DAL.Interfaces;

namespace Test.DAL.Modules
{
    public class CampaignManager : DataManagerBase<Context.Campaign, int, Context.testContext>, ICampaignManager
    {
        public CampaignManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}