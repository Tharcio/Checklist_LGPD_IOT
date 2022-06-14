using Entidades.Entidade;
using Entidades.InterfaceRepositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorios.Repositorio
{
    public class RepositorioListaPerguntas : IRepositorioListaPerguntas
    {
        public ClasseItensPerguntas GetPerguntasAcessoDispositivo()
        {
            var ItensPerguntas = new ClasseItensPerguntas();
            try
            {
                var lines = getTxt("PerguntasAcessoDispositivo");
                ItensPerguntas.NomeClasse = "PerguntasAcessoDispositivo";
                ItensPerguntas.ListaPergunta = new List<Pergunta>();
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i].Split("|");
                    var pergunta = new Pergunta();
                    pergunta.Id = line[0];
                    pergunta.ItemAvaliacao = line[1];
                    pergunta.Recomendacoes = line[2];
                    ItensPerguntas.ListaPergunta.Add(pergunta);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ItensPerguntas;
        }

        public ClasseItensPerguntas GetPerguntasConsentimentoTitular()
        {
            var ItensPerguntas = new ClasseItensPerguntas();
            try
            {
                var lines = getTxt("PerguntasConsentimentoTitular");
                ItensPerguntas.NomeClasse = "PerguntasConsentimentoTitular";
                ItensPerguntas.ListaPergunta = new List<Pergunta>();
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i].Split("|");
                    var pergunta = new Pergunta();
                    pergunta.Id = line[0];
                    pergunta.ItemAvaliacao = line[1];
                    pergunta.Recomendacoes = line[2];
                    ItensPerguntas.ListaPergunta.Add(pergunta);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ItensPerguntas;
        }

        public ClasseItensPerguntas GetPerguntasDireitosTitular()
        {
            var ItensPerguntas = new ClasseItensPerguntas();
            try
            {
                var lines = getTxt("PerguntasDireitoTitular");
                ItensPerguntas.NomeClasse = "PerguntasDireitoTitular";
                ItensPerguntas.ListaPergunta = new List<Pergunta>();
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i].Split("|");
                    var pergunta = new Pergunta();
                    pergunta.Id = line[0];
                    pergunta.ItemAvaliacao = line[1];
                    pergunta.Recomendacoes = line[2];
                    ItensPerguntas.ListaPergunta.Add(pergunta);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ItensPerguntas;
        }

        public ClasseItensPerguntas GetPerguntasResponsabilidadeControlador()
        {
            var ItensPerguntas = new ClasseItensPerguntas();
            try
            {
                var lines = getTxt("PerguntasResponsabilidadeControlador");
                ItensPerguntas.NomeClasse = "PerguntasResponsabilidadeControlador";
                ItensPerguntas.ListaPergunta = new List<Pergunta>();
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i].Split("|");
                    var pergunta = new Pergunta();
                    pergunta.Id = line[0];
                    pergunta.ItemAvaliacao = line[1];
                    pergunta.Recomendacoes = line[2];
                    ItensPerguntas.ListaPergunta.Add(pergunta);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ItensPerguntas;
        }

        public ClasseItensPerguntas GetPerguntasSegurancaDados()
        {
            var ItensPerguntas = new ClasseItensPerguntas();
            try
            {
                var lines = getTxt("PerguntasSegurancaDados");
                ItensPerguntas.NomeClasse = "PerguntasSegurancaDados";
                ItensPerguntas.ListaPergunta = new List<Pergunta>();
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i].Split("|");
                    var pergunta = new Pergunta();
                    pergunta.Id = line[0];
                    pergunta.ItemAvaliacao = line[1];
                    pergunta.Recomendacoes = line[2];
                    ItensPerguntas.ListaPergunta.Add(pergunta);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ItensPerguntas;
        }

        public ClasseItensPerguntas GetPerguntasSegurancaFisica()
        {
            var ItensPerguntas = new ClasseItensPerguntas();
            try
            {
                var lines = getTxt("PerguntasSegurancaFisica");
                ItensPerguntas.NomeClasse = "PerguntasSegurancaFisica";
                ItensPerguntas.ListaPergunta = new List<Pergunta>();
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i].Split("|");
                    var pergunta = new Pergunta();
                    pergunta.Id = line[0];
                    pergunta.ItemAvaliacao = line[1];
                    pergunta.Recomendacoes = line[2];
                    ItensPerguntas.ListaPergunta.Add(pergunta);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ItensPerguntas;
        }

        public ClasseItensPerguntas GetPerguntasTransparenciaDados()
        {
            var ItensPerguntas = new ClasseItensPerguntas();
            try
            {
                var lines = getTxt("PerguntasTransparenciaDados");
                ItensPerguntas.NomeClasse = "PerguntasTransparenciaDados";
                ItensPerguntas.ListaPergunta = new List<Pergunta>();
                for (var i = 0; i < lines.Length; i++)
                {
                    var line = lines[i].Split("|");
                    var pergunta = new Pergunta();
                    pergunta.Id = line[0];
                    pergunta.ItemAvaliacao = line[1];
                    pergunta.Recomendacoes = line[2];
                    ItensPerguntas.ListaPergunta.Add(pergunta);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ItensPerguntas;
        }

        private string[] getTxt(string perguntas)
        {
            string[] lines = System.IO.File.ReadAllLines("./Repositorios/Repositorio/" + perguntas + ".txt");
            return lines;
        }
    }
}
