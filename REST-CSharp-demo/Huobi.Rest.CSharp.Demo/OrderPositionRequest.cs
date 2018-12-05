using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huobi.Rest.CSharp.Demo.Model
{
    public class OrderPositionRequest
    {
        /// [JsonProperty("symbol")]
        public string symbol { get; set; }
    }
}
