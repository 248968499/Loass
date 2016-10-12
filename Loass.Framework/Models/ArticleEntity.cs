
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
    public class ArticleEntity
    {
        [Key]
        public Int32 article_id { get; set; }
        public String article_name { get; set; }
        public DateTime article_time { get; set; }
        public String article_ip { get; set; }
        public Int32 article_click { get; set; }
        public Int32 sort_article_id { get; set; }
        public Int32 user_id { get; set; }
        public Int32 type_id { get; set; }
        public Int32 article_type { get; set; }
        public String article_content { get; set; }
        public Int32 article_up { get; set; }
        public Int32 article_support { get; set; }
    }
}
