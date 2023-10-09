using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities
{
    [Serializable,
    JsonSerializable(typeof(CurricularUnitEntity), TypeInfoPropertyName = "curricularUnit")]

    public class CurricularUnitEntity
    {

        [JsonPropertyName("internalID")]
        public string? InternalID { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("concepts")]
        public IEnumerable<ConceptEntity>? Concepts { get; set; }

        [JsonPropertyName("courses")]
        public IEnumerable<CourseEntity>? Courses { get; set; }


    }
}
