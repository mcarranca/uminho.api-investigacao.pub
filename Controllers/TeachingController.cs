﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Identity.Web.Resource;
using System;
using System.Reflection.Emit;
using uminho.api_investigacao.pub.Entities;

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
        public IEnumerable<Teaching> GetAllTeaching() => new Teaching[]
        {
            new Teaching()
            {
                Role = "role_00",
                Period = "period_00",
                CurricularUnit = new CurricularUnit {
                                    InternalID = "internalID_00",
                                    Name= "name_00",
                                    Concepts = new Concept[] {
                                        new Concept() {
                                            Id = "id_00",
                                            Name = "name_00" },
                                        new Concept() {
                                            Id = "id_01",
                                            Name = "name_01"
                                        }
                                    },
                                    Courses = new Course[] {
                                        new Course() {
                                        InternalID = "id_00",
                                        Name = "name_00",
                                        Concepts = new Concept[] {
                                            new Concept(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new Concept(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new Degree[] {
                                            new Degree()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new Degree()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                    new Course()
                                    {
                                        InternalID = "id_01",
                                        Concepts = new Concept[] {
                                            new Concept(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new Concept(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new Degree[] {
                                            new Degree()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new Degree()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                }
                              }
            },
            new Teaching
            {
                Role = "role_01",
                Period = "period_01",
                CurricularUnit = new CurricularUnit {
                                    InternalID = "internalID_01",
                                    Name= "name_01",
                                     Concepts = new Concept[] {
                                        new Concept(){
                                             Id = "id_00",
                                             Name = "name_00"
                                        },
                                        new Concept(){
                                             Id = "id_01",
                                             Name = "name_01"
                                        },
                                    },
                                    Courses = new Course[] {
                                        new Course() {
                                        InternalID = "id_00",
                                        Name = "name_00",
                                        Concepts = new Concept[] {
                                            new Concept(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new Concept(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new Degree[] {
                                            new Degree()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new Degree()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                    new Course()
                                    {
                                        InternalID = "id_01",
                                        Concepts = new Concept[] {
                                            new Concept(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new Concept(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new Degree[] {
                                            new Degree()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new Degree()
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
        public IEnumerable<Teaching> GetTeaching(
          [FromQuery] string? roleID
            )
            => (from t0 in this.GetAllTeaching()
                where (roleID.IsEqual(t0.Role))
                select t0);

        [HttpGet("curricularUnit/all"),
       AllowAnonymous]
        public IEnumerable<CurricularUnit> GetAllCurricularUnit() => new CurricularUnit[]
       {
           new CurricularUnit
           {
               InternalID = "id_00",
               Name = "name_00",
                Concepts = new Concept[] {
                    new Concept(){
                         Id = "id_00",
                         Name = "name_00"
                    },
                    new Concept(){
                         Id = "id_01",
                         Name = "name_01"
                    },
                },
               Courses = new Course[] {
                                        new Course() {
                                        InternalID = "id_00",
                                        Name = "name_00",
                                        Concepts = new Concept[] {
                                            new Concept(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new Concept(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new Degree[] {
                                            new Degree()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new Degree()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                    new Course()
                                    {
                                        InternalID = "id_01",
                                        Concepts = new Concept[] {
                                            new Concept(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new Concept(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new Degree[] {
                                            new Degree()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new Degree()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                }
           },
           new CurricularUnit
           {
               InternalID = "id_01",
               Name = "name_01",
                Concepts = new Concept[] {
                    new Concept(){
                         Id = "id_00",
                         Name = "name_00"
                    },
                    new Concept(){
                         Id = "id_01",
                         Name = "name_01"
                    },
                },
               Courses = new Course[] {
                                        new Course() {
                                        InternalID = "id_00",
                                        Name = "name_00",
                                        Concepts = new Concept[] {
                                            new Concept(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new Concept(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new Degree[] {
                                            new Degree()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new Degree()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                    new Course()
                                    {
                                        InternalID = "id_01",
                                        Concepts = new Concept[] {
                                            new Concept(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new Concept(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new Degree[] {
                                            new Degree()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new Degree()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                }
           },
           new CurricularUnit
           {
               InternalID = "id_02",
               Name = "name_02",
                Concepts = new Concept[] {
                    new Concept(){
                         Id = "id_00",
                         Name = "name_00"
                    },
                    new Concept(){
                         Id = "id_01",
                         Name = "name_01"
                    },
                },
                Courses = new Course[] {
                        new Course() {
                        InternalID = "id_00",
                        Name = "name_00",
                        Concepts = new Concept[] {
                            new Concept(){
                                    Id = "id_00",
                                    Name = "name_00"
                            },
                            new Concept(){
                                    Id = "id_01",
                                    Name = "name_01"
                            },
                        },
                        Degrees = new Degree[] {
                            new Degree()
                            {
                                InternalID = "id_00",
                                Name = "name_00"
                            },
                            new Degree()
                            {
                                InternalID = "id_01",
                                Name = "name_01"
                            }
                        }
                    },
                    new Course()
                    {
                        InternalID = "id_01",
                        Concepts = new Concept[] {
                            new Concept(){
                                    Id = "id_00",
                                    Name = "name_00"
                            },
                            new Concept(){
                                    Id = "id_01",
                                    Name = "name_01"
                            },
                        },
                        Degrees = new Degree[] {
                            new Degree()
                            {
                                InternalID = "id_00",
                                Name = "name_00"
                            },
                            new Degree()
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
        public IEnumerable<CurricularUnit> GetCurricularUnit(
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
        public IEnumerable<Concept> GetAllConcepts() => new Concept[]
        {
            new Concept
            {
                Id = "id_00",
                Name = "name_00",
            },
            new Concept
            {
                Id = "id_01",
                Name = "name_01",
            },
            new Concept
            {
                Id = "id_02",
                Name = "name_02",
            }
        };


        [HttpGet("Concept"),
          AllowAnonymous]
        public IEnumerable<Concept> GetConcept(
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
        public IEnumerable<TeachingRoles> GetAllTeachingRoles() => new TeachingRoles[]
        {
            new TeachingRoles()
            {
                Role = "role_00",
                Period = "period_00",
                _CurricularUnit = new CurricularUnit {
                                    InternalID = "internalID_00",
                                    Name= "name_00",
                                     Concepts = new Concept[] {
                                        new Concept(){
                                             Id = "id_00",
                                             Name = "name_00"
                                        },
                                        new Concept(){
                                             Id = "id_01",
                                             Name = "name_01"
                                        },
                                    },
                                    Courses = new Course[] {
                                        new Course() {
                                        InternalID = "id_00",
                                        Name = "name_00",
                                        Concepts = new Concept[] {
                                            new Concept(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new Concept(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new Degree[] {
                                            new Degree()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new Degree()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                    new Course()
                                    {
                                        InternalID = "id_01",
                                        Concepts = new Concept[] {
                                            new Concept(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new Concept(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new Degree[] {
                                            new Degree()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new Degree()
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
            new TeachingRoles
            {
                Role = "role_01",
                Period = "period_01",
                _CurricularUnit = new CurricularUnit {
                                    InternalID = "internalID_01",
                                    Name= "name_01",
                                     Concepts = new Concept[] {
                                        new Concept(){
                                             Id = "id_00",
                                             Name = "name_00"
                                        },
                                        new Concept(){
                                             Id = "id_01",
                                             Name = "name_01"
                                        },
                                    },
                                    Courses = new Course[] {
                                        new Course() {
                                        InternalID = "id_00",
                                        Name = "name_00",
                                        Concepts = new Concept[] {
                                            new Concept(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new Concept(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new Degree[] {
                                            new Degree()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new Degree()
                                            {
                                                InternalID = "id_01",
                                                Name = "name_01"
                                            }
                                        }
                                    },
                                    new Course()
                                    {
                                        InternalID = "id_01",
                                        Concepts = new Concept[] {
                                            new Concept(){
                                                    Id = "id_00",
                                                    Name = "name_00"
                                            },
                                            new Concept(){
                                                    Id = "id_01",
                                                    Name = "name_01"
                                            },
                                        },
                                        Degrees = new Degree[] {
                                            new Degree()
                                            {
                                                InternalID = "id_00",
                                                Name = "name_00"
                                            },
                                            new Degree()
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
        public IEnumerable<TeachingRoles> GetTeachingRole(
          [FromQuery] string? roleID
            )
            => (from t0 in this.GetAllTeachingRoles()
                where (roleID.IsEqual(t0.Role))
                select t0);


        [HttpGet("course/all"),
         AllowAnonymous]
        public IEnumerable<Course> GetAllCourse() => new Course[]
        {
            new Course()
            {
                InternalID = "id_00",
                Name = "name_00",
                Concepts = new Concept[] {
                    new Concept(){
                         Id = "id_00",
                         Name = "name_00"
                    },
                    new Concept(){
                         Id = "id_01",
                         Name = "name_01"
                    },
                },
                Degrees = new Degree[] {
                    new Degree()
                    {
                        InternalID = "id_00",
                        Name = "name_00"
                    },
                    new Degree()
                    {
                        InternalID = "id_01",
                        Name = "name_01"
                    }
                }
            },
            new Course()
            {
                InternalID = "id_01",
                Concepts = new Concept[] {
                    new Concept(){
                         Id = "id_00",
                         Name = "name_00"
                    },
                    new Concept(){
                         Id = "id_01",
                         Name = "name_01"
                    },
                },
                Degrees = new Degree[] {
                    new Degree()
                    {
                        InternalID = "id_00",
                        Name = "name_00"
                    },
                    new Degree()
                    {
                        InternalID = "id_01",
                        Name = "name_01"
                    }
                }
            },
            new Course()
            {
                InternalID = "id_02",
                Name = "name_02",
                Concepts = new Concept[] {
                    new Concept(){
                         Id = "id_00",
                         Name = "name_00"
                    },
                    new Concept(){
                         Id = "id_01",
                         Name = "name_01"
                    },
                },
                Degrees = new Degree[] {
                    new Degree()
                    {
                        InternalID = "id_00",
                        Name = "name_00"
                    },
                    new Degree()
                    {
                        InternalID = "id_01",
                        Name = "name_01"
                    }
                }
            }
        };

        [HttpGet("course"),
        AllowAnonymous]
        public IEnumerable<Course> GetCourse(
                [FromQuery] string? iD,
                [FromQuery] string? name
          )
          => (from t0 in this.GetAllCourse()
              where (iD.IsEqual(t0.InternalID)
                        || name.IsEqual(t0.Name))
              select t0);


        [HttpGet("degree/all"),
         AllowAnonymous]
        public IEnumerable<Degree> GetAllDegree() => new Degree[]
        {
            new Degree()
            {
                InternalID = "id_00",
                Name = "name_00"
            },
            new Degree()
            {
                InternalID = "id_01",
                Name = "name_01"
            }
        };

        [HttpGet("degree"),
        AllowAnonymous]
        public IEnumerable<Degree> GetDegree(
                [FromQuery] string? iD,
                [FromQuery] string? name
          )
          => (from t0 in this.GetAllDegree()
              where (iD.IsEqual(t0.InternalID)
                        || name.IsEqual(t0.Name))
              select t0);

        [HttpGet("advising/all"),
         AllowAnonymous]
        public IEnumerable<Advising> GetAllAdvising() => new Advising[]
        {
            new Advising()
            {
                AdvisingroleID = "id_00",
                AdvisingroleName = "roleName_00",
                AdviseName = "name_00",
                AdviseID = "id_00",
                Persons = new Person[]
                {
                    new Person()
                    {

                    },
                    new Person()
                    {

                    }
                },
                Start = "01-01-1900",
                End = "01-01-2999",
                Degree= new Degree() {
                             InternalID = "id_00",
                             Name = "name_00"
                        },
                CourseName = "name_00"
                CourseID = "id_00",
            }
        };

        [HttpGet("advising"), AllowAnonymous]
        public IEnumerable<Advising> GetAdvising(
            [FromQuery] string? Id,
            [FromQuery] string? name) => (from t0 in this.GetAllAdvising()
                                          where (Id.IsEqual(t0.AdviseID)
                                                    || name.IsEqual(t0.AdviseName))
                                          select t0);

        #endregion
    }
}
