
using System;
using System.Collections.Generic;
using System.Text;
namespace LoassSolu.Services.Entities
{
public class tb_Phone_MessageEntity
{
    
        public Int32 phone_id{get;set;}
        public String phone_num{get;set;}
        public String contents{get;set;}
        public DateTime send_time{get;set;}
        public Int32 user_id{get;set;}
}
}
