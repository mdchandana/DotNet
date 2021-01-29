using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryAjax.Models
{
    public class EmpRanking
    {
        public double Rank { get; set; }


        public List<EmpRanking> GetAllEmpRankings()
        {
            return new List<EmpRanking>()
            {
                new EmpRanking(){Rank=1.1},
                new EmpRanking(){Rank=2.1},
                new EmpRanking(){Rank=3.1},
                new EmpRanking(){Rank=4.1},
                new EmpRanking(){Rank=5.1}
            };
        }
    }
}
