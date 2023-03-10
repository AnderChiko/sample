using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Interfaces.Data;

namespace Test.DAL.Interfaces
{
   public interface IMessageManager : ICrudManager<Context.Message, int>
    {
    }
}