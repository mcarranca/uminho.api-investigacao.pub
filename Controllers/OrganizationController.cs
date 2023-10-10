using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using uminho.api_investigacao.pub.Entities;
using uminho.api_investigacao.pub.Framework;

namespace uminho.api_investigacao.pub.Controllers {
    [Route("v1")]
    [Authorize]
    [ApiController]
    public class OrganizationController
        : BaseController<OrganizationController> {

        #region .ctor
        public OrganizationController(ILogger<OrganizationController> logger)
            : base(logger) {
        }
        #endregion

        #region HTTP Methods

        [HttpGet("organization/all"),
        AllowAnonymous]
        public IEnumerable<OrganizationEntity> GetAllOrganization() => new OrganizationEntity[]
        {
            new OrganizationEntity()
            {
                Name = "name_00",
                InternalD = "id_00",
                RingGoldId = "rng_00",
                Abbreviation = "abb_00",
                Email = "email_00@xpto.com",
                Geo = "geo_00",
                Logo = "log_00",
                Type = "typ_00",
                ParentInternalID = "id_00",
                ParentRingGoldId = "id_00",
                ParentName = "pname_00",
                Address = new AdressEntity[]{
                    new AdressEntity()
                    {
                        Locality = "loc_00",
                        PostalCode = "0000-000",
                        StreetAddress = "adress_00"
                    },
                    new AdressEntity()
                    {
                        Locality = "loc_01",
                        PostalCode = "0001-001",
                        StreetAddress = "adress_01"
                    }
                }
            },
            new OrganizationEntity()
            {
                Name = "name_01",
                InternalD = "id_01",
                RingGoldId = "rng_01",
                Abbreviation = "abb_01",
                Email = "email_01@xpto.com",
                Geo = "geo_01",
                Logo = "log_01",
                Type = "typ_01",
                ParentInternalID = "id_01",
                ParentRingGoldId = "id_01",
                ParentName = "pname_01",
                Address = new AdressEntity[]{
                    new AdressEntity()
                    {
                        Locality = "loc_00",
                        PostalCode = "0000-000",
                        StreetAddress = "adress_00"
                    },
                    new AdressEntity()
                    {
                        Locality = "loc_01",
                        PostalCode = "0001-001",
                        StreetAddress = "adress_01"
                    }
                }
            }
        };

        [HttpGet("organization"), AllowAnonymous]
        public IEnumerable<OrganizationEntity> GetOrganization(
          [FromQuery] string? internalD,
          [FromQuery] string? name) => from t0 in GetAllOrganization()
                                       where internalD.IsEqual(t0.InternalD)
                                                 || name.IsEqual(t0.Name)
                                       select t0;

        #endregion
    }
}
