using System;
using System.Collections.Generic;
using System.Text;

namespace MAL.Bussiness.Notificacoes
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
