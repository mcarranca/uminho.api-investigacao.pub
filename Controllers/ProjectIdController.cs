using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using uminho.api_investigacao.pub.Entities;

namespace uminho.api_investigacao.pub.Controllers {
    [Authorize]
    [ApiController]
    //[Route("v1/[controller]")]
    [Route("v1")]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]

    public class ProjectIdController
    : BaseController<ProjectIdController> {

        #region .ctor

        public ProjectIdController(ILogger<ProjectIdController> logger)
            : base(logger) {
        }

        #endregion

        #region Method members
        [HttpGet("project/all"),
        AllowAnonymous]
        public IEnumerable<Project> GetAllProjectIds() => new Project[]
        {
            new Project()
            {
                Abstract = "abstract_00",
                Concepts = Array.Empty<Concept>(),
                End = "end_00",
                FundingOrganization = "fundingOrganization_00",
                GrantDirectCosts = "grantDirectCosts_00",
                ID = "id_00",
                LocalAwardId = "localAwardId_00",
                Name = "name_00",
                OrganizationInternalId = "organizationInternalId_00",
                OrganizationRingoldId = "organizationRingoldId_00",
                Persons = Array.Empty<Person>(),
                PrincipalInternalID = "principalInternalID_00",
                PrincipalInvestigatorName = "principalInvestigatorName_00",
                Reference = "reference_00",
                SponsorAwardId = "sponsorAwardId_00",
                Start = "start_00",
                TotalAwardAmount = "totalAwardAmount_00"
            },
            new Project()
            {
                Abstract = "abstract_01",
                Concepts = Array.Empty<Concept>(),
                End = "end_01",
                FundingOrganization = "fundingOrganization_01",
                GrantDirectCosts = "grantDirectCosts_01",
                ID = "id_01",
                LocalAwardId = "localAwardId_01",
                Name = "name_01",
                OrganizationInternalId = "organizationInternalId_01",
                OrganizationRingoldId = "organizationRingoldId_01",
                Persons = Array.Empty<Person>(),
                PrincipalInternalID = "principalInternalID_01",
                PrincipalInvestigatorName = "principalInvestigatorName_01",
                Reference = "reference_01",
                SponsorAwardId = "sponsorAwardId_01",
                Start = "start_01",
                TotalAwardAmount = "totalAwardAmount_01"
            },
            new Project()
            {
                Abstract = "abstract_02",
                Concepts = Array.Empty<Concept>(),
                End = "end_02",
                FundingOrganization = "fundingOrganization_02",
                GrantDirectCosts = "grantDirectCosts_02",
                ID = "id_02",
                LocalAwardId = "localAwardId_02",
                Name = "name_02",
                OrganizationInternalId = "organizationInternalId_02",
                OrganizationRingoldId = "organizationRingoldId_02",
                Persons = Array.Empty<Person>(),
                PrincipalInternalID = "principalInternalID_02",
                PrincipalInvestigatorName = "principalInvestigatorName_02",
                Reference = "reference_02",
                SponsorAwardId = "sponsorAwardId_02",
                Start = "start_02",
                TotalAwardAmount = "totalAwardAmount_02"
            },

        };

        [HttpGet("project"),
            AllowAnonymous]
        public IEnumerable<Project> GetProjectIds(
            [FromQuery] string? @abstract,
            [FromQuery] string? end,
            [FromQuery] string? fundingOrganization,
            [FromQuery] string? grantDirectCosts,
            [FromQuery] string? id,
            [FromQuery] string? localAwardId,
            [FromQuery] string? name,
            [FromQuery] string? organizationInternalId,
            [FromQuery] string? organizationRingoldId,
            [FromQuery] string? principalInternalID,
            [FromQuery] string? principalInvestigatorName,
            [FromQuery] string? reference,
            [FromQuery] string? sponsorAwardId,
            [FromQuery] string? start,
            [FromQuery] string? totalAwardAmount
            ) => (from t0 in this.GetAllProjectIds()
                  where (
                    @abstract.IsEqual(t0.Abstract)
                  || end.IsEqual(t0.End)
                  || fundingOrganization.IsEqual(t0.FundingOrganization)
                  || grantDirectCosts.IsEqual(t0.GrantDirectCosts)
                  || id.IsEqual(t0.ID)
                  || localAwardId.IsEqual(t0.LocalAwardId)
                  || name.IsEqual(t0.Name)
                  || organizationInternalId.IsEqual(t0.OrganizationInternalId)
                  || organizationRingoldId.IsEqual(t0.OrganizationRingoldId)
                  || principalInternalID.IsEqual(t0.PrincipalInternalID)
                  || principalInvestigatorName.IsEqual(t0.PrincipalInvestigatorName)
                  || reference.IsEqual(t0.Reference)
                  || sponsorAwardId.IsEqual(t0.SponsorAwardId)
                  || start.IsEqual(t0.Start)
                  || totalAwardAmount.IsEqual(t0.TotalAwardAmount)
                  )
                  select t0);


        #endregion
    }
}
