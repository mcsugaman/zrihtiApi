using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Banner1
    {
        public int IdBanner { get; set; }
        public int IdProvider { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Provider IdProviderNavigation { get; set; }
    }
}
