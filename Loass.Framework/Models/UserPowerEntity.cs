﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
public class UserPowerEntity
{
        [Key]
        public Int32 user_id{get;set;}
        public Int32 power_id{get;set;}
}
}
