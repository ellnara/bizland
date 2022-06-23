using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizLand.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        ICollection<SocialMedia> Medias { get; set; }
    }
}
