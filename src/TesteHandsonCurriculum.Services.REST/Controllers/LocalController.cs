using System.Collections.Generic;
using System.Web.Http;
using TesteHandsonCurriculum.Application.Interfaces;
using TesteHandsonCurriculum.Application.ViewModels;

namespace TesteHandsonCurriculum.Services.REST.Controllers
{
    public class LocalController : ApiController
    {
        private readonly ILocalAppService _localAppService;
        public LocalController(ILocalAppService localAppService)
        {
            _localAppService = localAppService;
        }
        // GET: api/Local
        [HttpGet]
        public IEnumerable<LocalViewModel> ObterLocais()
        {
            return _localAppService.ObterTodos();
        }
        // GET: api/Local/5
        [HttpGet]
        public LocalViewModel ObterLocalPorId(int id)
        {
            return _localAppService.ObterPorId(id);
        }
    }
}