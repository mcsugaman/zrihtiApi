using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class PackageTr
    {
        public int IdPackageTr { get; set; }
        public int IdPackage { get; set; }
        public int IdLanguageCod { get; set; }
        public string Name { get; set; }
        public string SubTitle { get; set; }

        public virtual CodLanguage IdLanguageCodNavigation { get; set; }
        public virtual Package IdPackageNavigation { get; set; }
    }
}
