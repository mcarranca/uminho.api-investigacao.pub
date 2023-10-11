using Microsoft.EntityFrameworkCore;
using uminho.api_investigacao.pub.DTO.PublicacoesDTO;

namespace uminho.api_investigacao.pub.DatabaseContext {
    public class PublicacoesDBContext
        : BaseDbContext<PublicacoesDBContext> {

        #region .ctor

        public PublicacoesDBContext(ILogger<PublicacoesDBContext> logger, DbContextOptions<PublicacoesDBContext> dbContextOptions)
            : base(logger, dbContextOptions) {
        }

        #endregion

        #region Property members

        /// <summary>
        /// Gets and sets <see cref="PublicacoesDTO"/>.
        /// </summary>
        public DbSet<PublicacoesDTO> Publicacoes { get; set; }

        #endregion
    }
}
