using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodArea
    {
        public CodArea()
        {
            CodCategory1 = new HashSet<CodCategory1>();
        }

        public int IdAreaCod { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CodCategory1> CodCategory1 { get; set; }
    }
}
