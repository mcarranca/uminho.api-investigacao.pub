using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities
{
    [Serializable,
    JsonSerializable(typeof(Degree), TypeInfoPropertyName = "degree")]
    public class Degree
    {
        [JsonPropertyName("internalID")]
        public string? InternalID { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
