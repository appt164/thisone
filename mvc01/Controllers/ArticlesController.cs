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
            switch (orderBy)
            {
                case "nameDesc":
                    articles = articles.OrderBy(x => x.CategoryID).OrderByDescending(x => x.name).ToList();
                    break;
                case "nameAsc":
                    articles = articles.OrderBy(x => x.CategoryID).OrderBy(x => x.name).ToList();
                    break;

                case "descDesc":
                    articles = articles.OrderBy(x => x.CategoryID).OrderByDescending(x => x.description).ToList();
                    break;
                case "descAsc":
                    articles = articles.OrderBy(x => x.CategoryID).OrderBy(x => x.description).ToList();
                    break;

                case "categoryDesc":
                    articles = articles.OrderBy(x => x.Category.name).ToList();
                    break;
                case "categoryAsc":
                    articles = articles.OrderByDescending(x => x.Category.name).ToList();
                    break;

                case "priorityDesc":
                    articles = articles.OrderBy(x => x.CategoryID).OrderByDescending(x => x.priority).ToList();
                    break;
                case "priorityAsc":
                    articles = articles.OrderBy(x => x.CategoryID).OrderBy(x => x.priority).ToList();
                    break;
                default:
                    articles = articles.OrderBy(x => x.CategoryID).OrderByDescending(x => x.priority).ToList();
                    break;
            }

            return View(articles);
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
