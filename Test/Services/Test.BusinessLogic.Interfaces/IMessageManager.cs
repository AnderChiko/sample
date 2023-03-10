using Test.Core.Interfaces.Data;

namespace Test.BusinessLogic.Interfaces
{
    public interface IMessageManager : ICrudManager<Context.Message, int>
    {
    }
}