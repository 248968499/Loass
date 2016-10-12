
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
public class UserAttentionEntity
{
        [Key]
        public Int32 a_id{get;set;}
        public Int32 user_id{get;set;}
        public Int32 attention_id{get;set;}
}
}
