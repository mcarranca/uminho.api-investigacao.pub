using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities
{
    [Serializable,
    JsonSerializable(typeof(DegreeEntity), TypeInfoPropertyName = "degree")]
    public class DegreeEntity
    {
        [JsonPropertyName("internalID")]
        public string? InternalID { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
