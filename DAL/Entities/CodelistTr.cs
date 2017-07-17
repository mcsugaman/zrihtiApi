using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodelistTr
    {
        public int IdCodelistTr { get; set; }
        public int IdLanguageCod { get; set; }
        public int IdDbtableCod { get; set; }
        public string Text { get; set; }

        public virtual CodDbtable IdDbtableCodNavigation { get; set; }
        public virtual CodLanguage IdLanguageCodNavigation { get; set; }
    }
}
