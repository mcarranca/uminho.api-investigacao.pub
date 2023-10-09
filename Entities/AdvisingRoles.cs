using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities
{
    [Serializable,
    JsonSerializable(typeof(AdvisingRoles), TypeInfoPropertyName = "advisingRoles")]

    public class AdvisingRoles
    {
        [JsonPropertyName("advisingRoleID")]
        public string? AdvisingRoleID { get; set; }

        [JsonPropertyName("advisingRoleName")]
        public string? AdvisingRoleName { get; set; }
    }
}
