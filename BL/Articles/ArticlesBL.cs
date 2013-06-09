using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BL.Objects;

namespace BL.Articles
{
    public class ArticlesBL
    {
        public static List<Article> GetAllArticles()
        {
            List<Article> articles = new List<Article>()
            {
                new Article(){name = "Pq", description = "trucs de pq"},
                new Article(){name = "sopalins", description = "trucs de sopalins"},
                new Article(){name = "Liquide vaisselle", description = "trucs de liquide vaisselle"}
            };

            return articles;
        }

        public static void AddArticle(Article article)
        {
            
        }
    }
}
