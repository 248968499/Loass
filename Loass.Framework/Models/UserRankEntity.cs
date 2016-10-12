
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
public class UserRankEntity
{
        [Key]
        public Int32 rank_id{get;set;}
        public Int32 rank_mark{get;set;}
        public String rank_name{get;set;}
}
}
