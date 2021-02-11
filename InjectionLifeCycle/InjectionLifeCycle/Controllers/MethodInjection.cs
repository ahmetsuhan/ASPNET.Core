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
    public class MethodInjection : ControllerBase
    {


        public MethodInjection()
        {
         

        }


       [HttpGet]
       [Route("GetActionInjection")]
       public string  GetActionInjection([FromServices] IScopedService scopedService)
        {
            string result = $"Scoped Service : {scopedService.GetId()}" ;
            return result;
        }

    }
}
