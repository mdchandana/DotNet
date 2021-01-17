using IrrigationWebSystem.Data.Context;
using IrrigationWebSystem.Models.DomainEntities;
using IrrigationWebSystem.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Data.Repository
{
    public class PositionRepository : IPositionRepository
    {
        private AppDbContext _appDbContext;

        public PositionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<EmployeePosition> GetAllPositions()
        {
            return _appDbContext.EmployeePositions.ToList();
        }
    }
}
