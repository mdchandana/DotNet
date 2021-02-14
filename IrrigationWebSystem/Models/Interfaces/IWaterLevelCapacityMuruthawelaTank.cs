using IrrigationWebSystem.Models.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.Interfaces
{
    public interface IWaterLevelCapacityMuruthawelaTank
    {
        WmWaterLevelCapacityMuruthawelaTank GetMuruthawelaWaterCapacityByLevel(decimal waterLevel);
        List<WmWaterLevelCapacityMuruthawelaTank> GetAllWaterlevels();
    }
}
