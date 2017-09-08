using OpenStack;
using OpenStack.Compute.v2_1;
using OpenStack.Networking.v2;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestOpenStack
{
    public partial class preCreationInstance : Form
    {
        private ComputeService compute = new ComputeService(connect.GetConnection(), "regionOne");
        private NetworkingService networking = new NetworkingService(connect.GetConnection(), "regionOne");
        bool erreur=false;

        public preCreationInstance()
        {
            InitializeComponent();
            loading_DGVs();
        }

        private void B_cancel_creation_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void B_lunch_creation_Click(object sender, EventArgs e)
        {
            //declaration des variables
            Identifier imageID, flavorID;
            verrifDataBeforeCreation();
            if(!erreur)
            {
                // préparation des variables
                string name = TB_nom_VM.Text;
                imageID = (Identifier)DGV_image_dispo.SelectedRows[0].Cells[0].Value;
                flavorID = (Identifier)DGV_flavor_dispo.SelectedRows[0].Cells[0].Value;
                IList<ServerNetworkDefinition> listNetworkDefinition = listingNetworkChecked();

                ServerCreateDefinition serverDefinition = new ServerCreateDefinition(name,imageID,flavorID);
                serverDefinition.Networks = listNetworkDefinition;

                await compute.CreateServerAsync(serverDefinition);
                Close();
            }
        }

        private void loading_DGVs()
        {
            listImage();
            listFlavor();
            listNetwork();
        }

        private async void listImage()
        {
            IPage<Image> listImage = await compute.ListImagesAsync();
            foreach (Image image in listImage)
            {
                DGV_image_dispo.Rows.Add(image.Id, image.Name);
            }
        }

        private async void listFlavor()
        {
            IPage<Flavor> listFlavor = await compute.ListFlavorsAsync();
            foreach (Flavor flavor in listFlavor)
            {
                DGV_flavor_dispo.Rows.Add(flavor.Id, flavor.Name);
            }
        }

        private async void listNetwork()
        {
            IEnumerable<Network> listNetwork = await networking.ListNetworksAsync();
            foreach (Network network in listNetwork)
            {
                DGV_reseau_dispo.Rows.Add(network.Id, null, network.Name);
            }
        }

        private void verrifDataBeforeCreation()
        {
            //initialisation des variables de verrification d'erreur
            int nameError = 0, imageError = 0, flavorError = 0, reseauError = 0;
            string messageErreur = "Le système a relevé les erreurs d'utilisation suivantes :" + '\n';

            //gestion d'erreur du nom de l'instance
            if (TB_nom_VM.Text == "") // le nom de la VM n'est pas renseigné
            {
                messageErreur += "     - Vous n'avez pas renseigné le nom de l'instance à créer" + '\n';
                nameError = 1;
            }


            //gestion d'erreur pour la selection d'image
            if (DGV_image_dispo.SelectedRows[0] == null)
            {
                messageErreur += "     - Vous n'avez pas séléctionné d'image à utiliser pour créer l'instance" + '\n';
                imageError = 1;
            }


            //gestion d'erreur pour la selection de flavor
            if (DGV_flavor_dispo.SelectedRows[0] == null)
            {
                messageErreur += "     - Vous n'avez pas sélectionné de flavor à utiliser pour créer l'instance" + '\n';
                flavorError = 1;
            }

            //gestion d'erreur pour la selection de réseaux
            if (listingNetworkChecked() == null)
            {
                messageErreur += "     - Vous devez selectionner au moins un réseau disponible" + '\n';
                reseauError = 1;
            }

            //résumé des erreurs survenu et envois du message à l'utilisateur
            if (nameError > 0 || imageError > 0 || flavorError > 0 || reseauError > 0)
            {
                messageErreur += '\n' + "veuillez résoudre ces problèmes avant de pouvoir créer une instance." + '\n';
                erreur = true;
                MessageBox.Show(messageErreur, "ERREUR SYSTEME COUCHE 8");
            }
            else
            {
                erreur = false;
            }
        }

        private IList<ServerNetworkDefinition> listingNetworkChecked()
        {
            IList<ServerNetworkDefinition> listNetwork = new List<ServerNetworkDefinition>();
            for(int i = 0; i < DGV_reseau_dispo.Rows.Count; i++)
            {
                if (DGV_reseau_dispo.Rows[i].Cells[1].Value != null)
                {
                    ServerNetworkDefinition networkDefinition = new ServerNetworkDefinition();
                    networkDefinition.NetworkId = (Identifier)DGV_reseau_dispo.Rows[i].Cells[0].Value;

                    listNetwork.Add(networkDefinition);
                }
            }
            if (listNetwork.Count > 0)
            {
                return listNetwork;
            }

            return null;
        }
    }
}
