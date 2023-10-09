using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    public partial class PersonEntity {

        [Serializable,
            JsonSerializable(typeof(DegreesEntity), TypeInfoPropertyName = "degrees")]
        public class DegreesEntity {

            #region Property members

            [JsonPropertyName("majorField")]
            public string? MajorField { get; set; }
            [JsonPropertyName("departmentOrSchool")]
            public string? DepartmentOrSchool { get; set; }
            [JsonPropertyName("supplementalInformation")]
            public string? SupplementalInformation { get; set; }
            [JsonPropertyName("organization")]
            public string? Organization { get; set; }
            [JsonPropertyName("degree")]
            public string? Degree { get; set; }
            [JsonPropertyName("start")]
            public string? Start { get; set; }
            [JsonPropertyName("end")]
            public string? End { get; set; }

            #endregion

        }
    }
}
