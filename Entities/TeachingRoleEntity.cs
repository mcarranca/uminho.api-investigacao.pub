using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    //TODO: Teaching e TeachingRoles são iguais
    [Serializable,
    JsonSerializable(typeof(TeachingRoleEntity), TypeInfoPropertyName = "teachingRoles")]

    public class TeachingRoleEntity {
        [JsonPropertyName("role")]
        public string? Role { get; set; }

        [JsonPropertyName("curricularUnitInternalId")]
        public string? CurricularUnitInternalId { get; set; }

        [JsonPropertyName("curricularUnit")]
        public CurricularUnitEntity? CurricularUnit { get; set; }

        [JsonPropertyName("period")]
        public string? Period { get; set; }

    }
}
