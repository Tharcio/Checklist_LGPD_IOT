using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Checklist_LGPD_IoT.Models;
using Apresentacao.Models;
using Entidades.Entidade;
using Aplicacao.Interfaces;

namespace Checklist_LGPD_IoT.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServicoListaPerguntas _servicoPerguntas;

        public HomeController(IServicoListaPerguntas servicoPerguntas)
        {
            _servicoPerguntas = servicoPerguntas;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult AcessoDispositivo()
        {
            try
            {
                var model = new AcessoDispositivoModel();
                var perguntas = _servicoPerguntas.PerguntasAcessoDispositivo();
                model.A01 = perguntas.ListaPergunta[0];
                model.A02 = perguntas.ListaPergunta[1];
                model.A03 = perguntas.ListaPergunta[2];
                model.A04 = perguntas.ListaPergunta[3];
                model.A05 = perguntas.ListaPergunta[4];
                return View(model);
            }
            catch(Exception e)
            {
                return (ActionResult)Error();
            }
        }

        public ActionResult ConsentimentoTitular()
        {
            try
            {
                var model = new ConsentimentoTitularModel();
                var perguntas = _servicoPerguntas.PerguntasConsentimentoTitular();
                model.C01 = perguntas.ListaPergunta[0];
                model.C02 = perguntas.ListaPergunta[1];
                model.C03 = perguntas.ListaPergunta[2];
                model.C04 = perguntas.ListaPergunta[3];
                model.C05 = perguntas.ListaPergunta[4];
                model.C06 = perguntas.ListaPergunta[5];
                model.C07 = perguntas.ListaPergunta[6];
                model.C08 = perguntas.ListaPergunta[7];
                return View(model);
            }
            catch (Exception e)
            {
                var model = new ErrorViewModel();
                model.RequestId = e.StackTrace;
                return View("", model);
            }
        }

        public ActionResult DireitosTitular()
        {
            try
            {
                var model = new DireitosTitularModel();
                var perguntas = _servicoPerguntas.PerguntasDireitosTitular();
                model.D01 = perguntas.ListaPergunta[0];
                model.D02 = perguntas.ListaPergunta[1];
                model.D03 = perguntas.ListaPergunta[2];
                model.D04 = perguntas.ListaPergunta[3];
                model.D05 = perguntas.ListaPergunta[4];
                model.D06 = perguntas.ListaPergunta[5];
                model.D07 = perguntas.ListaPergunta[6];
                model.D08 = perguntas.ListaPergunta[7];
                model.D09 = perguntas.ListaPergunta[8];
                model.D10 = perguntas.ListaPergunta[9];
                model.D11 = perguntas.ListaPergunta[10];
                model.D12 = perguntas.ListaPergunta[11];
                model.D13 = perguntas.ListaPergunta[12];
                model.D14 = perguntas.ListaPergunta[13];
                model.D15 = perguntas.ListaPergunta[14];
                return View(model);
            }
            catch (Exception e)
            {
                var model = new ErrorViewModel();
                model.RequestId = e.StackTrace;
                return View("", model);
            }
        }

        public ActionResult ReponsabilidadeControlador()
        {
            try
            {
                var model = new ResponsabilidadeControladorModel();
                var perguntas = _servicoPerguntas.PerguntasResponsabilidadeControlador();
                model.R01 = perguntas.ListaPergunta[0];
                model.R02 = perguntas.ListaPergunta[1];
                model.R03 = perguntas.ListaPergunta[2];
                model.R04 = perguntas.ListaPergunta[3];
                model.R05 = perguntas.ListaPergunta[4];
                model.R01NO = perguntas.ListaPergunta[5];
                model.R02NO = perguntas.ListaPergunta[6];
                model.R03NO = perguntas.ListaPergunta[7];
                return View(model);
            }
            catch (Exception e)
            {
                var model = new ErrorViewModel();
                model.RequestId = e.StackTrace;
                return View("", model);
            }
        }

        public ActionResult SegurancaDados()
        {
            try
            {
                var model = new SegurancaDadosModel();
                var perguntas = _servicoPerguntas.PerguntasSegurancaDados();
                model.S01 = perguntas.ListaPergunta[0];
                model.S02 = perguntas.ListaPergunta[1];
                model.S03 = perguntas.ListaPergunta[2];
                model.S04 = perguntas.ListaPergunta[3];
                model.S05 = perguntas.ListaPergunta[4];
                model.S01NO = perguntas.ListaPergunta[5];
                model.S02NO = perguntas.ListaPergunta[6];
                model.S03NO = perguntas.ListaPergunta[7];
                model.S04NO = perguntas.ListaPergunta[8];
                model.S05NO = perguntas.ListaPergunta[9];
                model.S06NO = perguntas.ListaPergunta[10];
                model.S07NO = perguntas.ListaPergunta[11];
                model.S08NO = perguntas.ListaPergunta[12];
                model.S09NO = perguntas.ListaPergunta[13];
                model.S10NO = perguntas.ListaPergunta[14];
                model.S11NO = perguntas.ListaPergunta[15];
                model.S12NO = perguntas.ListaPergunta[16];
                model.S13NO = perguntas.ListaPergunta[17];
                model.S14NO = perguntas.ListaPergunta[18];
                model.S15NO = perguntas.ListaPergunta[19];
                model.S16NO = perguntas.ListaPergunta[20];
                model.S17NO = perguntas.ListaPergunta[21];
                model.S18NO = perguntas.ListaPergunta[22];
                model.S19NO = perguntas.ListaPergunta[23];
                model.S20NO = perguntas.ListaPergunta[24];
                model.S21NO = perguntas.ListaPergunta[25];
                return View(model);
            }
            catch (Exception e)
            {
                var model = new ErrorViewModel();
                model.RequestId = e.StackTrace;
                return View("", model);
            }
        }

        public ActionResult SegurancaFisica()
        {
            try
            {
                var model = new SegurancaFisicaModel();
                var perguntas = _servicoPerguntas.PerguntasSegurancaFisica();
                model.SF01 = perguntas.ListaPergunta[0];
                model.SF02 = perguntas.ListaPergunta[1];
                model.SF03 = perguntas.ListaPergunta[2];
                model.SF04 = perguntas.ListaPergunta[3];
                model.SF05 = perguntas.ListaPergunta[4];
                model.SF06 = perguntas.ListaPergunta[5];
                model.SF07 = perguntas.ListaPergunta[6];
                return View(model);
            }
            catch (Exception e)
            {
                var model = new ErrorViewModel();
                model.RequestId = e.StackTrace;
                return View("", model);
            }
        }

        public ActionResult TransparenciaDados()
        {
            try
            {
                var model = new TransparenciaDadosModel();
                var perguntas = _servicoPerguntas.PerguntasTransparenciaDados();
                model.T01 = perguntas.ListaPergunta[0];
                model.T02 = perguntas.ListaPergunta[1];
                model.T03 = perguntas.ListaPergunta[2];
                model.T04 = perguntas.ListaPergunta[3];
                model.T05 = perguntas.ListaPergunta[4];
                model.T06 = perguntas.ListaPergunta[5];
                model.T07 = perguntas.ListaPergunta[6];
                model.T08 = perguntas.ListaPergunta[7];
                model.T09 = perguntas.ListaPergunta[8];
                model.T10 = perguntas.ListaPergunta[9];
                model.T11 = perguntas.ListaPergunta[10];
                model.T12 = perguntas.ListaPergunta[11];
                model.T13 = perguntas.ListaPergunta[12];
                model.T14 = perguntas.ListaPergunta[13];
                return View(model);
            }
            catch (Exception e)
            {
                var model = new ErrorViewModel();
                model.RequestId = e.StackTrace;
                return View("", model);
            }
        }

        public ActionResult Checklist()
        {
            var model = new ChecklistModel();
            return View(model);
        }
    }
}
