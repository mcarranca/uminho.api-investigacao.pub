using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    [Serializable,
        JsonSerializable(typeof(AdressEntity), TypeInfoPropertyName = "adress")]
    public class AdressEntity {
        [JsonPropertyName("locality")]
        public string? Locality { get; set; }

        [JsonPropertyName("postalCode")]
        public string? PostalCode { get; set; }

        [JsonPropertyName("streetAddress")]
        public string? StreetAddress { get; set; }

    }
}
