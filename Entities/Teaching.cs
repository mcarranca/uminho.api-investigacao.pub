using System.Data;
using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities
{
    //TODO: Teaching e TeachingRoles são iguais
    [Serializable,
    JsonSerializable(typeof(Teaching), TypeInfoPropertyName = "teaching")]
 
    public class Teaching
    {
        [JsonPropertyName("role")]
        public string? Role { get; set; }
        
        [JsonPropertyName("curricularUnitInternalId")]
        public string? CurricularUnitInternalId { get; set; }

        [JsonPropertyName("_curricularUnit")]
        public CurricularUnit CurricularUnit { get; set; }

        [JsonPropertyName("period")]
        public string? Period { get; set; }

    }
}
