using Test.BusinessLogic.Interfaces;
using Test.Core.Data;

namespace Test.BusinessLogic
{
    public class MessageContentManager : DataManagerBase<Context.MessageContent, int, Context.testContext>, IMessageContentManager
    {
        public MessageContentManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}