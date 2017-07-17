using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class ServiceDescriptionTr
    {
        public int IdServiceDescriptionTr { get; set; }
        public int IdServiceDescription { get; set; }
        public int IdLanguageCod { get; set; }
        public string Description { get; set; }

        public virtual CodLanguage IdLanguageCodNavigation { get; set; }
        public virtual ServiceDescription IdServiceDescriptionNavigation { get; set; }
    }
}
