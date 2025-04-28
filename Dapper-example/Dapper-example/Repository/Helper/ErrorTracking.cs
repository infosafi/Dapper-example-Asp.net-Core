namespace Dapper_example.Repository.Helper
{
    public class ErrorTracking
    {
        public static string? ErrorMsg { get; set; }
        public static string? ErrorSrc { get; set; }
        public static string? ErrorLocation { get; set; }

        public static void ClearErrors()
        {
            ErrorSrc = string.Empty;
            ErrorMsg = string.Empty;
            ErrorLocation = string.Empty;
        }
        public static void SetError(Exception ex)
        {
            ErrorSrc = ex.Source;
            ErrorMsg = ex.Message;
            ErrorLocation = ex.StackTrace;

        }
    }
}
