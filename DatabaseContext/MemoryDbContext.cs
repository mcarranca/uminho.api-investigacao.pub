using Microsoft.EntityFrameworkCore;
using uminho.api_investigacao.pub.DTO.MemoryDTO;

namespace uminho.api_investigacao.pub.DatabaseContext {
    public class MemoryDbContext
        : BaseDbContext<MemoryDbContext> {

        #region .ctor

        public MemoryDbContext(ILogger<MemoryDbContext> logger, DbContextOptions<MemoryDbContext> dbContextOptions)
            : base(logger, dbContextOptions) {
        }

        #endregion

        #region Property members

        /// <summary>
        /// Gets and sets <see cref="KeyValuePairDTO"/>.
        /// </summary>
        public DbSet<KeyValuePairDTO> KeyValuePairs { get; set; }

        #endregion
    }
}
