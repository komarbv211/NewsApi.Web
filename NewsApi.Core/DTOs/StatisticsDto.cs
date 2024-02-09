using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.DTOs
{
    public class StatisticsDto
    {
        public DateTime VisitTime { get; set; }
        public int NewsId { get; set; }
        public string IpAddress { get; set; }

    }
}
