using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SSEApplication.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index(string id, string tailUrl)
        {
            //var result = string.Empty;
            //var sb = new StringBuilder();
            //sb.AppendFormat("data: {0}\n\n", DateTime.Now.ToString());
            //var source = Content(sb.ToString(), "text/event-stream");
            // source.onmessage = function (e) {

            //        var li = document.createElement("li");
            //        var returnedItem = e.data;
            //        li.textContent = returnedItem;
            //        $("#messages").append(li);
            //    }
           // return View();

          
            var result = string.Empty;

            DateTime currentdate = DateTime.Now;
            Response.ContentType = "text/event-stream";
            Response.BufferOutput = true;
            var startDate = DateTime.Now;
            Response.Write("Message from " + id+tailUrl);
            while (startDate.AddMinutes(1) > DateTime.Now)
            {
                string Data = @"{""event_type"":""ORIGINATE"",""k_api_key"":""e2887126-09bd-11e4-beda-22000a968f92"",""business_call_type"":""Unanswered"",""agent_number"":""9611795983"",""call_recording"":null,""knowlarity_number"":""+918431102200"",""call_type"":null,""uuid"":""8c97273b-14c6-4e64-9edc-4050471c3ddf"",""customer_number"":""+918067330921"",""application"":""konnect"",""version"":""1.0"",""k_number"":""+918431102200"",""type"":""ORIGINATE"",""called"":""null""}";
                Response.Write(string.Format("data: {0}\n\n", Data));
                Response.Flush();
                System.Threading.Thread.Sleep(1000);
            }
            return View();
        }
        public ActionResult Message()
        {

            

            return View();
        }

       
    }
}
