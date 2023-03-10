using Test.Core.Data;
using Test.DAL.Interfaces;

namespace Test.DAL.Modules
{
    public class ScheduleManager : DataManagerBase<Context.Schedule, int, Context.testContext>, IScheduleManager
    {
        public ScheduleManager(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}