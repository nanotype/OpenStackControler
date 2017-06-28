using net.openstack.Core.Domain;
using net.openstack.Core.Providers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TestOpenStack
{
    class connect
    {
        private CloudIdentityWithProject serverConnection;
        private static OpenStackIdentityProvider OpenStackConnection;
        private static UserAccess UA;

        public connect(string URI, string login, string password, string project)
        {
            Uri serverLink = new Uri(URI);
            serverConnection = new CloudIdentityWithProject
            {
                Username = login,
                Password = password,
                ProjectName = project
                
            };

            authentification(serverLink);
        }

        private async void authentification(Uri serverLink)
        {
            OpenStackConnection = new OpenStackIdentityProvider(serverLink, serverConnection);
            try
            {
                UA = OpenStackConnection.Authenticate();
                //UA = await OpenStackConnection.AuthenticateAsync(new CloudIdentity(), new System.Threading.CancellationToken());

                ServiceCatalog[] SC = UA.ServiceCatalog;

                // 2. mise à jour du lien de connexion vers le service de networking
                var networkingEndpoint = UA.ServiceCatalog.Single(svc => svc.Type == "network")
                    .Endpoints.Single(e => e.Region == "RegionOne");
                networkingEndpoint.GetType().GetProperty("PublicURL")
                    .SetValue(networkingEndpoint, $"{networkingEndpoint.PublicURL}/v2.0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static OpenStackIdentityProvider GetConnection()
        {
            return OpenStackConnection;
        }

        public static IdentityToken GetIdentityToken()
        {
            return UA.Token;
        }
    }
}
