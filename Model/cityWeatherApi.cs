using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wheatherApi.Model
{
    public class cityWeatherApi
    {
        public coord coord { get; set; }
        public List<weather> weather { get; set; }
        public string bas {get;set;}
        public main main { get; set; }
        public float visibility { get; set; }
        public wind wind { get; set; }
        public clouds clouds { get; set; }
        public float dt { get; set; }
        public sys sys { get; set; }
        public string timezone { get; set; }
        public float id { get; set; }
        public string name { get; set; }
        public float cod { get; set; }

    }
}
