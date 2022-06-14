using System;
using Entidades.Entidade;
using System.Collections.Generic;
using System.Text;

namespace Aplicacao.Interfaces
{
    public interface IServicoListaPerguntas
    {
        ClasseItensPerguntas PerguntasAcessoDispositivo();
        ClasseItensPerguntas PerguntasConsentimentoTitular();
        ClasseItensPerguntas PerguntasDireitosTitular();
        ClasseItensPerguntas PerguntasResponsabilidadeControlador();
        ClasseItensPerguntas PerguntasSegurancaDados();
        ClasseItensPerguntas PerguntasSegurancaFisica();
        ClasseItensPerguntas PerguntasTransparenciaDados();

    }
}
