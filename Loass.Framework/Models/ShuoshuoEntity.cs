
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
public class ShuoshuoEntity
{
        [Key]
        public Int32 shuo_id{get;set;}
        public Int32 user_id{get;set;}
        public DateTime shuo_time{get;set;}
        public String shuo_ip{get;set;}
        public String shuoshuo{get;set;}
        public Int32 type_id{get;set;}
}
}
