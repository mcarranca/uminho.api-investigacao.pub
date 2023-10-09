using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    [Serializable,
        JsonSerializable(typeof(CourseEntity), TypeInfoPropertyName = "course")]
    public class CourseEntity {
        [JsonPropertyName("internalID")]
        public string? InternalID { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("concepts")]
        public IEnumerable<ConceptEntity>? Concepts { get; set; }

        [JsonPropertyName("degrees")]
        public IEnumerable<DegreeEntity>? Degrees { get; set; }

    }
}
