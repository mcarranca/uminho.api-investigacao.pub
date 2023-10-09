using System;
using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {

    [Serializable,
        JsonSerializable(typeof(ProjectEntity), TypeInfoPropertyName = "project")]
    public class ProjectEntity {

        #region Property members

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("id")]
        public string? ID { get; set; }

        [JsonPropertyName("reference")]
        public string? Reference { get; set; }

        [JsonPropertyName("grantDirectCosts")]
        public string? GrantDirectCosts { get; set; }

        [JsonPropertyName("sponsorAwardId")]
        public string? SponsorAwardId { get; set; }

        [JsonPropertyName("localAwardId")]
        public string? LocalAwardId { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("abstract")]
        public string? @Abstract { get; set; }

        [JsonPropertyName("totalAwardAmount")]
        public string? TotalAwardAmount { get; set; }

        [JsonPropertyName("organizationInternalId")]
        public string? OrganizationInternalId { get; set; }

        [JsonPropertyName("organizationRingoldId")]
        public string? OrganizationRingoldId { get; set; }

        [JsonPropertyName("principalInternalID")]
        public string? PrincipalInternalID { get; set; }

        [JsonPropertyName("principalInvestigatorName")]
        public string? PrincipalInvestigatorName { get; set; }

        [JsonPropertyName("Persons")]
        public IEnumerable<PersonEntity>? Persons { get; set; }

        [JsonPropertyName("start")]
        public string? Start { get; set; }

        [JsonPropertyName("end")]
        public string? End { get; set; }

        [JsonPropertyName("concepts")]
        public IEnumerable<ConceptEntity>? Concepts { get; set; }

        [JsonPropertyName("fundingOrganization")]
        public string? FundingOrganization { get; set; }


        #endregion

    }
}
