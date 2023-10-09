using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    public partial class PersonEntity {

        [Serializable,
            JsonSerializable(typeof(ConceptEntity), TypeInfoPropertyName = "concept")]
        public class ConceptEntity {

            #region Property members

            [JsonPropertyName("id")]
            public string? ID { get; set; }
            [JsonPropertyName("name")]
            public string? Name { get; set; }
            [JsonPropertyName("organizationId")]
            public string? OrganizationId { get; set; }


            #endregion

        }
    }
}
