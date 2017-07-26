using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAccountBusiness
    {
        string registerNewUser(string firstName, string lastName, string email, string username, string password);

        string confirmMail(string email, string hash);

        string retrieveForgottenPassword(string email);

        string renewPassword(string email, string password);
    }
}
