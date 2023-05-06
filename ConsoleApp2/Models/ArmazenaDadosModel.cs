using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class ArmazenaDadosModel
    {
        [JsonProperty("number_token")]
        public string? NumberToken { get; set; }

        [JsonProperty("brand")]
        public string? Brand { get; set; }

        [JsonProperty("cardholder_name")]
        public string? CardholderName { get; set; }

        [JsonProperty("expiration_month")]
        public string? ExpirationMonth { get; set; }

        [JsonProperty("expiration_year")]
        public string? ExpirationYear { get; set; }

        [JsonProperty("customer_id")]
        public string? CustomerId { get; set; }

        [JsonProperty("cardholder_identification")]
        public string? CardholderIdentification { get; set; }

        [JsonProperty("verify_card")]
        public bool  VerifyCard { get; set; }

        [JsonProperty("security_code")]
        public string? SecurityCode { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }


    }
}
