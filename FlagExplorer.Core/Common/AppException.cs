using System.Net;

namespace FlagExplorer.Core.Common
{
    public class AppException : Exception
    {
        public HttpStatusCode StatusCode { get; private set; }
        public AppException(HttpStatusCode statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }
        public static AppException DuplicateException(string message = "Duplicate entry detected.") =>
            new AppException(HttpStatusCode.Conflict, message);

        public static AppException NotFound(string message = "Not Found") =>
            new AppException(HttpStatusCode.NotFound, message);

    }
}
