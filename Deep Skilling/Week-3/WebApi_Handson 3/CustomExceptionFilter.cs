using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace WebApi_Handson_3.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            File.AppendAllText("ErrorLog.txt",
                DateTime.Now + " : " + context.Exception.Message + Environment.NewLine);
            context.Result = new ObjectResult("Internal Server Error")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
    }
}
