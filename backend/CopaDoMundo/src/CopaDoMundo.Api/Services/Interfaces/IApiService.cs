using CopaDoMundo.Api.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaDoMundo.Api.Services.Interfaces
{
    public interface IApiService
    {
        Task<IEnumerable<Filme>> PegarFilmes();
    }
}
