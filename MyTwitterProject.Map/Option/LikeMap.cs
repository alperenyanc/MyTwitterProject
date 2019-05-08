using MyTwitterProject.Core.Map;
using MyTwitterProject.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTwitterProject.Map.Option
{
    public class LikeMap:CoreMap<Like>
    {
        public LikeMap()

        {
            ToTable("dbo.Likes");
            Property(x => x.LikeNumber).IsOptional();



            HasKey(x => new { x.AppUserID, x.TeewtID });
        }
    }
}
