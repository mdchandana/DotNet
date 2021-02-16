using IrrigationWebSystem.Models.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IrrigationWebSystem.Models.Interfaces
{
    public interface ICannelRepository
    {
        List<WmCannel> GetAllCannels();
    }
}
