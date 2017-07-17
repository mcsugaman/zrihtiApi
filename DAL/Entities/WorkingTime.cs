using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class WorkingTime
    {
        public int IdWorkingTime { get; set; }
        public int IdOffice { get; set; }
        public int IdDayCod { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual CodDay IdDayCodNavigation { get; set; }
        public virtual Office IdOfficeNavigation { get; set; }
    }
}
