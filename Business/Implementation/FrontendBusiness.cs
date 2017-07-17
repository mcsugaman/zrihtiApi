using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using DAL.Queries.Abstract.Test;

namespace Business.Implementation
{
    public class FrontendBusiness : IFrontendBusiness
    {
        private readonly IGetProvidersQuery _getProviderQuery;

        public FrontendBusiness(IGetProvidersQuery getProvidersQuery)
        {
            _getProviderQuery = getProvidersQuery;
        }

        public string getString()
        {
            return "String kao deluje lol";
        }

        public CodPlace test()
        {
            return _getProviderQuery.execute();
        }
    }
}
