using net.openstack.Core.Domain;
using net.openstack.Core.Providers;
using System;
using System.Linq;
using MySql.Data.MySqlClient;

namespace TestOpenStack
{
    public class connect
    {
        //attribut de connexion OpenStack
        private CloudIdentityWithProject serverConnection;
        private static OpenStackIdentityProvider OpenStackConnection;
        private static UserAccess UA;
        public bool error=false;

        //attribut de connexion à la base de données
        private static MySqlConnection mySqlConnection;

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
            InitConnexionToMysql();
        }

        private void authentification(Uri serverLink)
        {
            OpenStackConnection = new OpenStackIdentityProvider(serverLink, serverConnection);
            try
            {
                UA = OpenStackConnection.Authenticate();
                //UA = await OpenStackConnection.AuthenticateAsync(new CloudIdentity(), new System.Threading.CancellationToken());

                ServiceCatalog[] SC = UA.ServiceCatalog;

                // mise à jour du lien de connexion vers le service de networking
                var networkingEndpoint = UA.ServiceCatalog.Single(svc => svc.Type == "network")
                    .Endpoints.Single(e => e.Region == "RegionOne");
                networkingEndpoint.GetType().GetProperty("PublicURL")
                    .SetValue(networkingEndpoint, $"{networkingEndpoint.PublicURL}/v2.0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                error = true;
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

        private void InitConnexionToMysql()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=openstack.tk; DATABASE=opensatc; user=root; PASSWORD=mgall";
            mySqlConnection = new MySqlConnection(connectionString);
        }

        public static MySqlConnection GetMysqlConnection()
        {
            return mySqlConnection;
        }
    }
}
