using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JsonConverter
{
    public class AddressDetail
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public AddressDetailLabel AddressDetailLabel { get; set; }  
        
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }   
    }
}