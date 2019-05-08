using MyTwitterProject.Core.Map;
using MyTwitterProject.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitterProject.Map.Option
{
    public class TweetMap:CoreMap<Tweet>
    {
        public TweetMap()
        {
            ToTable("dbo.Tweets");
            Property(x => x.TweetContent).IsOptional();

            HasRequired(x => x.AppUser)
               .WithMany(x => x.Tweets)
               .HasForeignKey(x => x.AppUserID)
               .WillCascadeOnDelete(false);
            HasMany(x => x.Likes)
                .WithRequired(x => x.Tweet)
                .HasForeignKey(x => x.TeewtID)
            .WillCascadeOnDelete(false);
            HasMany(x => x.Comments)
                .WithRequired(x => x.Tweet)
                .HasForeignKey(x => x.TeewtID)
            .WillCascadeOnDelete(false);




        }
    }
}
