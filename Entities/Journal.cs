using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities
{
    [Serializable,
        JsonSerializable(typeof(Journal), TypeInfoPropertyName = "journal")]
    public class Journal
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
