using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodFeedbackType
    {
        public CodFeedbackType()
        {
            Feedback = new HashSet<Feedback>();
        }

        public int IdFeedbackTypeCod { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Feedback> Feedback { get; set; }
    }
}
