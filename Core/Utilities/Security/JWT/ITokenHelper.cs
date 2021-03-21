using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //giriş yaptıktan sonra bu çalışacak jwt üretip onu verecek
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
