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
            _appDbContext.wmRainFalls.Add(wmRainFall);
            _appDbContext.SaveChanges();
        }

        public void DeleteRainFallBy(int rainFallId)
        {
            var foundRainFall = _appDbContext.wmRainFalls.Find(rainFallId);
            if(foundRainFall != null)
            {
                _appDbContext.wmRainFalls.Remove(foundRainFall);
                _appDbContext.SaveChanges();
            }
        }

        public List<WmRainFall> GetRainFallByArea(string area)
        {
            return _appDbContext.wmRainFalls
                .Where(rain => rain.RainFallArea == area).ToList();
        }
    }
}
