using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.Dto
{
    public class LoadStatisticsReportDto
    {
        public int TottalLoads { get; set; }
        public int TotalWeight { get; set; }
        public int TotalVolume { get; set; }

        public LoadStatisticsReportDto(int tottalLoads, int totalWeight, int totalVolume)
        {
            TottalLoads = tottalLoads;
            TotalWeight = totalWeight;
            TotalVolume = totalVolume;
        }   
    }
}
