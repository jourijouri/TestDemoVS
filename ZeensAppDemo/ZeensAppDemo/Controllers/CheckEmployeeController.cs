using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ZeensAppDemo.Controllers
{
    public class CheckEmployeeController : ApiController
    {
        public CheckEmployeeController()
        {
        }

        public virtual Boolean checkEmp()
        {
            return false;
         //   throw new NotImplementedException();
        }
    }

   
}
