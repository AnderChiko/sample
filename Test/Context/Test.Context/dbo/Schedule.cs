// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Test.Context
{
    public partial class Schedule
    {
        public int Code { get; set; }
        public int? FkCampaign { get; set; }
        public DateOnly? StartDate { get; set; }
        public TimeOnly? StartTime { get; set; }
        public int? NumberContacts { get; set; }
        public bool? Active { get; set; }
        public bool? Paused { get; set; }
        public DateTime? DateTimeStamp { get; set; }

        public virtual Campaign FkCampaignNavigation { get; set; }
    }
}