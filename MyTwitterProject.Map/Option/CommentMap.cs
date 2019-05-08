using MyTwitterProject.Core.Map;
using MyTwitterProject.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitterProject.Map.Option
{
    public class CommentMap:CoreMap<Comment>
    {
        public CommentMap()
        {
            ToTable("dbo.Comments");
            Property(x => x.Content).IsRequired();

            HasKey(x => new { x.AppUserID, x.TeewtID });
        }
    }
}
