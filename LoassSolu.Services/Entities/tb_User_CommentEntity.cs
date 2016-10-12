
using System;
using System.Collections.Generic;
using System.Text;
namespace LoassSolu.Services.Entities
{
public class tb_User_CommentEntity
{
    
        public Int32 c_id{get;set;}
        public Int32 user_id{get;set;}
        public Int32 type_id{get;set;}
        public Int32 commit_id{get;set;}
        public String commit_content{get;set;}
        public Int32 commit_user_id{get;set;}
        public DateTime commit_time{get;set;}
        public String commit_ip{get;set;}
        public String place{get;set;}
}
}
