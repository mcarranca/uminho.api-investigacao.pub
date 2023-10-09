using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    [Serializable,
        JsonSerializable(typeof(ConceptEntity), TypeInfoPropertyName = "concept")]
    public class ConceptEntity {
        #region Property members

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
        #endregion
    }
}
