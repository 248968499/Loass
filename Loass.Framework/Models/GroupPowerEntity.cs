
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
public class GroupPowerEntity
{
        [Key]
        public Int32 group_id{get;set;}
        public Int32 power_id{get;set;}
}
}
