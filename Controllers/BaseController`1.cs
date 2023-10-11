namespace uminho.api_investigacao.pub.Controllers {

    /// <summary>
    /// Base controller
    /// </summary>
    /// <typeparam name="TController"></typeparam>
    public abstract class BaseController<TController> {

        #region .ctor

        public BaseController(ILogger<TController> logger) {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));

#pragma warning disable CA2254 // Template should be a static expression
            Logger.LogInformation($"{typeof(TController).FullName}");
#pragma warning restore CA2254 // Template should be a static expression
        }

        #endregion

        #region Property members

        protected ILogger<TController> Logger { get; private set; }

        #endregion
    }
}
