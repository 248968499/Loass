﻿
using System;
using System.Collections.Generic;
using System.Text;
namespace LoassSolu.Services.Entities
{
public class tb_PhotosEntity
{
    
        public Int32 photo_id{get;set;}
        public String photo_name{get;set;}
        public String photo_src{get;set;}
        public String photo_description{get;set;}
        public Int32 user_id{get;set;}
        public Int32 sort_img_id{get;set;}
        public Int32 upload_time{get;set;}
        public String upload_ip{get;set;}
}
}
