using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NeverMpilo.Controllers
{
    public class HomeApiController : ApiController
    {
        public HttpResponseMessage SaveData(BusinessLogic.Models.Client data)
        {
            string res = "";

            try
            {
                //var surname = Request.Form["Surname"];
                // dblayer.Add_register(rs);
                var ClientDetails = System.Web.Hosting.HostingEnvironment.MapPath("/ClientDetails.xml");
                var response = BusinessLogic.BusinessLogic.SaveClient(ClientDetails,data);
                res = "Successfully saved";
                return Request.CreateResponse<string>(HttpStatusCode.OK, res);
            }

            catch (Exception ex)
            {
                res = "Failed - " + ex.Message;
                return Request.CreateResponse<string>(HttpStatusCode.InternalServerError, res);
            }

            
        }
    }
}
