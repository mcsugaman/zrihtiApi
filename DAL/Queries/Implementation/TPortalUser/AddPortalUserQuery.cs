using DAL.Queries.Abstract.TPortalUser;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using System.Linq;

namespace DAL.Queries.Implementation.TPortalUser
{
    public class AddPortalUserQuery : IAddPortalUserQuery
    {
        private readonly ZrihtiContext db;

        public AddPortalUserQuery()
        {
            db = new ZrihtiContext();
        }

        public void execute(PortalUser user)
        {
            this.db.PortalUser.Add(user);
            this.db.SaveChanges();
        }
    }
}
