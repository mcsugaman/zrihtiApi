using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAccountBusiness
    {
        string registerNewUser(string email, string username, string password);

        string confirmMail(string email, string hash);
    }
}
