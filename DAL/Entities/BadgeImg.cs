using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class BadgeImg
    {
        public BadgeImg()
        {
            Badge = new HashSet<Badge>();
        }

        public int IdBadgeImg { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public virtual ICollection<Badge> Badge { get; set; }
    }
}
