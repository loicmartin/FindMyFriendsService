using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FindMyFriendsData
{
    
    public class Group
    {
        public Group()
        {
            this.ID = Guid.NewGuid();
            Users = new List<User>();
        }
        public Guid ID { get; private set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; private set; }
    }
}
