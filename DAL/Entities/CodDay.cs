using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodDay
    {
        public CodDay()
        {
            WorkingTime = new HashSet<WorkingTime>();
        }

        public int IdDayCod { get; set; }
        public string Name { get; set; }
        public int OrderNo { get; set; }

        public virtual ICollection<WorkingTime> WorkingTime { get; set; }
    }
}
