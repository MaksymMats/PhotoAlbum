using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum.Entities
{
   public class User : IEntity
   {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual Avatar Avatar { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public User()
        {
            Roles = new List<Role>();
        }
   }
}
