using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class SocialNetwork
    {
        public int IdSocialNetwork { get; set; }
        public int IdProvider { get; set; }
        public int IdSocialNetworkCod { get; set; }
        public string UserId { get; set; }

        public virtual Provider IdProviderNavigation { get; set; }
        public virtual CodSocialNetwork IdSocialNetworkCodNavigation { get; set; }
    }
}
