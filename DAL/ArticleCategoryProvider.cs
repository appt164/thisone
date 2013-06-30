using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace DAL
{
    public class ArticleCategoryProvider
    {
        public ArticleCategoryProvider()
        {

        }

        public List<EntityArticleCategory> GetAllArticleCategories()
        {
            App164Context context = new App164Context();
            return context.ArticleCategories.ToList();
        }

        public void Create(string catName)
        {
            using (App164Context context = new App164Context())
            {
                context.ArticleCategories.Add(new EntityArticleCategory
                {
                    name = catName
                });

                try
                {
                    context.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
            }
        }

        public void Delete(int id)
        {
            using (App164Context context = new App164Context())
            {
                EntityArticleCategory articleCat = context.ArticleCategories.SingleOrDefault(m => m.CategoryID == id);
                context.ArticleCategories.Remove(articleCat);
                context.SaveChanges();
            }
        }
    }
}
