using Test.BusinessLogic.Interfaces;
using Test.Core.Data;

namespace Test.BusinessLogic
{
    public class MessageManager : DataManagerBase<Context.Message, int, Context.testContext>, IMessageManager
        {
            public MessageManager(IServiceProvider serviceProvider) : base(serviceProvider)
            {
            }
        }
    }