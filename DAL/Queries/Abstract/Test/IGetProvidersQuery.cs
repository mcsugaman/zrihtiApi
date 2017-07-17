using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Queries.Abstract.Test
{
    public interface IGetProvidersQuery
    {
        CodPlace execute(); 
    }
}
