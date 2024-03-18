using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReactFoodApp.API_DotNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CustomCorsPolicy")]
    public class OrdersController : ControllerBase
    {
        // place order
        // Post: api/Orders
        
    }
}
