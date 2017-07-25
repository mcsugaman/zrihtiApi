using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Queries.Abstract.TPortalUser
{
    public interface IPortalUserConfirmMailQuery
    {
        string execute(string email, string hash);
    }
}
