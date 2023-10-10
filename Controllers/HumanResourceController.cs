using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using uminho.api_investigacao.pub.Entities;
using uminho.api_investigacao.pub.Framework;
using static uminho.api_investigacao.pub.Entities.PersonEntity;

namespace uminho.api_investigacao.pub.Controllers
{

    [Authorize]
    [ApiController]
    //[Route("v1/[controller]")]
    [Route("v1")]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class HumanResourceController
        : BaseController<HumanResourceController> {

        #region .ctor

        public HumanResourceController(ILogger<HumanResourceController> logger)
            : base(logger) {
        }

        #endregion

        #region Method members

        [HttpGet("person/all"),
            AllowAnonymous]
        public IEnumerable<PersonEntity> GetAllPersons() => new PersonEntity[] {
            new PersonEntity() {
                AdditionalName = "additionalName_01",
                Concept = new PersonEntity.ConceptEntity[] { },
                Email = "email _01",
                FamilyName  = "familyName_01",
                GivenName = "givenName_01",
                InternalID = "internalID_01",
                OrganizationInternalId = "organizationInternalId_01",
                OrganizationRinggoldId = "organizationRinggoldId_01",
                PersonIds = new PersonEntity[] { },
                Phone = "phone_01",
                Photo = "photo_01",
                Positions = new PersonEntity.PositionEntity[] { },
                Name = "name_01",
            },
            new PersonEntity() {
                AdditionalName = "additionalName_01",
                Concept = new PersonEntity.ConceptEntity[] { },
                Email = "email _01",
                FamilyName  = "familyName_01",
                GivenName = "givenName_01",
                InternalID = "internalID_01",
                OrganizationInternalId = "organizationInternalId_01",
                OrganizationRinggoldId = "organizationRinggoldId_01",
                PersonIds = new PersonEntity[] { },
                Phone = "phone_01",
                Photo = "photo_01",
                Positions = new PersonEntity.PositionEntity[] { },
                Name = "name_01",
            },
            new PersonEntity() {
                AdditionalName = "additionalName_02",
                Concept = new PersonEntity.ConceptEntity[] { },
                Email = "email _02",
                FamilyName  = "familyName_02",
                GivenName = "givenName_02",
                InternalID = "internalID_02",
                OrganizationInternalId = "organizationInternalId_02",
                OrganizationRinggoldId = "organizationRinggoldId_02",
                PersonIds = new PersonEntity[] { },
                Phone = "phone_02",
                Photo = "photo_02",
                Positions = new PersonEntity.PositionEntity[] { },
                Name = "name_02",
            },
        };

        [HttpGet("person"),
        AllowAnonymous]
        public IEnumerable<PersonEntity> GetPersons(
            [FromQuery] string? internalID,
            [FromQuery] string? additionalName,
            [FromQuery] string? email,
            [FromQuery] string? familyName,
            [FromQuery] string? givenName,
            [FromQuery] string? name,
            [FromQuery] string? organizationInternalId,
            [FromQuery] string? organizationRinggoldId,
            [FromQuery] string? phone,
            [FromQuery] string? photo
        ) => (from t0 in this.GetAllPersons()
              where (
                      internalID.IsEqual(t0.InternalID)
              || additionalName.IsEqual(t0.AdditionalName)
              || email.IsEqual(t0.Email)
              || familyName.IsEqual(t0.FamilyName)
              || givenName.IsEqual(t0.GivenName)
              || name.IsEqual(t0.Name)
              || organizationInternalId.IsEqual(t0.OrganizationInternalId)
              || organizationRinggoldId.IsEqual(t0.OrganizationRinggoldId)
              || phone.IsEqual(t0.Phone)
              || photo.IsEqual(t0.Photo)
                      )
              select t0);

        [HttpGet("person/position/all"),
            AllowAnonymous]
        public IEnumerable<PersonEntity.PositionEntity> GetAllPersonPositions() => new PersonEntity.PositionEntity[] {
            new PersonEntity.PositionEntity() {
                ID = "id_01",
                Name = "name_01",
                Start = "start_01",
                End = "end_01",
            },
            new PersonEntity.PositionEntity() {
                ID = "id_01",
                Name = "name_01",
                Start = "start_01",
                End = "end_01",
            },
            new PersonEntity.PositionEntity() {
                ID = "id_02",
                Name = "name_02",
                Start = "start_02",
                End = "end_02",
            },
        };
        [HttpGet("person/{internalD}/position"),
        AllowAnonymous]
        public IEnumerable<PersonEntity.PositionEntity> GetPersonPositions(
            string? internalD
        ) => (from t0 in this.GetAllPersonPositions()
              where (
                      internalD.IsEqual(t0.ID)
                      )
              select t0);

        [HttpGet("person/concept/all"),
            AllowAnonymous]
        public IEnumerable<PersonEntity.ConceptEntity> GetAllPersonConcepts() => new PersonEntity.ConceptEntity[] {
            new PersonEntity.ConceptEntity() {
                ID = "id_01",
                Name = "name_01",
                OrganizationId = "organizationId_01",
            },
            new PersonEntity.ConceptEntity() {
                ID = "id_01",
                Name = "name_01",
                OrganizationId = "organizationId_01",
            },
            new PersonEntity.ConceptEntity() {
                ID = "id_02",
                Name = "name_02",
                OrganizationId = "organizationId_02",
            },

        };
        [HttpGet("person/{internalD}/concept"),
        AllowAnonymous]
        public IEnumerable<PersonEntity.ConceptEntity> GetPersonConceptsByID(
            string? internalD
        ) => (from t0 in this.GetAllPersonConcepts()
              where (
                      internalD.IsEqual(t0.ID)
                      )
              select t0);

        [HttpGet("person/concept"),
        AllowAnonymous]
        public IEnumerable<PersonEntity.ConceptEntity> GetPersonConcepts(
            [FromQuery] string? id,
            [FromQuery] string? name,
            [FromQuery] string? organizationId
        ) => (from t0 in this.GetAllPersonConcepts()
              where (
                      id.IsEqual(t0.ID)
              || name.IsEqual(t0.Name)
              || organizationId.IsEqual(t0.OrganizationId)
                      )
              select t0);

        [HttpGet("person/affiliation/all"),
            AllowAnonymous]
        public IEnumerable<PersonEntity.AffiliationEntity> GetAllPersonAffiliations() => new PersonEntity.AffiliationEntity[] {
            new PersonEntity.AffiliationEntity() {
                OrganizationId = "organizationId_01",
                Organizationname = "organizationname_01",
                PositionID = "positionID_01",
                PositionName = "positionName_01",
                Start = "start_01",
                End = "end_01",
            },
            new PersonEntity.AffiliationEntity() {
                OrganizationId = "organizationId_01",
                Organizationname = "organizationname_01",
                PositionID = "positionID_01",
                PositionName = "positionName_01",
                Start = "start_01",
                End = "end_01",
            },
            new PersonEntity.AffiliationEntity() {
                OrganizationId = "organizationId_02",
                Organizationname = "organizationname_02",
                PositionID = "positionID_02",
                PositionName = "positionName_02",
                Start = "start_02",
                End = "end_02",
            },
        };
        [HttpGet("person/{internalD}/affiliation"),
        AllowAnonymous]
        public IEnumerable<PersonEntity.AffiliationEntity> GetPersonAffiliationsByID(
            string? internalD
        ) => (from t0 in this.GetAllPersonAffiliations()
              where (
                      internalD.IsEqual(t0.PositionID)
                      )
              select t0);

        [HttpGet("person/id/all"),
        AllowAnonymous]
        public IEnumerable<PersonEntity.IDEntity> GetAllIDs() => new PersonEntity.IDEntity[] {
            new PersonEntity.IDEntity() {
                IDName = "idname_00",
                IDValue = "idvalue_00"
            },
            new PersonEntity.IDEntity() {
                IDName = "idname_01",
                IDValue = "idvalue_01"
            },
            new PersonEntity.IDEntity() {
                IDName = "idname_02",
                IDValue = "idvalue_02"
            },
        };
        [HttpGet("person/{internalD}/IDs"),
        AllowAnonymous]
        public IEnumerable<PersonEntity.IDEntity> GetIDsByID(
            string? internalD
        ) => (from t0 in this.GetAllIDs()
              where (
                      internalD.IsEqual(t0.IDName)
                      )
              select t0);

        [HttpGet("person/degree/all"),
        AllowAnonymous]
        public IEnumerable<PersonEntity.DegreesEntity> GetAllDegrees() => new PersonEntity.DegreesEntity[] {
            new PersonEntity.DegreesEntity() {
                MajorField = "majorField_00",
                DepartmentOrSchool = "departmentOrSchool_00",
                SupplementalInformation = "supplementalInformation_00",
                Organization = "organization_00",
                Degree = "degree_00",
                Start = "start_00",
                End = "end_00",
            },
            new PersonEntity.DegreesEntity() {
                MajorField = "majorField_01",
                DepartmentOrSchool = "departmentOrSchool_01",
                SupplementalInformation = "supplementalInformation_01",
                Organization = "organization_01",
                Degree = "degree_01",
                Start = "start_01",
                End = "end_01",
            },
            new PersonEntity.DegreesEntity() {
                MajorField = "majorField_02",
                DepartmentOrSchool = "departmentOrSchool_02",
                SupplementalInformation = "supplementalInformation_02",
                Organization = "organization_02",
                Degree = "degree_02",
                Start = "start_02",
                End = "end_02",
            },
        };
        [HttpGet("person/{internalD}/degrees"),
        AllowAnonymous]
        public IEnumerable<PersonEntity.DegreesEntity> GetDegreesByIDs(
            string? internalD
        ) => (from t0 in this.GetAllDegrees()
              where (
                      internalD.IsEqual(t0.Degree)
                      )
              select t0);

        #endregion
    }
}
