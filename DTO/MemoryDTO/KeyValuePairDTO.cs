namespace uminho.api_investigacao.pub.DTO.MemoryDTO {

    /// <summary>
    /// Key value pair Data Transfer Object (DTO)
    /// </summary>
    [Serializable]
    public class KeyValuePairDTO
        : BaseDTO {

        #region Property members

        /// <summary>
        /// Gets and sets key
        /// </summary>
        public string? Key { get; set; }
        /// <summary>
        /// Gets and sets value
        /// </summary>
        public object? Value { get; set; }

        #endregion

    }
}
