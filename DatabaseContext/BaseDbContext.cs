using Microsoft.EntityFrameworkCore;

namespace uminho.api_investigacao.pub.DatabaseContext {
    public class BaseDbContext<TDbContext>
        : DbContext
        where TDbContext : BaseDbContext<TDbContext> {

        #region .ctor

        public BaseDbContext(ILogger<TDbContext> logger, DbContextOptions<TDbContext> dbContextOptions)
            : base(dbContextOptions) {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _ = dbContextOptions ?? throw new ArgumentNullException(nameof(dbContextOptions));
        }

        #endregion

        #region Property members

        public ILogger<DbContext> Logger { get; private set; }

        #endregion
    }
}
