using Aplicacao;
using Entidades.Entidade;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apresentacao.Models
{
    public class AcessoDispositivoModel:Model
    {
        public Pergunta A01 { get; set; }
        public Pergunta A02 { get; set; }
        public Pergunta A03 { get; set; }
        public Pergunta A04 { get; set; }
        public Pergunta A05 { get; set; }
    }
}
