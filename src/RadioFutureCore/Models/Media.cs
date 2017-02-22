using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadioFutureCore.Models
{
    public class Media
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string YTVideoID { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public string ThumbURL { get; set; }
    }
}
