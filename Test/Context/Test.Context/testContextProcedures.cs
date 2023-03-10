// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Test.Context;

namespace Test.Context
{
    public partial class testContext
    {
        private ItestContextProcedures _procedures;

        public virtual ItestContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new testContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public ItestContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetScheduledCampaignMessageTextResult>().HasNoKey().ToView(null);
        }
    }

    public partial class testContextProcedures : ItestContextProcedures
    {
        private readonly testContext _context;

        public testContextProcedures(testContext context)
        {
            _context = context;
        }

        public virtual async Task<List<GetScheduledCampaignMessageTextResult>> GetScheduledCampaignMessageTextAsync(DateTime? scheduleDate, TimeSpan? scheduleTime, string searchText, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "scheduleDate",
                    Value = scheduleDate ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Date,
                },
                new SqlParameter
                {
                    ParameterName = "scheduleTime",
                    Scale = 7,
                    Value = scheduleTime ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Time,
                },
                new SqlParameter
                {
                    ParameterName = "searchText",
                    Size = 200,
                    Value = searchText ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<GetScheduledCampaignMessageTextResult>("EXEC @returnValue = [dbo].[GetScheduledCampaignMessageText] @scheduleDate, @scheduleTime, @searchText", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
