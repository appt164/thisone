using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL.Objects;
using BL.Articles;

namespace mvc01.Controllers
{
    public class ArticlesController : Controller
    {
        //
        // GET: /Articles/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllArticles()
        {
            List<Article> articles = ArticlesBL.GetAllArticles();
            return View(articles);
        }
    }
}
