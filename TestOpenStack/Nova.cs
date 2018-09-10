using MySql.Data.MySqlClient;
using OpenStack;
using OpenStack.Compute.v2_1;
using OpenStack.Networking.v2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TestOpenStack
{
    public partial class Nova : Form
    {
        private ComputeService compute = new ComputeService(connect.GetConnection(), "regionOne");
        private NetworkingService networking = new NetworkingService(connect.GetConnection(), "regionOne");

        public Nova()
        {
            InitializeComponent();
            refreshListCommande();
        }

        public async void listVM()
        {
            try
            {
                IPage<Server> listServer = await compute.ListServersAsync();
                DataGridView newDGV = DGV_listVM;
                Identifier selectedServerID = null;
                if (DGV_listVM.Rows.Count > 0)
                {
                    selectedServerID = (Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value;
                }
                newDGV.Rows.Clear();
                foreach (Server server in listServer)
                {
                    try
                    {
                        newDGV.Rows.Add(server.Id, GetImageVmStatus(server.Status.DisplayName), server.Name);
                        if (selectedServerID != null && selectedServerID.Equals(server.Id))
                        {
                            newDGV.Rows[newDGV.Rows.GetLastRow(DataGridViewElementStates.None)].Selected = true;
                        }
                    }
                    catch (Exception ex) { }
                }
                try
                {
                    DGV_listVM = newDGV;
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
            }
        }

        private async void B_suppr_VM_Click(object sender, EventArgs e)
        {
            /* message de confirmation */
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            confirmationSuppression confirmSuppress = new confirmationSuppression(server);
            confirmSuppress.ShowDialog();
        }

        private void B_ajout_VM_Click(object sender, EventArgs e)
        {
            preCreationInstance PCI = new preCreationInstance();
            PCI.Visible = true;
        }

        private async void B_VM_Start_Click(object sender, EventArgs e)
        {
            gestionActivationBouton(false, false, false, false, false, false);

            connect.GetMysqlConnection().Open();
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            try
            {
                MySqlCommand ecriture = new MySqlCommand($"INSERT INTO instanceOccupee VALUE ('{((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value).ToString()}', 'ACTIVE')", connect.GetMysqlConnection());
                ecriture.ExecuteNonQuery();
                await server.StartAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("l'erreur suivante s'est produite :" + '\n' + ex.Message);
            }
            connect.GetMysqlConnection().Close();
        }

        private async void B_stop_Click(object sender, EventArgs e)
        {
            gestionActivationBouton(false, false, false, false, false, false);

            connect.GetMysqlConnection().Open();
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            try
            {
                MySqlCommand ecriture = new MySqlCommand($"INSERT INTO instanceOccupee VALUE ('{((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value).ToString()}', 'SHUTOFF')", connect.GetMysqlConnection());
                ecriture.ExecuteNonQuery();
                await server.StopAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("l'erreur suivante s'est produite :" + '\n' + ex.Message);
            }
            connect.GetMysqlConnection().Close();
        }

        private async void B_resume_Click(object sender, EventArgs e)
        {
            gestionActivationBouton(false, false, false, false, false, false);

            connect.GetMysqlConnection().Open();
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            try
            {
                MySqlCommand ecriture = new MySqlCommand($"INSERT INTO instanceOccupee VALUE ('{((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value).ToString()}', 'ACTIVE')", connect.GetMysqlConnection());
                ecriture.ExecuteNonQuery();
                await server.ResumeAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("l'erreur suivante s'est produite :" + '\n' + ex.Message);
            }
            connect.GetMysqlConnection().Close();
        }

        private async void B_suspend_Click(object sender, EventArgs e)
        {
            gestionActivationBouton(false, false, false, false, false, false);

            connect.GetMysqlConnection().Open();
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            try
            {
                MySqlCommand ecriture = new MySqlCommand($"INSERT INTO instanceOccupee VALUE ('{((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value).ToString()}', 'SUSPENDED')", connect.GetMysqlConnection());
                ecriture.ExecuteNonQuery();
                await server.SuspendAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("l'erreur suivante s'est produite :" + '\n' + ex.Message);
            }
            connect.GetMysqlConnection().Close();
        }

        private async void B_reboot_Click(object sender, EventArgs e)
        {
            gestionActivationBouton(false, false, false, false, false, false);

            connect.GetMysqlConnection().Open();
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            try
            {
                await server.RebootAsync();
                MySqlCommand ecriture = new MySqlCommand($"INSERT INTO instanceOccupee VALUE ('{((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value).ToString()}', 'ACTIVE')", connect.GetMysqlConnection());
                ecriture.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("l'erreur suivante s'est produite :" + '\n' + ex.Message);
            }
            connect.GetMysqlConnection().Close();
        }

        private async void load_VM_Information(Server server)
        {
            try
            {
                IList<ServerVolumeReference> listVolumeReference = server.AttachedVolumes;
                foreach (ServerVolumeReference volumeReference in listVolumeReference)
                {
                    LB_volume.Items.Clear();
                    Volume V = await compute.GetVolumeAsync(volumeReference.Id);
                    LB_volume.Items.Add(V.Name);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            try
            {
                L_created.Text = server.Created.Value.DateTime.ToString();
            }
            catch (Exception ex) { L_created.Text = "Non renseigné"; }

            try
            {
                L_configDisk.Text = server.DiskConfig.DisplayName;
            }
            catch (Exception ex) { L_configDisk.Text = "Non renseigné"; }

            //récupérer le flavor
            try
            {
                Flavor F = await compute.GetFlavorAsync(server.Flavor.Id);
                L_flavor.Text = F.Name;
            }
            catch (Exception ex) { L_flavor.Text = "Non rensigné"; }

            try
            {
                L_id.Text = server.Id.ToString();
            }
            catch (Exception ex) { L_id.Text = "Non rensigné"; }

            //récupérer l'image
            try
            {
                OpenStack.Compute.v2_1.Image I = await compute.GetImageAsync(server.Image.Id);
                L_image.Text = I.Name;
            }
            catch (Exception ex) { L_image.Text = "Non renseigné"; }

            try
            {
                //L_IPV4.Text = server.IPv4Address;
                L_IPV4.Text = server.Addresses["provider"][0].IP;
            }
            catch (Exception ex) { L_IPV4.Text = "Non renseigné"; }

            try
            {
                L_IPV6.Text = server.Addresses["provider"][0].MAC;
            }
            catch (Exception ex) { L_IPV6.Text = "Non rensigné"; }

            try
            {
                L_nom.Text = server.Name;
            }
            catch (Exception ex) { L_nom.Text = "Non renseigné"; }

            try
            {
                L_progress.Text = server.Progress.ToString();
            }
            catch (Exception ex)
            {
                L_progress.Text = "Non renseigné";
            }

            try
            {
                //L_connected.Text = server.Status.DisplayName;
                L_connected.Text = traduitEtatVM(server.Status.DisplayName, server.Id.ToString());
            }
            catch (Exception ex)
            {
                L_connected.Text = "Non renseigné";
            }

            //appel de la fonction de blocage de la VM car elle est occupée
            //gestionOccupation(server.Id.ToString());

            try
            {
                L_lastExec.Text = server.Launched.Value.DateTime.ToString();
            }
            catch (Exception ex)
            {
                L_lastExec.Text = "Non rensigné";
            }

            /*try
            {
                consoleInterface(server);
            }
            catch (Exception ex) { }*/

            try
            {
                DataGridView DGV_actionVm_tmp = DGV_actionVm;

                IEnumerable<ServerActionSummary> listActions = await server.ListActionSummariesAsync();
                int idxRowSelected = DGV_actionVm.FirstDisplayedScrollingRowIndex;
                DGV_actionVm_tmp.Rows.Clear();

                foreach (ServerActionSummary action in listActions)
                {
                    DGV_actionVm_tmp.Rows.Add(action.Name, action.Started.DateTime);
                }

                DGV_actionVm = DGV_actionVm_tmp;
                DGV_actionVm.FirstDisplayedScrollingRowIndex = idxRowSelected;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private async void selectVM(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_listVM.SelectedRows != null)
            {
                //on demande au serveur de nous renvoyer le serveur grace à son identifiant
                Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);

                load_VM_Information(server);
            }
        }

        private void refresh_list_VM(object sender, EventArgs e)
        {
            listVM();
        }

        private async void refreshInterface(object sender, EventArgs e)
        {
            if (DGV_listVM.SelectedRows != null)
            {
                //on demande au serveur de nous renvoyer le serveur grace à son identifiant
                try
                {

                    Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
                    load_VM_Information(server);

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }

            }
        }

        private string traduitEtatVM(string etat, string idInstance)
        {
            string etatTraduit;

            switch (etat)
            {
                default:
                    etatTraduit = "Non connus";
                    //gestionActivationBouton();
                    gestionOccupation(idInstance);
                    break;

                case "ACTIVE":
                    etatTraduit = "En fonctionnement";
                    //gestionActivationBouton(false, true, true, false);
                    gestionOccupation(idInstance, false, true, true, false);
                    break;

                case "BUILD":
                    etatTraduit = "En construction";
                    //gestionActivationBouton(false, false, false, false, false, false);
                    gestionOccupation(idInstance, false, false, false, false, false, false);

                    break;

                case "DELETED":
                    etatTraduit = "Suppression en cours";
                    //gestionActivationBouton(false, false, false, false, false, false);
                    gestionOccupation(idInstance, false, false, false, false, false, false);
                    break;

                case "ERROR":
                    etatTraduit = "Erreur";
                    //gestionActivationBouton(false, false, false, false, false);
                    gestionOccupation(idInstance, false, false, false, false, false);
                    break;

                case "HARD_REBOOT":
                    etatTraduit = "Redémarrage d'urgence en cours";
                    //gestionActivationBouton(false, false, false, false, false, false);
                    gestionOccupation(idInstance, false, false, false, false, false, false);
                    break;

                case "MIGRATING":
                    etatTraduit = "Migration en cours";
                    //gestionActivationBouton(false, false, false, false, false, false);
                    gestionOccupation(idInstance, false, false, false, false, false, false);
                    break;

                case "REBOOT":
                    etatTraduit = "Redémarrage en cours";
                    //gestionActivationBouton(false, false, false, false, false, false);
                    gestionOccupation(idInstance, false, false, false, false, false, false);
                    break;

                case "SHUTOFF":
                    etatTraduit = "Arretée";
                    //gestionActivationBouton(true, false, false, false, false);
                    gestionOccupation(idInstance, true, false, false, false, false);
                    break;

                case "SUSPENDED":
                    etatTraduit = "Suspendu";
                    //gestionActivationBouton(false, false, false, true, false);
                    gestionOccupation(idInstance, false, false, false, true, false);
                    break;
            }

            return etatTraduit;
        }

        private Bitmap GetImageVmStatus(string etat)
        {
            Bitmap imageStatus = null;

            switch (etat)
            {
                default:
                    imageStatus = Properties.Resources.icon_error;
                    break;

                case "ACTIVE":
                    imageStatus = Properties.Resources.icon_play;
                    break;

                case "BUILD":
                    imageStatus = Properties.Resources.icon_reboot;
                    break;

                case "DELETED":
                    imageStatus = Properties.Resources.icon_delete;
                    break;

                case "ERROR":
                    imageStatus = Properties.Resources.icon_error;
                    break;

                case "HARD_REBOOT":
                    imageStatus = Properties.Resources.icon_reboot;
                    break;

                case "REBOOT":
                    imageStatus = Properties.Resources.icon_reboot;
                    break;

                case "SHUTOFF":
                    imageStatus = Properties.Resources.icon_stop;
                    break;

                case "SUSPENDED":
                    imageStatus = Properties.Resources.icon_pause;
                    break;
            }

            return imageStatus;
        }

        private void gestionActivationBouton(bool start = true, bool reboot = true, bool stop = true, bool resume = true, bool suspend = true, bool delete = true)
        {
            B_VM_Start.Enabled = start;
            B_reboot.Enabled = reboot;
            B_stop.Enabled = stop;
            B_resume.Enabled = resume;
            B_suspend.Enabled = suspend;
            B_suppr_VM.Enabled = delete;
        }

        private async void gestionOccupation(string idInstance, bool start = true, bool reboot = true, bool stop = true, bool resume = true, bool suspend = true, bool delete = true)
        {
            try
            {
                connect.GetMysqlConnection().Open();
            }
            catch (Exception ex) { }
            try
            {
                MySqlCommand lecture = new MySqlCommand($"SELECT * FROM instanceOccupee WHERE ID_instance like \"{idInstance}\"", connect.GetMysqlConnection());
                MySqlDataReader reader = lecture.ExecuteReader();

                string ID_instance = "";
                string etatRecherche = "";
                while (reader.Read())
                {
                    ID_instance = reader.GetString("ID_instance");
                    etatRecherche = reader.GetString("etatRecherche");
                }
                reader.Close();

                Server server = await compute.GetServerAsync(ID_instance);
                if (server.Status.DisplayName == etatRecherche)
                {
                    MySqlCommand suppression = new MySqlCommand($"DELETE FROM instanceOccupee WHERE ID_instance like \"{ID_instance}\"", connect.GetMysqlConnection());
                    suppression.ExecuteNonQuery();
                    gestionActivationBouton(start, reboot, stop, resume, suspend, delete);
                }
                else
                {
                    gestionActivationBouton(false, false, false, false, false, false);
                }
            }
            catch (Exception ex)
            {
                gestionActivationBouton(start, reboot, stop, resume, suspend, delete);
            }

            try
            {
                connect.GetMysqlConnection().Close();
            }
            catch (Exception ex) { }
        }

        private void Nova_Activated(object sender, EventArgs e)
        {
            T_refresh_interface.Enabled = true;
            T_refresh_VM.Enabled = true;
        }

        private async void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            try
            {
                await server.StartAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("l'erreur suivante s'est produite :" + '\n' + ex.Message);
            }
        }

        private async void arreterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            try
            {
                await server.StopAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("l'erreur suivante s'est produite :" + '\n' + ex.Message);
            }
        }

        private async void redémarerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            try
            {
                await server.RebootAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("l'erreur suivante s'est produite :" + '\n' + ex.Message);
            }
        }

        private async void reprendreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            try
            {
                await server.ResumeAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("l'erreur suivante s'est produite :" + '\n' + ex.Message);
            }
        }

        private async void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            try
            {
                await server.SuspendAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("l'erreur suivante s'est produite :" + '\n' + ex.Message);
            }
        }

        private async void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* message de confirmation */
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            confirmationSuppression confirmSuppress = new confirmationSuppression(server);
            confirmSuppress.ShowDialog();
        }

        private void T_refresh_listCommande_Tick(object sender, EventArgs e)
        {
            refreshListCommande();
        }

        private void refreshListCommande()
        {
            string writeDGV, nomPrenom="", numCommande_tmp="";
            MySqlConnection MysqlClone = (MySqlConnection)connect.GetMysqlConnection().Clone();//test de fonctionnement : on clone la connection pour voir si on évite les bug de connexion à la BDD
            MysqlClone.Open();//on ouvre la connexion du clone

            //on récupère la liste des commandes pour savoir combien nous en avons à traiter 
            //(ce sera utile plus tard pour faire des requete commande par commande ; C'est plus facile à mettre en place et moins chiant bien que cela augmente le nombre de requete SQL mais vu qu'on en récupère peu ce n'est pas un problème)
            MySqlCommand recupData_listCommande = new MySqlCommand("SELECT `id_commande` FROM `commande_recap` GROUP BY `id_commande` ORDER BY `id_commande`", MysqlClone);
            MySqlDataReader recupData_listCommande_reader = recupData_listCommande.ExecuteReader();
            ArrayList arrayListCommande = new ArrayList();
            while (recupData_listCommande_reader.Read())
            {
                arrayListCommande.Add(recupData_listCommande_reader.GetInt32("id_commande"));
            }
            recupData_listCommande_reader.Close();

            DataGridView virtualDGV = DGV_listCommande;
            int selectedLineID=-1;
            if (virtualDGV.Rows.Count > 0)
            {
                selectedLineID = (int)DGV_listCommande.SelectedRows[0].Cells[0].Value;
            }
            virtualDGV.Rows.Clear();
            //on fait les requete pour chaque commande payée prete à etre executée
            foreach (int commande in arrayListCommande)
            {
                writeDGV = "";
                recupData_listCommande = new MySqlCommand($"SELECT * FROM `commande_recap` WHERE `id_commande` = {commande} ORDER BY `id_commande`", MysqlClone);
                recupData_listCommande_reader = recupData_listCommande.ExecuteReader();
                while (recupData_listCommande_reader.Read())
                {
                    numCommande_tmp = recupData_listCommande_reader.GetString("numCommande");
                    nomPrenom = "Client : \n" + recupData_listCommande_reader.GetString("nom") + " " + recupData_listCommande_reader.GetString("prenom")+"\n\n";
                    writeDGV += $"     Gabarit : {recupData_listCommande_reader.GetString("nom_gabarit")}\n";
                    writeDGV += $"     Produit : {recupData_listCommande_reader.GetString("nomProduit")}\n";
                    writeDGV += $"     CPU : {recupData_listCommande_reader.GetString("CPU")}\n";
                    writeDGV += $"     RAM : {recupData_listCommande_reader.GetString("RAM")}\n";
                    writeDGV += $"     Disque : {recupData_listCommande_reader.GetString("disque")}\n";
                    writeDGV += $"     OS : {recupData_listCommande_reader.GetString("OS")}\n";
                    writeDGV += $"     Quantite : {recupData_listCommande_reader.GetString("quantite")}\n\n";
                }
                writeDGV = nomPrenom + writeDGV;
                DGV_listCommande.Rows.Add(commande, numCommande_tmp.Clone(), writeDGV.Clone());
                if (selectedLineID != -1 && selectedLineID.Equals(commande))
                {
                    virtualDGV.Rows[virtualDGV.Rows.GetLastRow(DataGridViewElementStates.None)].Selected = true;
                }
                recupData_listCommande_reader.Close();
            }
            DGV_listCommande = virtualDGV;
            MysqlClone.Close();//on ferme le clone
        }

        private async void DGV_listCommande_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Identifier imageID=null, flavorID=null, networkID=null;
            MySqlCommand updateCommande;
            int commandeId = (int)DGV_listCommande.Rows[e.RowIndex].Cells[0].Value;
            int nombreInstanceACreer;
            int numeroSerieInstance = 1;
            string nomInstance, nomGabarit, nomOS;
            int idCommande;

            MySqlConnection MysqlUpdate;

            MySqlConnection MysqlClone = (MySqlConnection)connect.GetMysqlConnection().Clone();//test de fonctionnement : on clone la connection pour voir si on évite les bug de connexion à la BDD
            MysqlClone.Open();//on ouvre la connexion du clone

            MySqlCommand recupData_commande = new MySqlCommand($"SELECT * FROM commande_recap WHERE id_commande = {commandeId} ORDER BY id_commande", MysqlClone);
            MySqlDataReader recupData_commande_reader = recupData_commande.ExecuteReader();
            while (recupData_commande_reader.Read())
            {
                idCommande = recupData_commande_reader.GetInt32("id_commande");
                //préparation des variables d'un des composants de la commande
                nomInstance = recupData_commande_reader.GetString("numCommande") + "_" + recupData_commande_reader.GetString("nom") + recupData_commande_reader.GetString("prenom");
                nomGabarit = recupData_commande_reader.GetString("nom_gabarit");//necessaire pour récupérer le flavor openstack
                nomOS = recupData_commande_reader.GetString("OS");//necessaire pour récupérer l'identifier de l'OS openstack

                //recuperation du nombre d'instance a créer pour un même produit
                nombreInstanceACreer = recupData_commande_reader.GetInt32("quantite");

                for (int index = 1; index <= nombreInstanceACreer; index++)
                {
                    //recherche de l'image
                    ImageListOptions searchingOption_image = new ImageListOptions();
                    searchingOption_image.Name = nomOS;
                    IPage<OpenStack.Compute.v2_1.Image> listImage = await compute.ListImagesAsync(searchingOption_image);
                    foreach(OpenStack.Compute.v2_1.Image image in listImage)
                    {
                        imageID = image.Id;
                    }

                    //recherche du gabarit
                    IPage<Flavor> listFalvor = await compute.ListFlavorsAsync();
                    foreach(Flavor flavor in listFalvor)
                    {
                        if (flavor.Name == nomGabarit)
                        {
                            flavorID = flavor.Id;
                        }
                    }

                    //recherche du réseau
                    IEnumerable<Network> listNetwork = await networking.ListNetworksAsync();
                    foreach(Network network in listNetwork)
                    {
                        networkID = network.Id;
                    }
                    IList<ServerNetworkDefinition> listNetworkDefinition = new List<ServerNetworkDefinition>();
                    ServerNetworkDefinition server_networkDefinition = new ServerNetworkDefinition();
                    server_networkDefinition.NetworkId = networkID;
                    listNetworkDefinition.Add(server_networkDefinition);

                    //on a toutes les données : on a plus qu'à créer l'instance avec demande de confirmation
                    DialogResult dialogResult = MessageBox.Show(
                        $@"Vous vous appretez à créer une nouvelle instance avec les caratèristiques suivante :
Nom de l'instance : {nomInstance + "_" + numeroSerieInstance}
Image : {nomOS}
Flavor : {nomGabarit}", 
                        "Création d'instance N°"+numeroSerieInstance, 
                        MessageBoxButtons.YesNoCancel);//affichage du message de confirmation
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            ServerCreateDefinition serverDefinition = new ServerCreateDefinition(nomInstance+"_"+numeroSerieInstance, imageID, flavorID);
                            serverDefinition.Networks = listNetworkDefinition;

                            /*changement statut en cours à faire*/
                            MysqlUpdate = (MySqlConnection)connect.GetMysqlConnection().Clone();//test de fonctionnement : on clone la connection pour voir si on évite les bug de connexion à la BDD
                            MysqlUpdate.Open();//on ouvre la connexion du clone
                            updateCommande = new MySqlCommand($"UPDATE `commande` SET `statut` = 'En cours' WHERE `commande`.`id` = {idCommande};", MysqlUpdate);
                            updateCommande.ExecuteNonQuery();
                            MysqlUpdate.Close();
                            /* fin changement statut */

                            refreshListCommande();

                            await compute.CreateServerAsync(serverDefinition);
                            break;

                        case DialogResult.No:
                            break;

                        case DialogResult.Cancel:
                            return;
                    }
                    numeroSerieInstance++;
                }
            }
            MysqlClone.Close();
        }

        private void rafraichirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshListCommande();
        }
    }
}