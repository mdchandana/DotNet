using IrrigationWebSystem.Data.Context;
using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Data.Repository
{
    public class WaterIssueRepository : IWaterIssueRepository
    {
        private AppDbContext _appDbContext;

        public WaterIssueRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddWaterIssue(WmDailyWaterLevelAndissue wmDailyWaterLevelAndIssue)
        {
            _appDbContext.WmDailyWaterLevelAndissues.Add(wmDailyWaterLevelAndIssue);
            _appDbContext.SaveChanges();
        }
    }
}
