﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
public class FriendlyLinkEntity
{
        [Key]
        public Int32 link_id{get;set;}
        public String link_name{get;set;}
        public String link_url{get;set;}
        public String link_logo{get;set;}
        public Int32 show_order{get;set;}
        public Int32 user_id{get;set;}
}
}
