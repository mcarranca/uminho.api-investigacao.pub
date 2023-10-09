using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    [Serializable,
        JsonSerializable(typeof(Concept), TypeInfoPropertyName = "concept")]
    public class Concept {
        // TODO: fill with properties
    }
}
