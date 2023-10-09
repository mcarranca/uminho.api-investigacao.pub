using System.Data;
using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities
{
    //TODO: Teaching e TeachingRoles são iguais
    [Serializable,
    JsonSerializable(typeof(TeachingRoles), TypeInfoPropertyName = "teachingRoles")]

    public class TeachingRoles
    {
        [JsonPropertyName("role")]
        public string? Role { get; set; }
        
        [JsonPropertyName("curricularUnitInternalId")]
        public string? CurricularUnitInternalId { get; set; }

        [JsonPropertyName("curricularUnit")]
        public CurricularUnit? _CurricularUnit { get; set; }

        [JsonPropertyName("period")]
        public string? Period { get; set; }

    }
}
