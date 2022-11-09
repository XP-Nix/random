using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using static WebApplication2.Controllers.Api1FolderController;

namespace WebApplication2.Controllers
{
    public class ApiKeyTestController : Controller
    {
        // GET: ApiKeyTest
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ApiKeyTest()
        {
            ViewBag.Message = "api1 message";


            api();


            return View();
        }


        public ActionResult api()
        {

            var url = "https://api.nasa.gov/planetary/apod?api_key=h1Y4gLYcsSx9vJjxheVSLHRhgdlLBgAeXmymfp6z";

            var webClient = new WebClient();

            var response = webClient.DownloadString(url);

            var img = JObject.Parse(response);

            ViewBag.response = img["url"].ToString();
            











            return View();
        }


    }
}