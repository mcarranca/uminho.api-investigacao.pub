namespace uminho.api_investigacao.pub.Controllers {
    public abstract class BaseController<T> {
        #region Field members

        private ILogger<T> _logger;

        #endregion


        #region .ctor

        public BaseController(ILogger<T> logger) {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            Logger.LogInformation($"{typeof(T).FullName}");
        }

        #endregion


        #region Property members

        protected ILogger<T> Logger => _logger;

        #endregion
    }
}
