using Newtonsoft.Json;

namespace EventLogger
{
    public class EventEntity {
        
        public int Id { get; set; }
        [JsonProperty("id")]
        public int EventId { get; set; }
        [JsonProperty("color")]
        public string EventValue { get; set; }
        //public string EventArguments { get; set; }


    }

   
}
