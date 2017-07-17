using DAL.Queries.Abstract.Test;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DAL.Entities;

namespace DAL.Queries.Implementation.Test
{
    public class GetProviderQuery : IGetProvidersQuery
    {
        private readonly ZrihtiContext db;

        public GetProviderQuery(){
            db = new ZrihtiContext();
        }

        public CodPlace execute()
        {
            return this.db.CodPlace.Where(x => x.IdPlaceCod == 1).FirstOrDefault();
        }
    }
}
