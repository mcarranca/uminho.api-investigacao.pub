using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities
{
    [Serializable,
    JsonSerializable(typeof(CurricularUnit), TypeInfoPropertyName = "curricularUnit")]

    public class CurricularUnit
    {

        [JsonPropertyName("internalID")]
        public string? InternalID { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("concepts")]
        public IEnumerable<Concept> Concepts { get; set; }

        [JsonPropertyName("courses")]
        public IEnumerable<Course> Courses { get; set; }


    }
}
