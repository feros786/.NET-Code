using Contraly.Portal.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contraly.Portal.Business.Interfaces
{
    public interface ITokenService
    {
        string Generate(User user);
    }
}
