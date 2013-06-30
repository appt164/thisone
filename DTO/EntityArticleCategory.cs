using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DTO
{
    public class EntityArticleCategory
    {
        [Key]
        public int CategoryID { get; set; }

        [DisplayName("Catégorie")]
        public string name
        {
            get;
            set;
        }

        public virtual ICollection<EntityArticle> Articles
        {
            get;
            set;
        }
    }
}
