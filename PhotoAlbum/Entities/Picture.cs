using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum.Entities
{
    public class Picture:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Hash { get; set; }
        public byte[] Image { get; set; }
        public virtual ICollection<Album> Albums{ get; set; }

    }
}
