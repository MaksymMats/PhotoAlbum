using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum.Entities
{
    public class Album : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public DateTime? LoadingTime { get; set; }
        public int PictureId { get; set; }
        public virtual Picture Picture { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}
