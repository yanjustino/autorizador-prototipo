using System;
using System.Collections.Generic;
using System.Text;

namespace AutorizadorProcedimento.Application.CommandStack
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        void Execute(T command);
    }
}
