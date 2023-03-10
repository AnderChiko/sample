using Test.BusinessLogic.Interfaces;
using Test.Core.Data;

namespace Test.BusinessLogic
{
    public class ScheduleManager : DataManagerBase<Context.Schedule, int, Context.testContext>, IScheduleManager
    {
        public ScheduleManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}