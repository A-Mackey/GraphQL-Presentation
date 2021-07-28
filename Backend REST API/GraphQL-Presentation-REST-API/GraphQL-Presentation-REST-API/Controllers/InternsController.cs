using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GraphQL_Presentation_REST_API.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GraphQL_Presentation_REST_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InternsController : ControllerBase
    {
        [HttpGet]
        public object Get()
        {
            InternsHolderClass interns = new InternsHolderClass();
            interns.interns = HelperClass.GetInterns();
            
            return interns;
        }
    }
}
