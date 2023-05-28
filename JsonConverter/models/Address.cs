using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Converters;

namespace JsonConverter
{
    public class Address
    {
        public Address()
        {
            Details = new List<AddressDetail>();
        }
        
        [Key]
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Notes { get; set; }
        public string Label { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PreferredContactMethod PreferredContactMethod { get; set; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public List<AddressDetail> Details { get; set; }
    }
}