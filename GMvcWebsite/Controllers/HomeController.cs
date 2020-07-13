using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json;
using GMvcWebsite.Models;
namespace GMvcWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title="Guersan's Gaming Site";
            return View();
        }

        [HttpGet]
        public ActionResult Wrestlers()
        {
            ViewBag.Titel = "Characters";

            //get the Json filepath  
            string file = Server.MapPath("~/JsonFiles/characters.json");
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);
            var ChartersListing = JsonConvert.DeserializeObject<List<Characters>>(Json);
            return View(ChartersListing);

        }
        [HttpGet]

        public ActionResult CharactersByClass(string Id) {
          
            string file = Server.MapPath("~/JsonFiles/characters.json");
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);
            var ChartersListing = JsonConvert.DeserializeObject<List<Characters>>(Json).ToList();
            ChartersListing = ChartersListing.Where(x => x.classType.ToString() == Id).ToList();
            return View(ChartersListing);
        }
        public ActionResult TestCard() {

            return View();
        }
        [HttpGet]
 
        public ActionResult WrestlerDetails(string id)
        {
            var model = new Characters();
            string file = Server.MapPath("~/JsonFiles/characters.json");
            //deserialize JSON from file  
            string Json = System.IO.File.ReadAllText(file);
            var ChartersListing = JsonConvert.DeserializeObject<List<Characters>>(Json).ToList();
            model = ChartersListing.Where(x => x.CharacterName == id).FirstOrDefault();
            return PartialView(model);
        }
    }
}