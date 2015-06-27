using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NgBudget.Controllers
{
    public class AccountsController : ApiController
    {
        [Route("CreateAccount")]
        [HttpGet]
        public string CreateAccount()
        {

            return "ok";
        }
    }
}
