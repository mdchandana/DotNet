using IrrigationWebSystem.Data.Context;
using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Data.Repository
{
    public class SchemeRepository : ISchemeRepository
    {
        private AppDbContext _appDbContext;

        public SchemeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<WmScheme> GetAllSchemes()
        {
            return _appDbContext.WmSchemes.ToList();
        }
    }
}
