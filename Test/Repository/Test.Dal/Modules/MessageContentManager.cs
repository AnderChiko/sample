using Test.Core.Data;
using Test.DAL.Interfaces;

namespace Test.DAL.Modules
{
    public class MessageContentManager : DataManagerBase<Context.MessageContent, int, Context.testContext>, IMessageContentManager
    {
        public MessageContentManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}