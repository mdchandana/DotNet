using IrrigationWebSystem.Data.Context;
using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Data.Repository
{
    public class RainFallRepository : IRainFallRepository
    {
        private AppDbContext _appDbContext;

        public RainFallRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddRainFall(WmRainFall wmRainFall)
        {
            _appDbContext.WmRainFalls.Add(wmRainFall);
            _appDbContext.SaveChanges();
        }

        public void DeleteRainFallBy(int rainFallId)
        {
            var foundRainFall = _appDbContext.WmRainFalls.Find(rainFallId);
            if(foundRainFall != null)
            {
                _appDbContext.WmRainFalls.Remove(foundRainFall);
                _appDbContext.SaveChanges();
            }
        }

        public List<WmRainFall> GetRainFallByArea(string area)
        {
            return _appDbContext.WmRainFalls
                .Where(rain => rain.RainFallArea == area).ToList();
        }
    }
}
