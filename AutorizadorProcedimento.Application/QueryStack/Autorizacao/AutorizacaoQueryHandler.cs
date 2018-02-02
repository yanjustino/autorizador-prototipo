using AutorizadorProcedimento.Application.QueryStack.Autorizacao.DataResult;
using AutorizadorProcedimento.Application.QueryStack.Autorizacao.QueryIpunt;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutorizadorProcedimento.Application.QueryStack.Autorizacao
{
    class AutorizacaoQueryHandler :
        IQueryHandler<UltimasAltorizacoesQueryInput, UltimasAltorizacoesDto>
    {
        public UltimasAltorizacoesDto Query(UltimasAltorizacoesQueryInput queryInput)
        {
            throw new NotImplementedException();
        }
    }
}
