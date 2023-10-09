using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    public partial class PersonEntity {

        [Serializable,
            JsonSerializable(typeof(PositionEntity), TypeInfoPropertyName = "Position")]
        public class PositionEntity {

            #region Property members

            [JsonPropertyName("id")]
            public string? ID { get; set; }
            [JsonPropertyName("name")]
            public string? Name { get; set; }
            [JsonPropertyName("start")]
            public string? Start { get; set; }
            [JsonPropertyName("end")]
            public string? End { get; set; }

            #endregion

        }
    }
}
