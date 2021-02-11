using InjectionLifeCycle.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjectionLifeCycle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyInjection : ControllerBase
    {


        public PropertyInjection()
        {


        }

        [HttpGet]
        [Route("GetPropertyInjection")]
        public string GetPropertyInjection()
        {
            var services = this.HttpContext.RequestServices;
            var scopedService = (IScopedService)services.GetService(typeof(IScopedService));
            string res = $"Scoped Service : {scopedService.GetId()}{Environment.NewLine}";
            return res;
        }



    }
}
