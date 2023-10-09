namespace uminho.api_investigacao.pub
{
    public static class CodeExtension
    {

        public static bool IsEqual<T>(this T? x, T? y)
        {
            if (x == null)
            {
                return false;
            }

            return Comparer<T>.Default.Compare(x, y) == 0;
        }

    }
}
