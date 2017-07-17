using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Feedback
    {
        public int IdFeedback { get; set; }
        public int IdDbtableCod { get; set; }
        public int IdFeedbackTypeCod { get; set; }
        public int IdPortalUser { get; set; }
        public int FkEntityId { get; set; }
        public int? Stars { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual CodDbtable IdDbtableCodNavigation { get; set; }
        public virtual CodFeedbackType IdFeedbackTypeCodNavigation { get; set; }
        public virtual PortalUser IdPortalUserNavigation { get; set; }
    }
}
