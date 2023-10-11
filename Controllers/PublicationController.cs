using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using uminho.api_investigacao.pub.DatabaseContext;
using uminho.api_investigacao.pub.Entities;
using uminho.api_investigacao.pub.Framework;

namespace uminho.api_investigacao.pub.Controllers;
[Authorize]
[ApiController]
//[Route("v1/[controller]")]
[Route("v1")]
//[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
public class PublicationController
    : BaseController<PublicationController, PublicacoesDBContext> {

    #region .ctor

    public PublicationController(ILogger<PublicationController> logger, PublicacoesDBContext publicacoesDBContext)
        : base(logger, publicacoesDBContext) {
    }

    #endregion

    #region Method members

    [HttpGet("article/all"),
        AllowAnonymous]
    public IEnumerable<ArticleEntity> GetAllArticles() =>
        from publicacoes in DbContext.Publicacoes
        select new ArticleEntity {
            //Abstract = "abstract_00",
            //AuthorFamilyName = "authorFamilyName_00",
            //AuthorGivenName = "authorGivenName_00",
            //AuthorInternalId = "authorInternalId_00",
            //AuthormIddleName = "authormIddleName_00",
            //Authors = { },
            //AuthorshipRank = "authorshipRank_00",
            //Concept = "concept_00",
            DOI = publicacoes.PRISM_doi,
            EndPage = publicacoes.PRISM_pageRange,
            //Grant = "grant_00",
            Issue = publicacoes.PRISM_issueIdentifier,
            //Journal = "journal_00",
            //Label = "label_00",
            PublishDate = publicacoes.PRISM_coverDate,
            //StartPage = "startPage_00",
            Volume = publicacoes.PRISM_volume,
        };

    //new ArticleEntity[]
    //{
    //    new ArticleEntity()
    //    {
    //        Abstract = "abstract_00",
    //        AuthorFamilyName = "authorFamilyName_00",
    //        AuthorGivenName = "authorGivenName_00",
    //        AuthorInternalId = "authorInternalId_00",
    //        AuthormIddleName = "authormIddleName_00",
    //        Authors = {},
    //        AuthorshipRank = "authorshipRank_00",
    //        Concept = "concept_00",
    //        DOI = "doi_00",
    //        EndPage = "endPage_00",
    //        Grant = "grant_00",
    //        Issue = "issue_00",
    //        Journal = "journal_00",
    //        Label = "label_00",
    //        PublishDate = "publishDate_00",
    //        StartPage = "startPage_00",
    //        Volume  = "volumne_00",
    //    },
    //    new ArticleEntity()
    //    {
    //        Abstract = "abstract_01",
    //        AuthorFamilyName = "authorFamilyName_01",
    //        AuthorGivenName = "authorGivenName_01",
    //        AuthorInternalId = "authorInternalId_01",
    //        AuthormIddleName = "authormIddleName_01",
    //        Authors = {},
    //        AuthorshipRank = "authorshipRank_01",
    //        Concept = "concept_01",
    //        DOI = "doi_01",
    //        EndPage = "endPage_01",
    //        Grant = "grant_01",
    //        Issue = "issue_01",
    //        Journal = "journal_01",
    //        Label = "label_01",
    //        PublishDate = "publishDate_01",
    //        StartPage = "startPage_01",
    //        Volume  = "volumne_01",
    //    },
    //    new ArticleEntity()
    //    {
    //        Abstract = "abstract_02",
    //        AuthorFamilyName = "authorFamilyName_02",
    //        AuthorGivenName = "authorGivenName_02",
    //        AuthorInternalId = "authorInternalId_02",
    //        AuthormIddleName = "authormIddleName_02",
    //        Authors = {},
    //        AuthorshipRank = "authorshipRank_02",
    //        Concept = "concept_02",
    //        DOI = "doi_02",
    //        EndPage = "endPage_02",
    //        Grant = "grant_02",
    //        Issue = "issue_02",
    //        Journal = "journal_02",
    //        Label = "label_02",
    //        PublishDate = "publishDate_02",
    //        StartPage = "startPage_02",
    //        Volume  = "volumne_02",
    //    },
    //};

    [HttpGet("article"),
        AllowAnonymous]
    public IEnumerable<ArticleEntity> GetArticles(
        [FromQuery] string? @abstract,
        [FromQuery] string? authorFamilyName,
        [FromQuery] string? authorGivenName,
        [FromQuery] string? authorInternalId,
        [FromQuery] string? authormIddleName,
        [FromQuery] string? authorshipRank,
        [FromQuery] string? concept,
        [FromQuery] string? doi,
        [FromQuery] string? endPage,
        [FromQuery] string? grant,
        [FromQuery] string? issue,
        [FromQuery] string? journal,
        [FromQuery] string? label,
        [FromQuery] string? publishDate,
        [FromQuery] string? startPage,
        [FromQuery] string? volume
        ) => from t0 in GetAllArticles()
             where
                     @abstract.IsEqual(t0.Abstract)
                     || authorFamilyName.IsEqual(t0.AuthorFamilyName)
                     || authorGivenName.IsEqual(t0.AuthorGivenName)
                     || authorInternalId.IsEqual(t0.AuthorInternalId)
                     || authormIddleName.IsEqual(t0.AuthormIddleName)
                     || authorshipRank.IsEqual(t0.AuthorshipRank)
                     || concept.IsEqual(t0.Concept)
                     || doi.IsEqual(t0.DOI)
                     || endPage.IsEqual(t0.EndPage)
                     || grant.IsEqual(t0.Grant)
                     || issue.IsEqual(t0.Issue)
                     || journal.IsEqual(t0.Journal)
                     || label.IsEqual(t0.Label)
                     || publishDate.IsEqual(t0.PublishDate)
                     || startPage.IsEqual(t0.StartPage)
                     || volume.IsEqual(t0.Volume)

             select t0;

    [HttpGet("journal/all"),
        AllowAnonymous]
    public IEnumerable<JournalEntity> GetAllJournals() => new JournalEntity[]
        {
            new JournalEntity()
            {
                Abbreviation = "abbreviation_00",
                EISSN = "eissn_00",
                ISSN = "issn_00",
                Name = "name_00",
            },
            new JournalEntity()
            {
                Abbreviation = "abbreviation_01",
                EISSN = "eissn_01",
                ISSN = "issn_01",
                Name = "name_01",
            },
            new JournalEntity()
            {
                Abbreviation = "abbreviation_02",
                EISSN = "eissn_02",
                ISSN = "issn_02",
                Name = "name_02",
            },
        };

    [HttpGet("journal"),
        AllowAnonymous]
    public IEnumerable<JournalEntity> GetJournals(
        [FromQuery] string? abbreviation,
        [FromQuery] string? eissn,
        [FromQuery] string? issn,
        [FromQuery] string? name
        ) => from t0 in GetAllJournals()
             where
                     abbreviation.IsEqual(t0.Abbreviation)
                     || eissn.IsEqual(t0.EISSN)
                     || issn.IsEqual(t0.ISSN)
                     || name.IsEqual(t0.Name)

             select t0;

    [HttpGet("editor/all"),
        AllowAnonymous]
    public IEnumerable<EditorEntity> GetAllEditors() => new EditorEntity[]
        {
            new EditorEntity()
            {
                Abbreviation = "abbreviation_00",
                EISSN = "eissn_00",
                ISSN = "issn_00",
                Name = "name_00",
            },
            new EditorEntity()
            {
                Abbreviation = "abbreviation_01",
                EISSN = "eissn_01",
                ISSN = "issn_01",
                Name = "name_01",
            },
            new EditorEntity()
            {
                Abbreviation = "abbreviation_02",
                EISSN = "eissn_02",
                ISSN = "issn_02",
                Name = "name_02",
            },
        };

    [HttpGet("editor"),
        AllowAnonymous]
    public IEnumerable<EditorEntity> GetEditors(
        [FromQuery] string? abbreviation,
        [FromQuery] string? eissn,
        [FromQuery] string? issn,
        [FromQuery] string? name
        ) => from t0 in GetAllEditors()
             where
                     abbreviation.IsEqual(t0.Abbreviation)
                     || eissn.IsEqual(t0.EISSN)
                     || issn.IsEqual(t0.ISSN)
                     || name.IsEqual(t0.Name)

             select t0;

    #endregion
}
