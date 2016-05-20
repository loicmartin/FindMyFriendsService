using FindMyFriendsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FindMyFriendsCommunication
{
    [DataContract]
    public class GroupDTO
    {
        public GroupDTO()
        {

        }
        public GroupDTO(Group grp)
        {
            this.ID = grp.ID;
            this.Name = grp.Name;
        }
        [DataMember]
        public Guid ID { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}