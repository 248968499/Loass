
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
    public class VisitorEntity
    {
        [Key]
        public Int32 v_id { get; set; }
        public Int32 visitor_id { get; set; }
        public DateTime visitor_time { get; set; }
        public Int32 user_id { get; set; }
        public String visitor_ip { get; set; }
        public Int32 type_id { get; set; }
        public Int32 where_id { get; set; }
    }
}
