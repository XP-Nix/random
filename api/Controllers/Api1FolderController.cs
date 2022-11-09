using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class Api1FolderController : Controller

    {

        public static string desc { get; set; }



        // GET: Api1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Api1()
        {
           ViewBag.Message = "api1 message";


            dnd();
            

            return View();
        }


        public ActionResult dnd()
        {

            var url = "https://www.dnd5eapi.co/api/conditions/blinded";

            var webClient = new WebClient();

            var response = webClient.DownloadString(url);





            var desc = JsonConvert.DeserializeObject<apiString>(response);

            ViewBag.response = response;

            string fulldesc = "";

            for (int i = 0; i < desc.desc.Length; i++)
            {
                fulldesc = fulldesc + " " + desc.desc[i];
            }


            ViewBag.desc = fulldesc;
            

            

            return View();
        }

        public class apiString
        {
            public string[] desc
            {
                get;
                set;
            }
        }
        

    }

    




}