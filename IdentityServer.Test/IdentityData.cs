using System;
using System.Collections.Generic;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace IdentityServer.Test
{
    public class IdentityData
    {
        public static IEnumerable<ApiResource> GetResources()
        {
            return new List<ApiResource>()
            {
                new ApiResource("api1","api1 Display Name")
            };
        }

        internal static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client()
                {
                    ClientId="Postman",
                    ClientSecrets=new []{new Secret("secret".ToSha256())}
                }
            };
        }

        internal static List<TestUser> GetUsers()
        {
            return new List<TestUser>()
            {
                new TestUser()
                {
                    Password="P@$$w0rd",
                    Username="user",
                    SubjectId = "1",
                }
            };
        }
    }
}