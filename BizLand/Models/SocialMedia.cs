using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizLand.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public TeamMember TeamMember { get; set; }
    }
}
