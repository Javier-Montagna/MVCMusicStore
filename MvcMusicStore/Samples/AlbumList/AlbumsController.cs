using System.Collections.Generic;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class AlbumsController : Controller
    {
        public ActionResult ListWeaklyTyped()
        {
            var albums = new List<AlbumSample>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new AlbumSample { Title = "Album " + i });
            }
            ViewBag.Albums = albums;
            return View();
        }
        
        public ActionResult ListStronglyTyped()
        {
            var albums = new List<AlbumSample>();
            for (int i = 0; i < 10; i++) 
            {
                albums.Add(new AlbumSample { Title = "Album " + i });
            }
            return View(albums);
        }
    }
}
