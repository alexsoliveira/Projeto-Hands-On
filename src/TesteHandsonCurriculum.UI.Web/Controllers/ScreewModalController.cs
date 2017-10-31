using System.Web.Mvc;
using TesteHandsonCurriculum.UI.Web.Models;

namespace TesteHandsonCurriculum.UI.Web.Controllers
{
    public class ScreewModalController : Controller
    {                           
        public ActionResult ScreewModal(MessageViewModel model)
        {
            return View(model);
        }
    }
}