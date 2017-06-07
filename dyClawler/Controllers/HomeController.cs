using dyClawler.Crawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dyClawler.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RefreshMovie()
        {
            //Dy2018MovieCrawler.CrawlHotMovie();
            Dy2018MovieCrawler.CrawlMovieInfo();
            return View();
        }
    }
}