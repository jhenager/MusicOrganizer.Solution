using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
  public class CollectionsController : Controller
  {
    [HttpGet("/collections")]
    public ActionResult Index()
    {
      List<Collection> allCollections = Collection.GetAll();
      return View(allCollections);
    }
  }    
}