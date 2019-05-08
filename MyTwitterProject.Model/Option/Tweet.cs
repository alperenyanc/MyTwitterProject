using MyTwitterProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitterProject.Model.Option
{
    public class Tweet:CoreEntity
    {
        public string TweetContent { get; set; }

        public virtual List<Comment> Comments { get; set; }
        public virtual List<Like> Likes { get; set; }

        public Guid AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }

    }
}
