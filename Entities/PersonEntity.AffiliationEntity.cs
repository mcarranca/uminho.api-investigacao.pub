using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    public partial class PersonEntity {

        [Serializable,
           JsonSerializable(typeof(AffiliationEntity), TypeInfoPropertyName = "affiliation")]
        public class AffiliationEntity {

            #region Property members

            [JsonPropertyName("organizationId")]
            public string? OrganizationId { get; set; }
            [JsonPropertyName("organizationname")]
            public string? Organizationname { get; set; }
            [JsonPropertyName("positionID")]
            public string? PositionID { get; set; }
            [JsonPropertyName("positionName")]
            public string? PositionName { get; set; }
            [JsonPropertyName("start")]
            public string? Start { get; set; }
            [JsonPropertyName("end")]
            public string? End { get; set; }


            #endregion

        }
    }
}
