using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace MusicCollection.Controllers
{
  public class AlbumController : Controller
  {

    [HttpGet("/collections/{collectionId}/albums/new")]
    public ActionResult New(int collectionId)
    {
      Collection collection = Collection.Find(collectionId);
      return View(collection);
    }

    [HttpGet("/collections/{collectionId}/albums/{albumId}")]
    public ActionResult Show(int collectionId, int albumId)
    {
      Album album = Album.Find(albumId);
      Collection collection = Collection.Find(collectionId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("album", album);
      model.Add("collection", collection);
      return View(model);
    }

    [HttpPost("/album/delete")]
    public ActionResult DeleteAll()
    {
      Album.ClearAll();
      return View();
    }

  }
}
