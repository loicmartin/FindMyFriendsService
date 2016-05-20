using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FindMyFriendsData
{
    
    public class User
    {
        public User()
        {
            this.ID = Guid.NewGuid();
            Groups = new List<Group>();
        }
        public Guid ID { get; private set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public float Vitesse { get; set; }
        public double Altitude { get; set; }
        public virtual ICollection<Group> Groups { get; private set; }
    }
}
