using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidataProfiler
{
    class PayPoint
    {
        public string PostIndex { get; set; }
        public string PayPointId { get; set; }
    }

    class PayPointMapping: TinyCsvParser.Mapping.CsvMapping<PayPoint>
    {
        public PayPointMapping() : base()
        {
            {
                MapProperty(0, x => x.PayPointId);
                MapProperty(1, x => x.PostIndex);
            }
        }
    }
}
