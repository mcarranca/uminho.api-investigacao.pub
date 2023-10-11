namespace uminho.api_investigacao.pub.DTO.PublicacoesDTO {
    public class PublicacoesDTO {

        #region Property members

        public int? Id { get; set; }
        public string? DC_identifier { get; set; }
        public string? DC_creator { get; set; }
        public string? DC_title { get; set; }
        public string? PRISM_aggregationType { get; set; }
        public string? SubType { get; set; }
        public string? PRISM_publicationName { get; set; }
        public string? PRISM_isbn { get; set; }
        public string? PRISM_issn { get; set; }
        public string? PRISM_volume { get; set; }
        public string? PRISM_issueIdentifier { get; set; }
        public string? PRISM_pageRange { get; set; }
        public string? PRISM_coverDate { get; set; }
        public string? PRISM_coverDisplayDate { get; set; }
        public string? PRISM_doi { get; set; }
        public string? PUBMED_id { get; set; }
        public string? DC_description { get; set; }
        public string? Authkeywords { get; set; }
        public string? FUND_acr { get; set; }
        public string? FUND_no { get; set; }
        public string? FUND_sponsor { get; set; }
        public string? DC_Publisher { get; set; }
        public bool? IsImportedRepositoriUM { get; set; }
        public bool? SourceChanged { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? LastChangedOn { get; set; }
        public string? LastChangedBy { get; set; }

        #endregion

    }
}
