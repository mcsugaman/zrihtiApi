using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class ServiceTr
    {
        public int IdServiceTr { get; set; }
        public int IdLanguageCod { get; set; }
        public int IdService { get; set; }
        public string Note { get; set; }

        public virtual CodLanguage IdLanguageCodNavigation { get; set; }
        public virtual Service IdServiceNavigation { get; set; }
    }
}
