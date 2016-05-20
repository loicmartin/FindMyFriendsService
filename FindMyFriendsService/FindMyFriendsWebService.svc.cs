using FindMyFriendsCommunication;
using FindMyFriendsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FindMyFriendsService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class FindMyFriendsWebService : IFindMyFriendsWebService
    {
        private FindMyFriendsContext _db = new FindMyFriendsContext();


        public IEnumerable<GroupDTO> GetGroups(Guid userId)
        {
            //ICollection<Group> groups = _db.Groups.Where(g => g.Users.Where(u => u.ID == userId).Count()!=0).ToArray();
            User usr = _db.Users.SingleOrDefault(u => u.ID == userId);
            ICollection<Group> groups = usr.Groups;
            IEnumerable<GroupDTO> grpDTOs = groups.Select(g => new GroupDTO(g));
            return grpDTOs;
        }

        public IEnumerable<UserDTO> GetUsers(Guid groupId)
        {
            //ICollection<User> users = _db.Users.Where(u => u.Groups.Where(g => g.ID == groupId).Count() != 0).ToArray();
            ICollection<User> users = _db.Groups.Single(grp => grp.ID == groupId).Users;
            IEnumerable<UserDTO> usrDTOs = users.Select(u => new UserDTO(u));
            return usrDTOs;
        }

        public void CreateAccount(AccountDTO account)
        {
            User usr = new User { Name = account.Name, Email = account.Email, Password = account.Password};
            _db.Users.Add(usr);
            _db.SaveChanges();
        }


        public UserDTO Login(AccountDTO account)
        {
            User usr = _db.Users.Single(u => u.Email == account.Email && u.Password == account.Password);
            if(usr!=null)
            {
                UserDTO userDTO = new UserDTO(usr);
                return userDTO;
            }
            return null;
        }
    }
}
