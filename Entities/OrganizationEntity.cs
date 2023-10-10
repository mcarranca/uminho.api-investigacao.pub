using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    [Serializable,
    JsonSerializable(typeof(OrganizationEntity), TypeInfoPropertyName = "organization")]
    public class OrganizationEntity {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("internalD")]
        public string? InternalD { get; set; }

        [JsonPropertyName("ringGoldId")]
        public string? RingGoldId { get; set; }

        [JsonPropertyName("abbreviation")]
        public string? Abbreviation { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("geo")]
        public string? Geo { get; set; }

        [JsonPropertyName("logo")]
        public string? Logo { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("parentInternalID")]
        public string? ParentInternalID { get; set; }

        [JsonPropertyName("parentRingGoldId")]
        public string? ParentRingGoldId { get; set; }

        [JsonPropertyName("parentName")]
        public string? ParentName { get; set; }

        [JsonPropertyName("address")]
        public IEnumerable<AdressEntity>? Address { get; set; }
    }
}
