using IrrigationWebSystem.Models.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.Interfaces
{
    public interface IRainFallRepository
    {
        void AddRainFall(WmRainFall wmRainFall);
        void DeleteRainFallBy(int rainFallId);
        List<WmRainFall> GetRainFallByArea(string area);
    }
}
