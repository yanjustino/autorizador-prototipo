using System;
using System.Collections.Generic;
using System.Text;

namespace AutorizadorProcedimento.Application.QueryStack
{
    public interface IQueryHandler<in T, K> 
        where T : IQueryInput
        where K : class
    {
        K Query(T queryInput);
    }
}
