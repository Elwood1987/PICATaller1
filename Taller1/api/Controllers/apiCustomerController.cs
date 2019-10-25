using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taller1.Models;

namespace Taller1.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class apiCustomerController : ControllerBase
    {
        public object register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                return Ok(new { message = "OK" });
            }
            else
            {
                return BadRequest(new { message = "error" });
            }
        }
    }


}