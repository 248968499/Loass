
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
public class UserGroupEntity
{
        [Key]
        public Int32 user_id{get;set;}
        public Int32 group_id{get;set;}
}
}
