using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using DTO;

namespace DAL
{
    class App164Context : DbContext
    {
        public DbSet<EntityArticle> Articles
        {
            get;
            set;
        }

        public DbSet<EntityArticleCategory> ArticleCategories
        {
            get;
            set;
        }

    }
}
