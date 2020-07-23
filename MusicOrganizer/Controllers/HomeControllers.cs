using Microsoft.AspNetCore.Mvc;

namespace MusicOrganizer.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [Route("/album_images")]
      public ActionResult AlbumImages()
      {
        return View();
      }
    }

}