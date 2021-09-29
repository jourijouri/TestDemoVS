using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ZeensAppDemo.Controllers
{
    public class ProcessEmployeeController : ApiController
    {
        public CheckEmployeeController ws;


        //private global::Moq.Mock<CheckEmployeeController> chk;

        public ProcessEmployeeController(CheckEmployeeController c)
        {
            this.ws = c;
        }



        public Boolean insertEmployee()
        {


            return ws.checkEmp();
            //    return true;
        }
    }
}
