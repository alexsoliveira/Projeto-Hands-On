using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;
using TesteHandsonCurriculum.Application.ViewModels;
using TesteHandsonCurriculum.UI.Web.Models;

namespace TesteHandsonCurriculum.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        HttpClient _client = new HttpClient();
        var aleatorio = new AleatorioViewModel();

        public HomeController()
        {
            _client.BaseAddress = new Uri("http://localhost:56349/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public ActionResult Index()
        {
            var numeroAleatorioSuspeito = new Random();
            var response = _client.GetAsync("api/suspeito").Result;

            if (response.IsSuccessStatusCode)
            {
                var suspeitoList = new List<SuspeitoViewModel>();
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<SuspeitoViewModel>>().Result;
                if(aleatorio.numeroSuspeito == 0)
                    aleatorio.numeroSuspeito = numeroAleatorioSuspeito.Next((ViewBag.result).Count) + 1;
                suspeitoList.Add(new SuspeitoViewModel() { SuspeitoCod = 0, SuspeitoNome = "Escolhe o suspeito do crime..." });
                foreach (var suspeito in ViewBag.result)
                {
                    suspeitoList.Add(new SuspeitoViewModel() { SuspeitoCod = suspeito.SuspeitoCod, SuspeitoNome = suspeito.SuspeitoNome });
                }
                ViewBag.Suspeito = suspeitoList;
                TempData["Aleatorio"] = aleatorio;
                return View();
            }
            else
            {
                ViewBag.result = "Error";
            }

            return View();
        }

        public JsonResult RetornarValidacao(string idSuspeito, string idLocal, string idArma)
        {
            var valor = 0;
            var message = new MessageViewModel();
            aleatorio = TempData["Aleatorio"] as AleatorioViewModel;
            TempData.Keep("Aleatorio");

            if (idSuspeito != aleatorio.numeroSuspeito.ToString())
            {
                valor = 1;
                message.TituloMessage = "Você erro!!!";
                message.CorpoMessage = "Retorno: " + valor + " (somente o assassino está incorreto.)";
                return Json(message);
            }
            if (idLocal != aleatorio.numeroLocal.ToString())
            {
                valor = 2;
                message.TituloMessage = "Você erro!!!";
                message.CorpoMessage = "Retorno: " + valor + " (somente o local do crime está incorreto.)";
                return Json(message);
            }
            if (idArma != aleatorio.numeroArma.ToString())
            {
                valor = 3;
                message.TituloMessage = "Você erro!!!";
                message.CorpoMessage = "Retorno: " + valor + " (somente o arma do crime está incorreto.)";
                return Json(message);
            }

            message.TituloMessage = "Parabéns!!!";
            message.CorpoMessage = "Retorno: " + valor + " (todos corretos, parabéns! Você solucionou o caso)";
            aleatorio = null;
            TempData["Aleatorio"] = null;
            return Json(message);
        }

        public JsonResult ObterLocais(string id)
        {
            var numeroAleatorioLocal = new Random();
            var localList = new List<LocalViewModel>();
            aleatorio = TempData["Aleatorio"] as AleatorioViewModel;
            var response = _client.GetAsync("api/local").Result;

            if (response.IsSuccessStatusCode)
            {
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<LocalViewModel>>().Result;
                if(aleatorio.numeroLocal == 0)
                    aleatorio.numeroLocal = numeroAleatorioLocal.Next((ViewBag.result).Count) + 1;
                localList.Add(new LocalViewModel() { LocalCod = 0, LocalNome = "Escolhe o local do crime..." });
                foreach (var local in ViewBag.result)
                {
                    localList.Add(new LocalViewModel() { LocalCod = local.LocalCod, LocalNome = local.LocalNome });
                }
            }
            else
            {
                ViewBag.result = "Error";
            }
            TempData["Aleatorio"] = aleatorio;
            return Json(new SelectList(localList, "LocalCod", "LocalNome"));
        }

        public JsonResult ObterArmas(string id)
        {
            var numeroAleatorioArma = new Random();
            var armaList = new List<ArmaViewModel>();
            aleatorio = TempData["Aleatorio"] as AleatorioViewModel;
            var response = _client.GetAsync("api/arma").Result;

            if (response.IsSuccessStatusCode)
            {

                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<ArmaViewModel>>().Result;
                if(aleatorio.numeroArma == 0)
                    aleatorio.numeroArma = numeroAleatorioArma.Next((ViewBag.result).Count) + 1;
                armaList.Add(new ArmaViewModel() { ArmaCod = 0, ArmaNome = "Escolhe a arma do crime..." });
                foreach (var arma in ViewBag.result)
                {
                    armaList.Add(new ArmaViewModel() { ArmaCod = arma.ArmaCod, ArmaNome = arma.ArmaNome });
                }
            }
            else
            {
                ViewBag.result = "Error";
            }
            TempData["Aleatorio"] = aleatorio;
            return Json(new SelectList(armaList, "ArmaCod", "ArmaNome"));
        }
    }
}