﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MAL.Bussiness.Notificacoes
{
    public class Notificacao
    {
        public string Mensagem { get; }

        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }

    }
}
