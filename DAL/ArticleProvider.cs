using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
    public class ArticleProvider
    {
        public ArticleProvider()
        {

        }

        public List<EntityArticle> GetAllArticles()
        {
            App164Context context = new App164Context();
            return context.Articles.ToList();
        }

        public void Create(EntityArticle article)
        {
            using (App164Context context = new App164Context())
            {
                context.Articles.Add(article);

                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (App164Context context = new App164Context())
            {
                EntityArticle article = context.Articles.SingleOrDefault(m => m.ArticleID == id);
                context.Articles.Remove(article);
                context.SaveChanges();
            }
        }

        public void UpdatePriority(int id, int prio)
        {
            using (App164Context context = new App164Context())
            {
                EntityArticle article = context.Articles.SingleOrDefault(m => m.ArticleID == id);
                EntityArticle articleToModify = context.Articles.SingleOrDefault(m => m.ArticleID == id);
                articleToModify.priority = prio;
                context.Entry(article).CurrentValues.SetValues(articleToModify);
                context.SaveChanges();
            }
        }
    }
}
