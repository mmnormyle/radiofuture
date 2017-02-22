using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadioFutureCore.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Media> Recs { get; set; }
        public int CurSessionID { get; set; }

        public User(int id, string name)
        {
            ID = id;
            Name = name;
            VideoTime = -1;
            QueuePosition = -1;
            YTPlayerState = -1;
            CurSessionID = -1;
        }
        public int VideoTime { get; set; }
        public int QueuePosition { get; set; }
        public int YTPlayerState { get; set; }
        public bool Waiting { get; set; }
    }

}
