using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Badge
    {
        public int IdBadge { get; set; }
        public int? IdPhonePrice { get; set; }
        public int? IdBadgeImg { get; set; }
        public int? IdMobilePackage { get; set; }
        public string Text { get; set; }
        public string Colour { get; set; }

        public virtual BadgeImg IdBadgeImgNavigation { get; set; }
        public virtual MobilePackage IdMobilePackageNavigation { get; set; }
        public virtual MobilePackagePrice IdPhonePriceNavigation { get; set; }
    }
}
