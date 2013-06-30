using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DTO
{
    public class EntityArticle
    {
        [Key]
        public int ArticleID { get; set; }

        [DisplayName("Nom")]
        public string name { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Priority")]
        public int priority
        {
            get;
            set;
        }

        [DisplayName("Catégorie")]
        public int CategoryID
        {
            get;
            set;
        }

        public virtual EntityArticleCategory Category
        {
            get;
            set;
        }
    }

}
