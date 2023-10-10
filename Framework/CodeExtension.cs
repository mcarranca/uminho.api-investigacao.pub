using System.Drawing;

namespace uminho.api_investigacao.pub.Framework {
    public static class CodeExtension {

        /// <summary>
        /// Compare two values
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool IsEqual<T>(this T? x, T? y) {
            if (x == null) {
                return false;
            }

            return Comparer<T>.Default.Compare(x, y) == 0;
        }


        /// <summary>
        /// Convert <paramref name="dateTime"/> to <see cref="System.String"/>
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string? FromDateTime(DateTime? dateTime) =>
            dateTime?.ToString("yyyy-MM-dd");

        /// <summary>
        /// Convert <paramref name="dateTime"/> to <see cref="System.DateTime"/>
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime? ToDateTime(string dateTime) =>
            DateTime.TryParse(dateTime, out DateTime outDateTime)
                ? outDateTime
                : null;

        /// <summary>
        /// Convert <paramref name="bitmap"/> to <see cref="System.String"/>
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static string? FromImage(Bitmap bitmap) {
            //var ms = new MemoryStream();
            //bitmap.Save(ms, ImageFormat.Jpeg);
            //var byteImage = ms.ToArray();
            //var base64 = Convert.ToBase64String(byteImage);

            //return base64;
            return null;
        }
        /// <summary>
        /// Convert <paramref name="bitmapBase64"/> to <see cref="System.Drawing.Bitmap"/>
        /// </summary>
        /// <param name="bitmapBase64"></param>
        /// <returns></returns>
        public static Bitmap? ToImage(string? bitmapBase64) {
            return null;
        }
    }
}
