using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities
{
    [Serializable,
        JsonSerializable(typeof(Editor), TypeInfoPropertyName = "editor")]
    public class Editor
    {
        #region Property members

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("abbreviation")]
        public string? Abbreviation { get; set; }

        [JsonPropertyName("issn")]
        public string? ISSN { get; set; }

        [JsonPropertyName("eissn")]
        public string? EISSN { get; set; }

        #endregion
    }
}
