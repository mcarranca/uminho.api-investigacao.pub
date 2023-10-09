using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    public partial class PersonEntity {

        [Serializable,
            JsonSerializable(typeof(IDEntity), TypeInfoPropertyName = "id")]
        public class IDEntity {

            #region Property members

            [JsonPropertyName("idname")]
            public string? IDName { get; set; }
            [JsonPropertyName("idvalue")]
            public string? IDValue { get; set; }


            #endregion

        }
    }
}
