using System;

namespace CopaDoMundo.Api.Domain.Models
{
    // checar guidelines da microsoft
    public class ErrorResponse
    {
        public int Codigo { get; set; }
        public string Mensagem { get; set; }
        public ErrorResponse InnerErro { get; set; }

        public static ErrorResponse From(Exception e)
        {
            // recursão
            if (e == null) return null;

            return new ErrorResponse
            {
                Codigo = e.HResult,
                Mensagem = e.Message,
                InnerErro = ErrorResponse.From(e.InnerException)
            };
        }
    }
}
