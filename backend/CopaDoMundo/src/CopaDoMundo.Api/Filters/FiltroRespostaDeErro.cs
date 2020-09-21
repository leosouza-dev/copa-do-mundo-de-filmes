using CopaDoMundo.Api.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CopaDoMundo.Api.Filters
{
    public class FiltroRespostaDeErro : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var errorResponse = ErrorResponse.From(context.Exception);
            context.Result = new ObjectResult(errorResponse) { StatusCode = 400 };
        }
    }
}
