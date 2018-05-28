using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();
        //
        public ActionResult Index()
        {
            var gen = storeDB.Gen.ToList();

            return View(gen);
        }
        //

        //
        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string gen)
        {
            // Pobiera albumy z bazy danych
            var genreModel = storeDB.Gen.Include("Albumy")
                .Single(g => g.Name == gen);

            return View(genreModel);
        }
        //
        public ActionResult Details(int id)
        {
            var album = storeDB.Albums.Find(id);

            return View(album);
        }
    }
}