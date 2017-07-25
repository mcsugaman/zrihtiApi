using DAL.Queries.Abstract.TPortalUser;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using System.Linq;

namespace DAL.Queries.Implementation.TPortalUser
{
    public class GetPortalUserByEmailQuery : IGetPortalUserByEmailQuery
    {
        private readonly ZrihtiContext db;

        public GetPortalUserByEmailQuery()
        {
            db = new ZrihtiContext();
        }


        public PortalUser execute(string email)
        {
            return this.db.PortalUser.Where(x => x.LoginId.Equals(email)).FirstOrDefault();
        }
    }
}
