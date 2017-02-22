using System.Collections.Generic;

namespace RadioFutureCore.Models
{
    public class Session
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Media> Queue { get; set; }
    }
}
