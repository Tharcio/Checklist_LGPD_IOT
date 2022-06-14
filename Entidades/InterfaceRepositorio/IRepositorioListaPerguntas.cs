using Entidades.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.InterfaceRepositorio
{
    public interface IRepositorioListaPerguntas
    {
        ClasseItensPerguntas GetPerguntasAcessoDispositivo();
        ClasseItensPerguntas GetPerguntasConsentimentoTitular();
        ClasseItensPerguntas GetPerguntasDireitosTitular();
        ClasseItensPerguntas GetPerguntasResponsabilidadeControlador();
        ClasseItensPerguntas GetPerguntasSegurancaDados();
        ClasseItensPerguntas GetPerguntasSegurancaFisica();
        ClasseItensPerguntas GetPerguntasTransparenciaDados();
    }
}
