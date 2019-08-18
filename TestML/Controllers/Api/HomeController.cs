using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestML.Controllers.Api
{
    //[RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
       // [HttpGet, Route("init")]
        public void Init()
        {
            //String que recibe
            string[] matriz = { "ATGCGA", "CAGTGC", "TTATGT", "AGAAGG", "CCCCTA", "TCACTG" };

            //declaro las posibles variables 
            var var1 = "";
            var var2 = "";
            var var3 = "";

            //contadores necesarios
            var cont1 = 1;
            foreach (string item in matriz)
            {
                var1 = var1 + item.Substring(0, cont1);
                cont1++;
            }

        }
    }
}
