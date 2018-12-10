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
        public string price { get; set; }
        public string volume { get; set; }
        public string direction { get; set; }
        public string offset { get; set; }
        public string lever_rate { get; set; }
        public string order_price_type { get; set; }
        public string contract_code { get; set; }
        public string symbol { get; set; }
        public string contract_type { get; set; }
    }
}
