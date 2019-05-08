﻿using MyTwitterProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitterProject.Model.Option
{
    public class Like:CoreEntity
    {
        public short LikeNumber { get; set; }

        public Guid AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }

        public Guid TeewtID { get; set; }
        public virtual Tweet Tweet { get; set; }
    }
}
