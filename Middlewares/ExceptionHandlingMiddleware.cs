using blog_api.Exceptions;

namespace blog_api.Middlewares;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }catch(CustomHttpException cex)
        {
            Console.WriteLine(" --- custom exception http survenue:: ");
            Console.WriteLine(cex);

            context.Response.StatusCode = cex.StatusCode;

            await context.Response.WriteAsJsonAsync(cex);
        }catch(Exception ex)
        {
            Console.WriteLine(" --- general exception survenue:: ");
            Console.WriteLine(ex);
            var cex = new CustomHttpException();
            context.Response.StatusCode = cex.StatusCode;
            await context.Response.WriteAsJsonAsync(cex);
        }
    }
}