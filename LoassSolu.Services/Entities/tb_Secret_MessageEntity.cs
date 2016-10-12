
using System;
using System.Collections.Generic;
using System.Text;
namespace LoassSolu.Services.Entities
{
public class tb_Secret_MessageEntity
{
    
        public Int32 secret_id{get;set;}
        public Int32 send_id{get;set;}
        public Int32 receive_id{get;set;}
        public String message_topic{get;set;}
        public String message_content{get;set;}
}
}
