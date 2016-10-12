
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
    public class AdEntity
    {
        [Key]
        public Int32 ad_id { get; set; }
        public Int32 position_id { get; set; }
        public Int32 media_type { get; set; }
        public String ad_name { get; set; }
        public String ad_link { get; set; }
        public String ad_code { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public String link_man { get; set; }
        public String link_email { get; set; }
        public String link_phone { get; set; }
        public Int32 click_count { get; set; }
        public Int32 enabled { get; set; }
        public Int32 user_id { get; set; }
    }
}
