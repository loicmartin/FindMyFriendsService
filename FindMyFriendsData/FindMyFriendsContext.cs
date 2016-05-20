using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyFriendsData
{
    public class FindMyFriendsContext : DbContext
    {
        public FindMyFriendsContext():base("FindMyFriendsContext")
        {

        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
