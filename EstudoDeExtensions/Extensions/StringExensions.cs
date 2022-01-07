namespace System
{
    internal static class StringExensions
    {
        public static string Cut(this string thisObj, int tam)
        {
            if (thisObj.Length <= tam)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, tam) + "...";
            }
        }
    }
}
