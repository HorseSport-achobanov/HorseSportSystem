﻿namespace Endurance.Services.Trial.Performance
{
    using System.Linq;
    using Contracts.Performance;
    using Data.Trial.Models;
    using global::Data.Common.Contracts;
    using global::Services.Common;

    public class PerformanceDataService : DataService<TrialRoundPerformance>, IPerformanceDataService
    {
        public PerformanceDataService(IRepository<TrialRoundPerformance> performances) 
            : base(performances)
        {
        }

        public TrialRoundPerformance GetNextByIndexAndCompetitorId(int index, int competitorId) =>
            this.Data
                .GetQueryableAll()
                .FirstOrDefault(trp => trp.Index == index + 1
                                       && trp.CompetitorId == competitorId);
    }
}