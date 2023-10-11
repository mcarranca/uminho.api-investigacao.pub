using Microsoft.EntityFrameworkCore;
using uminho.api_investigacao.pub.Setting;

namespace uminho.api_investigacao.pub.DatabaseContext {
    public static class DbContexts {

        #region Static method members

        public static void LoadDbContexts(this IServiceCollection serviceCollection) {
            serviceCollection.AddDbContext<MemoryDbContext>(options => {
                options.UseInMemoryDatabase("MemoryDatabase");
                //options.LogTo()
            });

            serviceCollection.AddDbContext<PublicacoesDBContext>(options => {
                options.UseSqlServer(Settings.ConnectionString ?? string.Empty);
                //options.LogTo()
            });
        }

        #endregion

    }
}
