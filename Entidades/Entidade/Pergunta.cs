using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Entidade
{
    public class Pergunta
    {
        public string Id { get; set; }
        public string ItemAvaliacao { get; set; }
        public Resposta Resposta { get; set; }
        public GrauSeveridade GrauSeveridade { get; set; }
        public string ComentarioAvaliador { get; set; }
        public string Recomendacoes { get; set; }
    }
}
