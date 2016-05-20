using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyFriendsData
{
    public class FindMyFriendsInitializer : DropCreateDatabaseAlways<FindMyFriendsContext>
    {
        protected override void Seed(FindMyFriendsContext context)
        {
            var users = new List<User>
            {
                new User{Name="Loic",Password="lolo",Email="loic.martin@davidson.fr"},
                new User{Name="Anne",Password="lolo",Email="anne.martin@davidson.fr"},
                new User{Name="Antoine",Password="toto",Email="antoine.spriet@orangina.fr",Latitude=50.644580, Longitude=3.057239}
            };
            

            var groups = new List<Group>
            {
                new Group{Name="Amis"},
                new Group{Name="Famille"}
            };
            users.ForEach(u => context.Users.Add(u));
            groups.ForEach(g => context.Groups.Add(g));
            //context.SaveChanges();
            //User usr = context.Users.Find(new Guid("7CE7BD93-32B7-4A4D-967B-8991FDD4FB54"));//Find(new Guid("7CE7BD93-32B7-4A4D-967B-8991FDD4FB54"));
            //Group grp = context.Groups.Find(new Guid("{7CE7BD93-32B7-4A4D-967B-8991FDD4FB58}"));
            //usr.Groups.Add(grp);

            users[0].Groups.Add(groups[0]);
            users[0].Groups.Add(groups[1]);
            users[1].Groups.Add(groups[1]);
            users[2].Groups.Add(groups[0]);

            
            context.SaveChanges();
        }
    }
}
