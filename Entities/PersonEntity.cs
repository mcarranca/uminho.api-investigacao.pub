using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    [Serializable,
        JsonSerializable(typeof(PersonEntity), TypeInfoPropertyName = "person")]
    public partial class PersonEntity {


        #region Property members

        [JsonPropertyName("internalID")]
        public string? InternalID { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }


        [JsonPropertyName("givenName")]

        public string? GivenName { get; set; }

        [JsonPropertyName("familyName")]
        public string? FamilyName { get; set; }

        [JsonPropertyName("additionalName")]
        public string? AdditionalName { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("phone")]
        public string? Phone { get; set; }

        [JsonPropertyName("photo")]
        public string? Photo { get; set; }

        [JsonPropertyName("personIds")]
        public IEnumerable<PersonEntity>? PersonIds { get; set; }

        [JsonPropertyName("positions")]
        public IEnumerable<PersonEntity.PositionEntity>? Positions { get; set; }

        [JsonPropertyName("concept")]
        public IEnumerable<PersonEntity.ConceptEntity>? Concept { get; set; }

        [JsonPropertyName("organizationInternalId")]
        public string? OrganizationInternalId { get; set; }


        [JsonPropertyName("organizationRinggoldId")]
        public string? OrganizationRinggoldId { get; set; }

        #endregion

    }
}
