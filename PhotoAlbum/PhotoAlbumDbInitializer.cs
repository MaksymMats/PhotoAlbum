using PhotoAlbum.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum
{
    public class PhotoAlbumDbInitializer:DropCreateDatabaseIfModelChanges<MyDBContext>
    {
        protected override void Seed(MyDBContext context)
        {
            var Role_user = new Role() { RoleName = "User" };
            var Role_admin = new Role() { RoleName = "Admin" };
            var roles = new List<Role>() { };
            roles.Add(Role_user);
            roles.Add(Role_admin);
            context.Set<Role>().AddRange(roles);

            var user = new User()
            {
                Username = "super_user",
                Email = "zmacapura05@gmail.com",
                Password = "tryharder1#9"
                
            };
            context.Set<User>().Add(user);
            Role_user.Users.Add(user);
            Role_admin.Users.Add(user);
            
            base.Seed(context);
        }
    }
}
