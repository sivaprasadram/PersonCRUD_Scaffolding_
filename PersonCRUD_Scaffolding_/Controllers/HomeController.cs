using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonCRUD_Scaffolding_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ToolsCS Context = new ToolsCS();

           var Listofdata = Context.persons.ToList();

            return View(Listofdata);

        }         


    }
}