using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        [HttpGet]
        public ContentResult Index()
        {
            return Content("Hola desde Store.Index()");
        }

        [HttpGet]
        public ContentResult Browse()
        {
            return Content("Hola desde Store.Browse()");
        }

        [HttpGet]
        public ContentResult Details(int Id)
        {
            return Content("Hola desde Store.Details() - ID = " + Id);
        }
    }
}