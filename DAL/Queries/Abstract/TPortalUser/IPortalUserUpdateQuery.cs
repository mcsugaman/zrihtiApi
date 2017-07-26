using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Queries.Abstract.TPortalUser
{
    public interface IPortalUserUpdateQuery
    {
        void execute(PortalUser user);
    }
}
