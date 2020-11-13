using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wheatherApi.Model
{
    public class sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public int message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }
}
