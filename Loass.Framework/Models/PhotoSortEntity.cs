
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
public class PhotoSortEntity
{
        [Key]
        public Int32 sort_img_id{get;set;}
        public String sort_img_name{get;set;}
        public String sort_img_type{get;set;}
        public String img_password{get;set;}
        public Int32 user_id{get;set;}
        public String img_sort_question{get;set;}
        public String img_sort_answer{get;set;}
        public Int32 type_id{get;set;}
        public Int32 top_pic_src{get;set;}
}
}
