using IrrigationWebSystem.Data.Context;
using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Data.Repository
{
    public class WaterLevelCapacityMuruthawelaTank : IWaterLevelCapacityMuruthawelaTank
    {
        private AppDbContext _appDbContext;

        public WaterLevelCapacityMuruthawelaTank(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public WmWaterLevelCapacityMuruthawelaTank GetMuruthawelaWaterCapacityByLevel(decimal waterLevel)
        {
            return _appDbContext.WmWaterLevelCapacityMuruthawelaTanks
                    .FirstOrDefault(level => level.WaterLevel == waterLevel);
        }
    }
}
