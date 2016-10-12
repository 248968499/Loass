
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
    public class GroupEntity
    {
        [Key]
        public Int32 group_id { get; set; }
        public String group_name { get; set; }
    }
}
