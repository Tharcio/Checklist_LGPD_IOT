using Aplicacao.Interfaces;
using Entidades.Entidade;
using Entidades.InterfaceRepositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacao.Servicos
{
    public class ServicoListaPerguntas:IServicoListaPerguntas
    {
        private readonly IRepositorioListaPerguntas _repositorioListaPerguntas;
        
        public ServicoListaPerguntas(IRepositorioListaPerguntas repositorioListaPerguntas)
        {
            _repositorioListaPerguntas = repositorioListaPerguntas;
        }
        
        public ClasseItensPerguntas PerguntasAcessoDispositivo()
        {
            try
            {
                return _repositorioListaPerguntas.GetPerguntasAcessoDispositivo();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ClasseItensPerguntas PerguntasConsentimentoTitular()
        {
            try
            {
                return _repositorioListaPerguntas.GetPerguntasConsentimentoTitular();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ClasseItensPerguntas PerguntasDireitosTitular()
        {
            try
            {
                return _repositorioListaPerguntas.GetPerguntasDireitosTitular();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ClasseItensPerguntas PerguntasResponsabilidadeControlador()
        {
            try
            {
                return _repositorioListaPerguntas.GetPerguntasResponsabilidadeControlador();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ClasseItensPerguntas PerguntasSegurancaDados()
        {
            try
            {
                return _repositorioListaPerguntas.GetPerguntasSegurancaDados();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ClasseItensPerguntas PerguntasSegurancaFisica()
        {
            try
            {
                return _repositorioListaPerguntas.GetPerguntasSegurancaFisica();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ClasseItensPerguntas PerguntasTransparenciaDados()
        {
            try
            {
                return _repositorioListaPerguntas.GetPerguntasTransparenciaDados();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
