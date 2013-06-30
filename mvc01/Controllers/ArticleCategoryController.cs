using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using DTO;

namespace mvc01.Controllers
{
    public class ArticleCategoryController : Controller
    {
        //
        // GET: /ArticleCategory/

        public ActionResult Index()
        {
            ArticleCategoryProvider articleCategoryProvider = new ArticleCategoryProvider();

            List<EntityArticleCategory> articles = articleCategoryProvider.GetAllArticleCategories();

            return View(articles);
        }

        //
        // GET: /ArticleCategory/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ArticleCategory/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ArticleCategory/Create

        [HttpPost]
        public ActionResult Create(string name)
        {
            try
            {
                // TODO: Add insert logic here
                ArticleCategoryProvider articleCategoryProvider = new ArticleCategoryProvider();
                articleCategoryProvider.Create(name);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ArticleCategory/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ArticleCategory/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ArticleCategory/Delete/5

        public ActionResult Delete(int id)
        {
            ArticleCategoryProvider articleProvider = new ArticleCategoryProvider();
            articleProvider.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
