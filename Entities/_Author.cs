using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    [Serializable,
        JsonSerializable(typeof(Author), TypeInfoPropertyName = "author")]
    public class Author {
        // TODO: fill with properties
    }
}
