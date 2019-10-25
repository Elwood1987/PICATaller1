using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller1.Filters
{
    public class Exception : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { controller = "Customer", action = "Error", message = context.Exception.Message })
                );
        }
    }
}
