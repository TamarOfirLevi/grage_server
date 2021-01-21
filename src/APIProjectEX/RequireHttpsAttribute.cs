using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace APIProjectEX
{
    public class RequireHttpsAttribute: AuthorizationFilterAttribute
    {

    public override void OnAuthorization(HttpActionContext actionContext)
    {
        if (!actionContext.Request.RequestUri.Scheme.ToString().Equals(Uri.UriSchemeHttps))  
        {
            actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden)
            {
                ReasonPhrase = "HTTPS Required for this call"
            };
        }  
        else  
        {
            base.OnAuthorization(actionContext);
        }
    }
    }
}
