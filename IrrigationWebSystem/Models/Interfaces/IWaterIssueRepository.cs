using IrrigationWebSystem.Models.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.Interfaces
{
    public interface IWaterIssueRepository
    {
        void AddWaterIssue(WmDailyWaterLevelAndissue wmDailyWaterLevelAndIssue);
        List<WmDailyWaterLevelAndissue> GetWaterIssuesForPeriod(DateTime startDate,DateTime endDate);
    }
}
