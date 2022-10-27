using System.Text.Json.Serialization;

namespace BlazorWasmDemo.Utilities
{
    public class Github
    {
        [JsonInclude]
        public long Id { get; set; }

        [JsonInclude]
        public string Name { get; set; } = default!;

        [JsonInclude]
        public string Description { get; set; } = default!;

        [JsonInclude]
        public string Url { get; set; } = default!; 
       // public string HtmlUrl { get; set; } = default!;

    }
}
