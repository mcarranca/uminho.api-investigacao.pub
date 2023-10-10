using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    [Serializable,
    JsonSerializable(typeof(AdvisingRoleEntity), TypeInfoPropertyName = "advisingRoles")]

    public class AdvisingRoleEntity {
        [JsonPropertyName("advisingRoleID")]
        public string? AdvisingRoleID { get; set; }

        [JsonPropertyName("advisingRoleName")]
        public string? AdvisingRoleName { get; set; }
    }
}
