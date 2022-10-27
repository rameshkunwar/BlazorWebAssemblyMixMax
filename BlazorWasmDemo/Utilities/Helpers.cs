using System.Text.Json;

namespace BlazorWasmDemo.Utilities
{
    public static class Helpers
    {
        public static async Task<T> ReadAsAsync<T>(this HttpContent content)
        {
            var data = await content.ReadAsStringAsync();
            var option = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = null
            };

            return JsonSerializer.Deserialize<T>(data, option);
        }
    }
}
