using DAL.Queries.Abstract.TPortalUser;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using System.Linq;

namespace DAL.Queries.Implementation.TPortalUser
{
    public class PortalUserUpdateQuery : IPortalUserUpdateQuery
    {
        private readonly ZrihtiContext db;

        public PortalUserUpdateQuery()
        {
            db = new ZrihtiContext();
        }

        public void execute(PortalUser user)
        {
            PortalUser _pUser = this.db.PortalUser.Where(x => x.IdPortalUser == user.IdPortalUser).FirstOrDefault();

            _pUser.ConfirmationHash = user.ConfirmationHash;
            _pUser.Password = user.Password;
            this.db.SaveChanges();
        }
    }
}
