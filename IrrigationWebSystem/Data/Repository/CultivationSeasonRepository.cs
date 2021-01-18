using IrrigationWebSystem.Data.Context;
using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Data.Repository
{
    public class CultivationSeasonRepository : ICultivationSeasonRepository
    {
        private AppDbContext _appDbContext;

        public CultivationSeasonRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddCultivationSeasonInformation(WmCultivationSeasonInformation wmCultivationSeasonInformation)
        {
            _appDbContext.wmCultivationSeasonInformations.Add(wmCultivationSeasonInformation);
            _appDbContext.SaveChanges();
        }

        public List<WmCultivationSeasonInformation> GetWmCultivationSeasonInformation()
        {
            return _appDbContext.wmCultivationSeasonInformations.ToList();
        }
    }
}
