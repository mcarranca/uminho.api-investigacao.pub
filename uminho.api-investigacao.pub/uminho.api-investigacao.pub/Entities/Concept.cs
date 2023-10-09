using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    [Serializable,
        JsonSerializable(typeof(Concept), TypeInfoPropertyName = "concept")]
    public class Concept {
        #region Property members

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
        #endregion
    }
}
