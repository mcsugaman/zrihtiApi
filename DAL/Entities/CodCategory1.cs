using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodCategory1
    {
        public CodCategory1()
        {
            CodService = new HashSet<CodService>();
        }

        public int IdCategoryCod { get; set; }
        public int? IdAreaCod { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CodService> CodService { get; set; }
        public virtual CodArea IdAreaCodNavigation { get; set; }
    }
}
