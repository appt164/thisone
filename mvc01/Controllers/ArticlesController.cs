using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL.Articles;
using DAL;
using DTO;

namespace mvc01.Controllers
{
    public class ArticlesController : Controller
    {
        //
        // GET: /Articles/

        public ActionResult Index(string orderBy)
        {
            ArticleProvider articleProvider = new ArticleProvider();

            List<EntityArticle> articles = articleProvider.GetAllArticles();
            return View(articles.OrderBy(x => x.CategoryID).OrderByDescending(x => x.priority).ToList());
        }


        [HttpGet]
        public ActionResult Create()
        {
            ArticleCategoryProvider articleCategoryProvider = new ArticleCategoryProvider();
            ViewBag.CategoryID = new SelectList(articleCategoryProvider.GetAllArticleCategories(), "CategoryID", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(EntityArticle article)
        {
            if (ModelState.IsValid)
            {
                article.priority = 1;
                ArticleProvider articleProvider = new ArticleProvider();
                articleProvider.Create(article);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            ArticleProvider articleProvider = new ArticleProvider();
            articleProvider.Delete(ID);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdatePriority(int ID, int prio)
        {
            ArticleProvider articleProvider = new ArticleProvider();
            articleProvider.UpdatePriority(ID, prio);
            return RedirectToAction("Index");
        }
    }
}
