﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum.Entities
{
    public class Avatar:IEntity
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public virtual User User { get; set; }
    }
}
