using Microsoft.EntityFrameworkCore;

namespace uminho.api_investigacao.pub.Controllers {

    public abstract class BaseController<TController, TDbContext>
        : BaseController<TController>
        where TDbContext : DbContext {

        #region .ctor

        public BaseController(ILogger<TController> logger, TDbContext dbContext)
            : base(logger) {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        #endregion

        #region Property members

        public TDbContext DbContext { get; private set; }

        #endregion
    }
}
