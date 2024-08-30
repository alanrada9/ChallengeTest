using Application.Common.Exceptions;
using Microsoft.AspNetCore.Http;
using System.Net;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (NotEnoughFundsException ex)
        {
            await HandleExceptionAsync(httpContext, ex, HttpStatusCode.BadRequest);
        }
        catch (UnauthorizedAccessException ex)
        {
            await HandleExceptionAsync(httpContext, ex, HttpStatusCode.Unauthorized);
        }

        catch(CardBlockedException ex)
        {
            await HandleExceptionAsync(httpContext, ex, HttpStatusCode.BadRequest);
        }

        catch (Exception ex)
        {
            await HandleExceptionAsync(httpContext, ex, HttpStatusCode.InternalServerError);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception, HttpStatusCode statusCode)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)statusCode;

        var response = new
        {
            error = exception.Message,
            statusCode = (int)statusCode
        };

        return context.Response.WriteAsJsonAsync(response);
    }
}