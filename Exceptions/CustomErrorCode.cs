namespace blog_api.Exceptions;
public class CustomHttpException : Exception
{
    public int StatusCode = 500;
    public string? Detail {get; set;}
    public CustomErrorCode CustomErrorCode {get; set;} = CustomErrorCode.NOT_DOCUMENTED; // ceci est un model pour centraliser les messages et les raisons d'erreurs

    public CustomHttpException(string? detail=null, int statusCode=500): base(detail)
    {
        Detail = detail;
        StatusCode = statusCode;
    }
}