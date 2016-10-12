
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Loass.Framework.Models
{
    public class FriendEntity
    {
        [Key]
        public Int32 f_id { get; set; }
        public Int32 user_id { get; set; }
        public Int32 friend_id { get; set; }
    }
}
