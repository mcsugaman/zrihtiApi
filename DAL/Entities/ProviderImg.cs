using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class ProviderImg
    {
        public int IdProviderImg { get; set; }
        public int IdProvider { get; set; }
        public bool? IsLogo { get; set; }
        public int? OrderNo { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Provider IdProviderNavigation { get; set; }
    }
}
