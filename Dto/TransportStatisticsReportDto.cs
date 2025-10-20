using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift.Dto
{
    public class TransportStatisticsReportDto
    {
        public int TotalTransportUnits { get; set; }
        public int AvailableTransportUnits { get; set; }
        public int UnavailableTransportUnits { get; set; }

        public TransportStatisticsReportDto() { }
        public TransportStatisticsReportDto(int totalTransportUnits, int availableTransportUnits, int unavailableTransportUnits)
        {
            TotalTransportUnits = totalTransportUnits;
            AvailableTransportUnits = availableTransportUnits;
            UnavailableTransportUnits = unavailableTransportUnits;
        }
    }
}
