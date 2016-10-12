
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
public class PowerListEntity
{
        [Key]
        public Int32 power_id{get;set;}
        public String power_name{get;set;}
}
}
