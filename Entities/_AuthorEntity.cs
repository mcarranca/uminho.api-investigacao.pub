using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    [Serializable,
        JsonSerializable(typeof(AuthorEntity), TypeInfoPropertyName = "author")]
    public class AuthorEntity {
        // TODO: fill with properties
    }
}
