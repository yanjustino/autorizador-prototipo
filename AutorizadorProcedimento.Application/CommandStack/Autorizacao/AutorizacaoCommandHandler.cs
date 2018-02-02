using AutorizadorProcedimento.Application.CommandStack.Autorizacao.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutorizadorProcedimento.Application.CommandStack.Autorizacao
{
    public class AutorizacaoCommandHandler : ICommandHandler<SolicitacaoDeProcedimentoCommand>
    {
        public void Execute(SolicitacaoDeProcedimentoCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
