using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAL.Models
{
    public class Campaign
    {
        public int Code { get; set; }
        public int? FkMessage { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? Active { get; set; }
    }
}
