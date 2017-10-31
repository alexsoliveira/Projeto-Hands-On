﻿using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace TesteHandsonCurriculum.Infra.CC.MvcFilters
{
    public class ClaimsAuthorizeAttribute:AuthorizeAttribute
    {
        private readonly string _claimName;
        private readonly string _claimValue;
        public ClaimsAuthorizeAttribute(string claimName, string claimValue)
        {
            this._claimName = claimName;
            this._claimValue = claimValue;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var identity = (ClaimsIdentity)httpContext.User.Identity;
            var claim = identity.Claims.FirstOrDefault(c=>c.Type == _claimName);
            if(claim != null)
            {
                return claim.Value.Contains(_claimValue);
            }
            return false;
        }
    }
}