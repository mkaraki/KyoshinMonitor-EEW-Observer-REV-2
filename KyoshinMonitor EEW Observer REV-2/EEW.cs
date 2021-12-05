using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyoshinMonitor_EEW_Observer_REV_2
{

    public class EEW
    {
        public int time { get; set; }
        public string region { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
        public int depth { get; set; }
        public int japanese_intensity { get; set; }
        public int report_num { get; set; }
        public string alert_type { get; set; }
        public int origin_time { get; set; }
        public float magunitude { get; set; }
        public bool is_final { get; set; } = false;
    }

}
