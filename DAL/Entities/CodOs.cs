using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodOs
    {
        public CodOs()
        {
            CodPhone = new HashSet<CodPhone>();
        }

        public int IdOscod { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CodPhone> CodPhone { get; set; }
    }
}
