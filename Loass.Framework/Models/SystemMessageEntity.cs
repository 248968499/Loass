
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
public class SystemMessageEntity
{
        [Key]
        public Int32 system_id{get;set;}
        public Int32 send_id{get;set;}
        public Int32 group_id{get;set;}
        public Int32 send_default{get;set;}
        public String system_topic{get;set;}
        public String system_content{get;set;}
}
}
