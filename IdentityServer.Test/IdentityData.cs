using System;
using System.Collections.Generic;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;
using static IdentityServer4.IdentityServerConstants;

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

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client()
                {
                    ClientId="Postman",
                    ClientSecrets=new []{new Secret("secret".ToSha256())},
                    AllowedGrantTypes=GrantTypes.ImplicitAndClientCredentials,
                    AllowedScopes=new []{ "api1"}
                },
                new Client
                {
                    ClientId = "mvc",
                    ClientName = "MVC Client",

                    AllowedGrantTypes = GrantTypes.Implicit,

                    RedirectUris = { "https://localhost:6001/signin-oidc" },
                    PostLogoutRedirectUris = { "https://localhost:6001/signout-callback-oidc" },

                    AllowedScopes = new List<string>
                    {
                        StandardScopes.OpenId,
                        StandardScopes.Profile
                    },
                }
            };
        }

        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>()
            {
                new TestUser()
                {
                    Password="P@$$w0rd",
                    Username="user",
                    SubjectId = "3534df2b-e7c6-43b7-8ed5-c39d7283800b",
                }
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
                {
                    new IdentityResources.OpenId(),
                    new IdentityResources.Profile(),

                };
        }
    }
}