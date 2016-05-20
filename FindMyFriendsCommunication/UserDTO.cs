using FindMyFriendsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FindMyFriendsCommunication
{
    [DataContract]
    public class UserDTO
    {
        public UserDTO()
        {

        }
        public UserDTO(User usr)
        {
            this.ID = usr.ID;
            this.Name = usr.Name;
            this.Login = usr.Login;
            this.Password = usr.Password;
            this.Email = usr.Email;
            this.Longitude = usr.Longitude;
            this.Latitude = usr.Latitude;
            this.Vitesse = usr.Vitesse;
            this.Altitude = usr.Altitude;
        }
        [DataMember]
        public Guid ID { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public double Longitude { get; set; }
        [DataMember]
        public double Latitude { get; set; }
        [DataMember]
        public float Vitesse { get; set; }
        [DataMember]
        public double Altitude { get; set; }
    }
}