using System.Collections.Generic;
using System;
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

    [HttpGet("/collections/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/collections")]
    public ActionResult Create(string collectionName)
    {
      Collection newcollection = new Collection(collectionName);
      return RedirectToAction("Index");
    }

    [HttpGet("/collections/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Collection selectedCollection = Collection.Find(id);
      List<Album> collectionAlbums = selectedCollection.Albums;
      model.Add("collection", selectedCollection);
      model.Add("albums", collectionAlbums);
      return View(model);
    }

    [HttpPost("/collections/{collectionsId}/albums")]
    public ActionResult Create(int collectionId, string albumName, string artist)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Collection foundCollection = Collection.Find(collectionId);
      Album newAlbum = new Album(albumName, artist);
      foundCollection.AddAlbum(newAlbum);
      List<Album> collectionAlbums = foundCollection.Albums;
      model.Add("albums", collectionAlbums);
      model.Add("collection", foundCollection);
      return View("Show", model);
    }
  }    
}