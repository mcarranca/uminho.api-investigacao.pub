using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    [Serializable,
        JsonSerializable(typeof(Person), TypeInfoPropertyName = "person")]
    public class Person {
        // TODO: fill with properties
    }
}
