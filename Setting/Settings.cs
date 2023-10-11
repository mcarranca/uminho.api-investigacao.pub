namespace uminho.api_investigacao.pub.Setting {
    public static class Settings {

        #region Static property members

        public static string? ConnectionString { get; private set; }

        /// <summary>
        /// Gets swagger settings
        /// </summary>
        public static SwaggerSetting? SwaggerSetting { get; internal set; }

        #endregion

        #region Static method members

        internal static void LoadSettings(this ConfigurationManager configurationManager) {
            _ = configurationManager ?? throw new ArgumentNullException(nameof(configurationManager));

            // global
            ConnectionString = configurationManager.GetConnectionString("SQLConnectionString");

            // sections
            SwaggerSetting = configurationManager.GetSection("Swagger").Get<SwaggerSetting>();
        }

        #endregion
    }
}
