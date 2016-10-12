
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
    public class ArticleSortEntity
    {
        [Key]
        public Int32 sort_article_id { get; set; }
        public Int32 user_id { get; set; }
        public String sort_article_name { get; set; }
    }
}
