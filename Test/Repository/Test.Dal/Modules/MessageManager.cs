using Test.Core.Data;
using Test.DAL.Interfaces;

namespace Test.DAL.Modules
{
    public class MessageManager : DataManagerBase<Context.Message, int, Context.testContext>, IMessageManager
        {
            public MessageManager(IServiceProvider serviceProvider) : base(serviceProvider)
            {
            }
        }
    }