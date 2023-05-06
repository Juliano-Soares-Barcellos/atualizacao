using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class GeraTokenModel
    {
        [JsonProperty("card_number")]
        public string? CardNumber { get; set; }

        [JsonProperty("customer_id")]
        public string? CustomerId { get; set; }

        [JsonProperty("number_token")]
        public string? NumberToken { get; set; }


    }
}
