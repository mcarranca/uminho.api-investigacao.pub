using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Identity.Web.Resource;
using System;
using System.Reflection.Emit;
using uminho.api_investigacao.pub.Entities;
using uminho.api_investigacao.pub.Framework;

namespace uminho.api_investigacao.pub.Controllers
{
    [Authorize]
    [ApiController]
    //[Route("v1/[controller]")]
    [Route("v1")]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class TeachingController : BaseController<TeachingController>
    {
        #region .ctor
        public TeachingController(ILogger<TeachingController> logger) : base(logger)
        {

        }
        #endregion

        #region HTTP Methods

        [HttpGet("teaching/all"),
        AllowAnonymous]
        public IEnumerable<TeachingEntity> GetAllTeaching() => new TeachingEntity[]
        {
            new TeachingEntity()
            {
                Role = "role_00",
                Period = "period_00",
                CurricularUnit = new CurricularUnitEntity {
                                    InternalID = "internalID_00",
                                    Name= "name_00",
                                    Concepts = new ConceptEntity[] {
                                        new ConceptEntity() {
                                            Id = "id_00",
                                            Name = "name_00" },
                                        new ConceptEntity() {
                                            Id = "id_01",
                                            Name = "name_01"
                                        }
                                    },
                                    Courses = new CourseEntity[] {
                                        new CourseEntity() {
                                        InternalID = "id_00",
                                        Name = "name_00",
                                        Concepts = new ConceptEntity[] {
                                            new ConceptEntity(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new ConceptEntity(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new DegreeEntity[] {
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                    new CourseEntity()
                                    {
                                        InternalID = "id_01",
                                        Concepts = new ConceptEntity[] {
                                            new ConceptEntity(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new ConceptEntity(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new DegreeEntity[] {
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                }
                              }
            },
            new TeachingEntity
            {
                Role = "role_01",
                Period = "period_01",
                CurricularUnit = new CurricularUnitEntity {
                                    InternalID = "internalID_01",
                                    Name= "name_01",
                                     Concepts = new ConceptEntity[] {
                                        new ConceptEntity(){
                                             Id = "id_00",
                                             Name = "name_00"
                                        },
                                        new ConceptEntity(){
                                             Id = "id_01",
                                             Name = "name_01"
                                        },
                                    },
                                    Courses = new CourseEntity[] {
                                        new CourseEntity() {
                                        InternalID = "id_00",
                                        Name = "name_00",
                                        Concepts = new ConceptEntity[] {
                                            new ConceptEntity(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new ConceptEntity(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new DegreeEntity[] {
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                    new CourseEntity()
                                    {
                                        InternalID = "id_01",
                                        Concepts = new ConceptEntity[] {
                                            new ConceptEntity(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new ConceptEntity(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new DegreeEntity[] {
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                }
                             }
            },
        };

        [HttpGet("Teaching"),
          AllowAnonymous]
        public IEnumerable<TeachingEntity> GetTeaching(
          [FromQuery] string? roleID
            )
            => (from t0 in this.GetAllTeaching()
                where (roleID.IsEqual(t0.Role))
                select t0);

        [HttpGet("curricularUnit/all"),
       AllowAnonymous]
        public IEnumerable<CurricularUnitEntity> GetAllCurricularUnit() => new CurricularUnitEntity[]
       {
           new CurricularUnitEntity
           {
               InternalID = "id_00",
               Name = "name_00",
                Concepts = new ConceptEntity[] {
                    new ConceptEntity(){
                         Id = "id_00",
                         Name = "name_00"
                    },
                    new ConceptEntity(){
                         Id = "id_01",
                         Name = "name_01"
                    },
                },
               Courses = new CourseEntity[] {
                                        new CourseEntity() {
                                        InternalID = "id_00",
                                        Name = "name_00",
                                        Concepts = new ConceptEntity[] {
                                            new ConceptEntity(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new ConceptEntity(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new DegreeEntity[] {
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                    new CourseEntity()
                                    {
                                        InternalID = "id_01",
                                        Concepts = new ConceptEntity[] {
                                            new ConceptEntity(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new ConceptEntity(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new DegreeEntity[] {
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                }
           },
           new CurricularUnitEntity
           {
               InternalID = "id_01",
               Name = "name_01",
                Concepts = new ConceptEntity[] {
                    new ConceptEntity(){
                         Id = "id_00",
                         Name = "name_00"
                    },
                    new ConceptEntity(){
                         Id = "id_01",
                         Name = "name_01"
                    },
                },
               Courses = new CourseEntity[] {
                                        new CourseEntity() {
                                        InternalID = "id_00",
                                        Name = "name_00",
                                        Concepts = new ConceptEntity[] {
                                            new ConceptEntity(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new ConceptEntity(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new DegreeEntity[] {
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                    new CourseEntity()
                                    {
                                        InternalID = "id_01",
                                        Concepts = new ConceptEntity[] {
                                            new ConceptEntity(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new ConceptEntity(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new DegreeEntity[] {
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                }
           },
           new CurricularUnitEntity
           {
               InternalID = "id_02",
               Name = "name_02",
                Concepts = new ConceptEntity[] {
                    new ConceptEntity(){
                         Id = "id_00",
                         Name = "name_00"
                    },
                    new ConceptEntity(){
                         Id = "id_01",
                         Name = "name_01"
                    },
                },
                Courses = new CourseEntity[] {
                        new CourseEntity() {
                        InternalID = "id_00",
                        Name = "name_00",
                        Concepts = new ConceptEntity[] {
                            new ConceptEntity(){
                                    Id = "id_00",
                                    Name = "name_00"
                            },
                            new ConceptEntity(){
                                    Id = "id_01",
                                    Name = "name_01"
                            },
                        },
                        Degrees = new DegreeEntity[] {
                            new DegreeEntity()
                            {
                                InternalID = "id_00",
                                Name = "name_00"
                            },
                            new DegreeEntity()
                            {
                                InternalID = "id_01",
                                Name = "name_01"
                            }
                        }
                    },
                    new CourseEntity()
                    {
                        InternalID = "id_01",
                        Concepts = new ConceptEntity[] {
                            new ConceptEntity(){
                                    Id = "id_00",
                                    Name = "name_00"
                            },
                            new ConceptEntity(){
                                    Id = "id_01",
                                    Name = "name_01"
                            },
                        },
                        Degrees = new DegreeEntity[] {
                            new DegreeEntity()
                            {
                                InternalID = "id_00",
                                Name = "name_00"
                            },
                            new DegreeEntity()
                            {
                                InternalID = "id_01",
                                Name = "name_01"
                            }
                        }
                    },
                }
           }
       };


        [HttpGet("CurricularUnit"),
          AllowAnonymous]
        public IEnumerable<CurricularUnitEntity> GetCurricularUnit(
          [FromQuery] string? internalID,
          [FromQuery] string? name
            )
            => (from t0 in this.GetAllCurricularUnit()
                where (internalID.IsEqual(t0.InternalID)
                         || name.IsEqual(t0.Name)
                      )
                select t0);

        [HttpGet("concept/all"),
        AllowAnonymous]
        public IEnumerable<ConceptEntity> GetAllConcepts() => new ConceptEntity[]
        {
            new ConceptEntity
            {
                Id = "id_00",
                Name = "name_00",
            },
            new ConceptEntity
            {
                Id = "id_01",
                Name = "name_01",
            },
            new ConceptEntity
            {
                Id = "id_02",
                Name = "name_02",
            }
        };


        [HttpGet("Concept"),
          AllowAnonymous]
        public IEnumerable<ConceptEntity> GetConcept(
          [FromQuery] string? id,
          [FromQuery] string? name
            )
            => (from t0 in this.GetAllConcepts()
                where (id.IsEqual(t0.Id)
                         || name.IsEqual(t0.Name)
                      )
                select t0);


        [HttpGet("teachingRoles/all"),
        AllowAnonymous]
        public IEnumerable<TeachingRoleEntity> GetAllTeachingRoles() => new TeachingRoleEntity[]
        {
            new TeachingRoleEntity()
            {
                Role = "role_00",
                Period = "period_00",
                CurricularUnit = new CurricularUnitEntity {
                                    InternalID = "internalID_00",
                                    Name= "name_00",
                                     Concepts = new ConceptEntity[] {
                                        new ConceptEntity(){
                                             Id = "id_00",
                                             Name = "name_00"
                                        },
                                        new ConceptEntity(){
                                             Id = "id_01",
                                             Name = "name_01"
                                        },
                                    },
                                    Courses = new CourseEntity[] {
                                        new CourseEntity() {
                                        InternalID = "id_00",
                                        Name = "name_00",
                                        Concepts = new ConceptEntity[] {
                                            new ConceptEntity(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new ConceptEntity(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new DegreeEntity[] {
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                    new CourseEntity()
                                    {
                                        InternalID = "id_01",
                                        Concepts = new ConceptEntity[] {
                                            new ConceptEntity(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new ConceptEntity(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new DegreeEntity[] {
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                }
                                },
                CurricularUnitInternalId = "id_00"
            },
            new TeachingRoleEntity
            {
                Role = "role_01",
                Period = "period_01",
                CurricularUnit = new CurricularUnitEntity {
                                    InternalID = "internalID_01",
                                    Name= "name_01",
                                     Concepts = new ConceptEntity[] {
                                        new ConceptEntity(){
                                             Id = "id_00",
                                             Name = "name_00"
                                        },
                                        new ConceptEntity(){
                                             Id = "id_01",
                                             Name = "name_01"
                                        },
                                    },
                                    Courses = new CourseEntity[] {
                                        new CourseEntity() {
                                        InternalID = "id_00",
                                        Name = "name_00",
                                        Concepts = new ConceptEntity[] {
                                            new ConceptEntity(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new ConceptEntity(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new DegreeEntity[] {
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                    new CourseEntity()
                                    {
                                        InternalID = "id_01",
                                        Concepts = new ConceptEntity[] {
                                            new ConceptEntity(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new ConceptEntity(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new DegreeEntity[] {
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new DegreeEntity()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                }
                            },
                CurricularUnitInternalId = "id_01"
            },
        };

        [HttpGet("teachingRoles"),
          AllowAnonymous]
        public IEnumerable<TeachingRoleEntity> GetTeachingRole(
          [FromQuery] string? roleID
            )
            => (from t0 in this.GetAllTeachingRoles()
                where (roleID.IsEqual(t0.Role))
                select t0);


        [HttpGet("course/all"),
         AllowAnonymous]
        public IEnumerable<CourseEntity> GetAllCourse() => new CourseEntity[]
        {
            new CourseEntity()
            {
                InternalID = "id_00",
                Name = "name_00",
                Concepts = new ConceptEntity[] {
                    new ConceptEntity(){
                         Id = "id_00",
                         Name = "name_00"
                    },
                    new ConceptEntity(){
                         Id = "id_01",
                         Name = "name_01"
                    },
                },
                Degrees = new DegreeEntity[] {
                    new DegreeEntity()
                    {
                        InternalID = "id_00",
                        Name = "name_00"
                    },
                    new DegreeEntity()
                    {
                        InternalID = "id_01",
                        Name = "name_01"
                    }
                }
            },
            new CourseEntity()
            {
                InternalID = "id_01",
                Concepts = new ConceptEntity[] {
                    new ConceptEntity(){
                         Id = "id_00",
                         Name = "name_00"
                    },
                    new ConceptEntity(){
                         Id = "id_01",
                         Name = "name_01"
                    },
                },
                Degrees = new DegreeEntity[] {
                    new DegreeEntity()
                    {
                        InternalID = "id_00",
                        Name = "name_00"
                    },
                    new DegreeEntity()
                    {
                        InternalID = "id_01",
                        Name = "name_01"
                    }
                }
            },
            new CourseEntity()
            {
                InternalID = "id_02",
                Name = "name_02",
                Concepts = new ConceptEntity[] {
                    new ConceptEntity(){
                         Id = "id_00",
                         Name = "name_00"
                    },
                    new ConceptEntity(){
                         Id = "id_01",
                         Name = "name_01"
                    },
                },
                Degrees = new DegreeEntity[] {
                    new DegreeEntity()
                    {
                        InternalID = "id_00",
                        Name = "name_00"
                    },
                    new DegreeEntity()
                    {
                        InternalID = "id_01",
                        Name = "name_01"
                    }
                }
            }
        };

        [HttpGet("course"),
        AllowAnonymous]
        public IEnumerable<CourseEntity> GetCourse(
                [FromQuery] string? iD,
                [FromQuery] string? name
          )
          => (from t0 in this.GetAllCourse()
              where (iD.IsEqual(t0.InternalID)
                        || name.IsEqual(t0.Name))
              select t0);


        [HttpGet("degree/all"),
         AllowAnonymous]
        public IEnumerable<DegreeEntity> GetAllDegree() => new DegreeEntity[]
        {
            new DegreeEntity()
            {
                InternalID = "id_00",
                Name = "name_00"
            },
            new DegreeEntity()
            {
                InternalID = "id_01",
                Name = "name_01"
            }
        };

        [HttpGet("degree"),
        AllowAnonymous]
        public IEnumerable<DegreeEntity> GetDegree(
                [FromQuery] string? iD,
                [FromQuery] string? name
          )
          => (from t0 in this.GetAllDegree()
              where (iD.IsEqual(t0.InternalID)
                        || name.IsEqual(t0.Name))
              select t0);

        [HttpGet("advising/all"),
         AllowAnonymous]
        public IEnumerable<AdvisingEntity> GetAllAdvising() => new AdvisingEntity[]
        {
            new AdvisingEntity()
            {
                AdvisingroleID = "id_00",
                AdvisingroleName = "roleName_00",
                AdviseName = "name_00",
                AdviseID = "id_00",
                Persons = new PersonEntity[]
                {
                    new PersonEntity()
                    {

                    },
                    new PersonEntity()
                    {

                    }
                },
                Start = "01-01-1900",
                End = "01-01-2999",
                Degree= new DegreeEntity() {
                             InternalID = "id_00",
                             Name = "name_00"
                        },
                CourseName = "name_00",
                CourseID = "id_00",
            }
        };

        [HttpGet("advising"), AllowAnonymous]
        public IEnumerable<AdvisingEntity> GetAdvising(
            [FromQuery] string? Id,
            [FromQuery] string? name) => (from t0 in this.GetAllAdvising()
                                          where (Id.IsEqual(t0.AdviseID)
                                                    || name.IsEqual(t0.AdviseName))
                                          select t0);

        #endregion
    }
}
