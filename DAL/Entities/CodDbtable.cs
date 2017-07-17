using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodDbtable
    {
        public CodDbtable()
        {
            CodelistTr = new HashSet<CodelistTr>();
            Feedback = new HashSet<Feedback>();
            PromotionPlan = new HashSet<PromotionPlan>();
        }

        public int IdDbtableCod { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CodelistTr> CodelistTr { get; set; }
        public virtual ICollection<Feedback> Feedback { get; set; }
        public virtual ICollection<PromotionPlan> PromotionPlan { get; set; }
    }
}
