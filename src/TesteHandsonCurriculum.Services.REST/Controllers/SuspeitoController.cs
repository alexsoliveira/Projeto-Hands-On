using TesteHandsonCurriculum.Application.Interfaces;
using TesteHandsonCurriculum.Application.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace TesteHandsonCurriculum.Services.REST.Controllers
{
    public class SuspeitoController : ApiController
    {
        private readonly ISuspeitoAppService _suspeitoAppService;
        public SuspeitoController(ISuspeitoAppService suspeitoAppService)
        {
            _suspeitoAppService = suspeitoAppService;
        }
        // GET: api/Suspeito
        [HttpGet]
        public IEnumerable<SuspeitoViewModel> ObterSuspeitos()
        {
            return _suspeitoAppService.ObterTodos();
        }
        // GET: api/Suspeito/5
        [HttpGet]
        public SuspeitoViewModel ObterSuspeitoPorId(int id)
        {
            return _suspeitoAppService.ObterPorId(id);
        }
    }
}