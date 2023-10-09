using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    [Serializable,
        JsonSerializable(typeof(Course), TypeInfoPropertyName = "course")]
    public class Course {
        [JsonPropertyName("internalID")]
        public string? InternalID { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("concepts")]
        public IEnumerable<Concept> Concepts { get; set; }

        [JsonPropertyName("degrees")]
        public IEnumerable<Degree> Degrees { get; set; }

    }
}
