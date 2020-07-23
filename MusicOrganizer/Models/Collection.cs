using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Collection
{
    private static List<Collection> _instances = new List<Collection> {};
    public string CollectionName { get; set; }
    public int Id { get; }
    public List<Album> Albums { get; set; }

    public Collection(string collectionName)
    {
      CollectionName = collectionName;
      _instances.Add(this);
      Id = _instances.Count;
      Albums = new List<Album>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Collection> GetAll()
    {
      return _instances;
    }

    public static Collection Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddAlbum(Album album)
    {
      Albums.Add(album);
    }
  }
}