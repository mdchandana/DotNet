using IrrigationWebSystem.Data.Context;
using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Data.Repository
{
    public class CannelRepository : ICannelRepository
    {
        private AppDbContext _context;

        public CannelRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }


        public List<WmCannel> GetAllCannels()
        {
            return _context.WmCannels.ToList();
        }
    }
}
