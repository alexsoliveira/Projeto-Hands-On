using System.Collections.Generic;
using System.Web.Http;
using TesteHandsonCurriculum.Application.Interfaces;
using TesteHandsonCurriculum.Application.ViewModels;

namespace TesteHandsonCurriculum.Services.REST.Controllers
{
    public class ArmaController : ApiController
    {
        private readonly IArmaAppService _armaAppService;
        public ArmaController(IArmaAppService armaAppService)
        {
            _armaAppService = armaAppService;
        }
        // GET: api/Arma
        [HttpGet]
        public IEnumerable<ArmaViewModel> ObterArmas()
        {
            return _armaAppService.ObterTodos();
        }
        // GET: api/Arma/5
        [HttpGet]
        public ArmaViewModel ObterArmaPorId(int id)
        {
            return _armaAppService.ObterPorId(id);
        }
    }    
}