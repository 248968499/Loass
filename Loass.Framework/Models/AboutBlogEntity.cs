
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Loass.Framework.Models
{
    public class AboutBlogEntity
    {
        [Key]
        public Int32 blog_id { get; set; }
        public String blog_keyword { get; set; }
        public String blog_description { get; set; }
        public String blog_name { get; set; }
        public String blog_title { get; set; }
    }
}
