using PhotoAlbum.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum
{
    public class MyDBContext :DbContext
    {
        static MyDBContext()
        {
            Database.SetInitializer<MyDBContext>(new PhotoAlbumDbInitializer());
        }

        public MyDBContext() : base("DbConnectionString")
        {
            
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Avatar> Avatars { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
