using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalApi.Dominio.ModelViews
{
    public struct Home
    {
        public string Mensagem { get => "Bem vidno A documentação de veiculos - Minimal API";}
        public string Documentacao { get => "/Swagger"; }
    }
}