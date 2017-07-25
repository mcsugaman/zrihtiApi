using DAL.Entities;
using DAL.Queries.Abstract.TPortalUser;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL.Queries.Implementation.TPortalUser
{
    public class PortalUserConfirmMailQuery : IPortalUserConfirmMailQuery
    {
        private readonly ZrihtiContext db;

        public PortalUserConfirmMailQuery()
        {
            db = new ZrihtiContext();
        }
        public string execute(string email, string hash)
        {
            PortalUser _user = this.db.PortalUser.Where(x => x.LoginId.Equals(email)).FirstOrDefault();

            if(_user == null)
            {
                return "Error1";
            }else if(_user != null)
            {
                if (_user.ConfirmationHash.Equals(hash))
                {
                    _user.Confirmed = true;
                    db.SaveChanges();
                    return "Success1";
                }else
                {
                    return "Error2";
                }
            }else
            {
                return "Error3";
            }
        }
    }
}
