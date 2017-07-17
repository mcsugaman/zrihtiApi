using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class ProviderTr
    {
        public int IdProviderTr { get; set; }
        public int IdLanguageCod { get; set; }
        public int IdProvider { get; set; }
        public string Description { get; set; }

        public virtual CodLanguage IdLanguageCodNavigation { get; set; }
        public virtual Provider IdProviderNavigation { get; set; }
    }
}
