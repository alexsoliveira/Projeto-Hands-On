using System.Web.Mvc;

namespace TesteHandsonCurriculum.Infra.CC.MvcFilters
{
    public class GlobalErrorHandler:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if(filterContext.Exception != null)
            {
                filterContext.Controller.TempData["ErrorCode"] = "";
            }
        }
    }
}