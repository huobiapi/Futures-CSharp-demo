using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huobi.Rest.CSharp.Demo.Model
{
    public class OrderPlaceRequest
    {
       /// [JsonProperty("price")]
        public Int32 price { get; set; }
        public Int32 volume { get; set; }
        public string direction { get; set; }
        public string offset { get; set; }
        public int lever_rate { get; set; }
        public string order_price_type { get; set; }
    }
}
