using System.Text.Json.Serialization;

namespace uminho.api_investigacao.pub.Entities {
    [Serializable,
        JsonSerializable(typeof(ArticleEntity), TypeInfoPropertyName = "article")]
    public class ArticleEntity {

        #region Property members

        [JsonPropertyName("label")]
        public string? Label { get; set; }

        [JsonPropertyName("abstract")]
        public string? Abstract { get; set; }

        [JsonPropertyName("doi")]
        public string? DOI { get; set; }

        [JsonPropertyName("volume")]
        public string? Volume { get; set; }

        [JsonPropertyName("issue")]
        public string? Issue { get; set; }

        [JsonPropertyName("startPage")]
        public string? StartPage { get; set; }

        [JsonPropertyName("endPage")]
        public string? EndPage { get; set; }

        [JsonPropertyName("grant")]
        public string? Grant { get; set; }

        [JsonPropertyName("concept")]
        public string? Concept { get; set; }

        [JsonPropertyName("publishDate")]
        public string? PublishDate { get; set; }

        [JsonPropertyName("journal")]
        public string? Journal { get; set; }

        [JsonPropertyName("authorshipRank")]
        public string? AuthorshipRank { get; set; }

        [JsonPropertyName("authorInternalId")]
        public string? AuthorInternalId { get; set; }

        [JsonPropertyName("authors")]
        public IEnumerable<AuthorEntity>? Authors { get; set; }

        [JsonPropertyName("authorGivenName")]
        public string? AuthorGivenName { get; set; }

        [JsonPropertyName("authormIddleName")]
        public string? AuthormIddleName { get; set; }

        [JsonPropertyName("authorFamilyName")]
        public string? AuthorFamilyName { get; set; }

        #endregion
    }
}
