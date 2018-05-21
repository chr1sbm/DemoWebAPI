using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testapi.Controllers
{
    public class TestController : ApiController
    {
        public HttpResponseMessage Get() {

            
               List<employee> allEmp = new List<employee>();
               using (TestapiEntities1 dc = new TestapiEntities1()) {

                   allEmp = dc.employee.OrderBy(a => a.FirstName).ToList();
                   HttpResponseMessage response;
                   response = Request.CreateResponse(HttpStatusCode.OK, allEmp);
                   return response;
               } 

         
            
            
          
        }
    }
}
