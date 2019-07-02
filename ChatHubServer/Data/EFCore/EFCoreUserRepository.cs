using ChatHubServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatHubServer.Data.EFCore
{
    public class EFCoreUserRepository : EfCoreRepository<User, UserContext>
    {
        public EFCoreUserRepository(UserContext context) : base(context)
        {

        }
    }
    // We can add new methods specific to the user repository here in the future
}
