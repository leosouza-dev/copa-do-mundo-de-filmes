using CopaDoMundo.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDoMundo.Api.Services.Interfaces
{
    public interface IApiService
    {
        Task<IEnumerable<Filme>> PegarFilmes();
    }
}
