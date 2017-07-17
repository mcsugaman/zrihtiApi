using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodSocialNetwork
    {
        public CodSocialNetwork()
        {
            SocialNetwork = new HashSet<SocialNetwork>();
        }

        public int IdSocialNetworkCod { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SocialNetwork> SocialNetwork { get; set; }
    }
}
