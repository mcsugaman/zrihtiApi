using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class ServiceDescriptionImg
    {
        public int IdServiceDescriptionImg { get; set; }
        public int IdServiceDescription { get; set; }
        public int? OrderNo { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ServiceDescription IdServiceDescriptionNavigation { get; set; }
    }
}
