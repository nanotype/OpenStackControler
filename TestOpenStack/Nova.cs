using OpenStack;
using OpenStack.Compute.v2_1;
using OpenStack.Networking.v2;
using System;
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
            listVM();
        }

        public async void listVM()
        {
            try
            {
                //DGV_listVM.Rows.Clear();
                IPage<Server> listServer = await compute.ListServersAsync();
                DataGridView newDGV = DGV_listVM;
                newDGV.Rows.Clear();
                foreach (Server server in listServer)
                {
                    try
                    {
                        newDGV.Rows.Add(server.Id, GetImageVmStatus(server.Status.DisplayName), server.Name);
                    }
                    catch (Exception ex) { }
                }
                try
                {
                    int idxRowSelected = DGV_listVM.FirstDisplayedScrollingRowIndex;
                    DGV_listVM = newDGV;
                    DGV_listVM.FirstDisplayedScrollingRowIndex = idxRowSelected;
                }
                catch (Exception ex) { }
            }
            catch (Exception ex){ }
        }

        private async void B_suppr_VM_Click(object sender, EventArgs e)
        {
            /* message de confirmation */
            /*DialogResult result = MessageBox.Show("Attention, vous etes sur le point de supprimer une instance d'un serveur." + '\n' + "Voulez vous vraiment la supprimer ?", "Demande de suppression d'instance virtuelle", MessageBoxButtons.YesNo);

             if (result == DialogResult.Yes)
             {
                 Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
                 await server.DeleteAsync();
             }*/
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            confirmationSuppression confirmSuppress = new confirmationSuppression(server);
            confirmSuppress.ShowDialog();
            //confirmSuppress.Visible = true;
        }

        private void B_ajout_VM_Click(object sender, EventArgs e)
        {
            preCreationInstance PCI = new preCreationInstance();
            PCI.Visible = true;
        }

        private async void B_VM_Start_Click(object sender, EventArgs e)
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

        private async void consoleInterface(Server s)
        {
            try
            {
                if (s.Status == ServerStatus.Active)
                {
                    RTB_console.Text = await s.GetConsoleOutputAsync();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private async void B_stop_Click(object sender, EventArgs e)
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

        private async void B_resume_Click(object sender, EventArgs e)
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

        private async void B_suspend_Click(object sender, EventArgs e)
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

        private async void B_reboot_Click(object sender, EventArgs e)
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
            catch (Exception ex) { }

            try
            {
                L_created.Text = server.Created.Value.ToString();
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
                L_connected.Text = traduitEtatVM(server.Status.DisplayName);
            }
            catch (Exception ex)
            {
                L_connected.Text = "Non renseigné";
            }

            try
            {
                L_lastExec.Text = server.Launched.Value.ToString();
            }
            catch (Exception ex)
            {
                L_lastExec.Text = "Non rensigné";
            }

            try
            {
                consoleInterface(server);
            }
            catch (Exception ex) { }

            try
            {
                DataGridView DGV_actionVm_tmp = DGV_actionVm;

                IEnumerable<ServerActionSummary> listActions = await server.ListActionSummariesAsync();
                int idxRowSelected = DGV_actionVm.FirstDisplayedScrollingRowIndex;
                DGV_actionVm_tmp.Rows.Clear();

                foreach (ServerActionSummary action in listActions)
                {
                    DGV_actionVm_tmp.Rows.Add(action.Name, action.Started);
                }

                DGV_actionVm = DGV_actionVm_tmp;
                DGV_actionVm.FirstDisplayedScrollingRowIndex = idxRowSelected;
            }
            catch (Exception ex) { }
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

        private async void refreshJournal(object sender, EventArgs e)
        {
            if (DGV_listVM.Rows.Count > 0)
            {
                try
                {
                    //sauvegarde du scrollBar pour eviter le retour en haut
                    RichTextBoxScrollBars scrollSaved = RTB_console.ScrollBars;

                    //récupération et affichage dans l'interface
                    Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
                    consoleInterface(server);

                    //renvois du scrollBar
                    RTB_console.ScrollBars = scrollSaved;

                }
                catch (Exception ex) { }
            }
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
                catch (Exception ex) { }

            }
        }

        private string traduitEtatVM(string etat)
        {
            string etatTraduit;

            switch (etat)
            {
                default:
                    etatTraduit = "Non connus";
                    gestionActivationBouton();
                    break;

                case "ACTIVE":
                    etatTraduit = "En fonctionnement";
                    gestionActivationBouton(false, true, true, false);
                    break;

                case "BUILD":
                    etatTraduit = "En construction";
                    gestionActivationBouton(false, false, false, false, false, false);
                    break;

                case "DELETED":
                    etatTraduit = "Suppression en cours";
                    gestionActivationBouton(false, false, false, false, false, false);
                    break;

                case "ERROR":
                    etatTraduit = "Erreur";
                    gestionActivationBouton(false, false, false, false, false);
                    break;

                case "HARD_REBOOT":
                    etatTraduit = "Redémarrage d'urgence en cours";
                    gestionActivationBouton(false, false, false, false, false, false);
                    break;

                case "MIGRATING":
                    etatTraduit = "Migration en cours";
                    gestionActivationBouton(false, false, false, false, false, false);
                    break;

                case "REBOOT":
                    etatTraduit = "Redémarrage en cours";
                    gestionActivationBouton(false, false, false, false, false, false);
                    break;

                case "SHUTOFF":
                    etatTraduit = "Arretée";
                    gestionActivationBouton(true, false, false, false, false);
                    break;

                case "SUSPENDED":
                    etatTraduit = "Suspendu";
                    gestionActivationBouton(false, false, false, true, false);
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
    }
}