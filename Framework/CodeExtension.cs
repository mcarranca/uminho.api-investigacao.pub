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
        /// Convert <paramref name="array"/> to Base64>
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static string? ToBase64(this byte[] array) {
            //var ms = new MemoryStream();
            //bitmap.Save(ms, ImageFormat.Jpeg);
            //var byteImage = ms.ToArray();
            string base64 = Convert.ToBase64String(array);

            return base64;
        }
        /// <summary>
        /// Convert Base64 to <see cref="System.Byte[]"/>
        /// </summary>
        /// <param name="base64"></param>
        /// <returns></returns>
        public static byte[] FromBase64(this string? base64) {
            byte[] array = (base64 == null)
                ? Array.Empty<byte>()
                : Convert.FromBase64String(base64);

            return array;
        }

        /// <summary>
        /// Convert Base64 to image (<see cref="System.Byte[]"/>)
        /// </summary>
        /// <param name="base64"></param>
        /// <returns></returns>
        public static byte[] ToImage(this string base64) {
            return base64.FromBase64();
        }
        /// <summary>
        /// Convert image (<see cref="System.Byte[]"/>) to Base64
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static string? FromImage(this byte[] image) {
            return image.ToBase64();
        }
    }
}
