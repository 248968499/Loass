
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
public class SecretMessageEntity
{
        [Key]
        public Int32 secret_id{get;set;}
        public Int32 send_id{get;set;}
        public Int32 receive_id{get;set;}
        public String message_topic{get;set;}
        public String message_content{get;set;}
}
}
