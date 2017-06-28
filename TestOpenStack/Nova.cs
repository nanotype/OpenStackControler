using OpenStack;
using OpenStack.Compute.v2_1;
using OpenStack.Networking.v2;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestOpenStack
{
    public partial class Nova : Form
    {
        private ComputeService compute = new ComputeService(connect.GetConnection(),"regionOne",true);
        private NetworkingService networking = new NetworkingService(connect.GetConnection(), "regionOne");

        public Nova()
        {
            InitializeComponent();
            listVM();
        }

        public async void listVM()
        {
            DGV_listVM.Rows.Clear();
            IPage<Server> listServer = await compute.ListServersAsync();
            foreach(Server server in listServer)
            {
                DGV_listVM.Rows.Add(server.Id, server.Name);
            }
        }

        private async void B_suppr_VM_Click(object sender, EventArgs e)
        {
            /* message de confirmation */

            /* fin message de confirmation */

            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            await server.DeleteAsync();
        }

        private void B_ajout_VM_Click(object sender, EventArgs e)
        {
            preCreationInstance PCI = new preCreationInstance();
            PCI.Visible = true;
        }

        private void B_modif_VM_Click(object sender, EventArgs e)
        {

        }

        private void active_suppression(object sender, EventArgs e)
        {
            if(TBar_deverouille.Value == TBar_deverouille.Maximum)
            {
                B_suppr_VM.Enabled = true;
            }
            else
            {
                B_suppr_VM.Enabled = false;
            }
        }

        private void Nova_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private async void B_VM_Start_Click(object sender, EventArgs e)
        {
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            await server.StartAsync();
        }

        private async void consoleInterface(Server s)
        {
            try
            {
                if (s.Status == ServerStatus.Active)
                {
                    RTB_console.Text = await s.GetConsoleOutputAsync();
                }
            }catch(Exception ex)
            {

            }
        }

        private async void B_stop_Click(object sender, EventArgs e)
        {
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            await server.StopAsync();
        }

        private async void B_resume_Click(object sender, EventArgs e)
        {
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            await server.ResumeAsync();
        }

        private async void B_suspend_Click(object sender, EventArgs e)
        {
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            await server.SuspendAsync();
        }

        private async void B_reboot_Click(object sender, EventArgs e)
        {
            Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
            await server.RebootAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void selectVM(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_listVM.SelectedRows != null)
            {
                //on demande au serveur de nous renvoyer la liste des serveur suivant les options recherche spécifié
                Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);

                //MessageBox.Show("nom: " + server.Name + " // etat server: " + server.Status);

                IList<ServerVolumeReference> listVolumeReference = server.AttachedVolumes;
                foreach (ServerVolumeReference volumeReference in listVolumeReference)
                {
                    Volume V = await compute.GetVolumeAsync(volumeReference.Id);
                    LB_volume.Items.Add(V.Name);
                }

                L_created.Text = server.Created.Value.ToString();
                L_configDisk.Text = server.DiskConfig.DisplayName;

                //récupérer le flavor
                Flavor F = await compute.GetFlavorAsync(server.Flavor.Id);
                L_flavor.Text = F.Name;
                L_id.Text = server.Id.ToString();

                //récupérer l'image
                Image I = await compute.GetImageAsync(server.Image.Id);
                L_image.Text = I.Name;
                L_IPV4.Text = server.IPv4Address;
                L_IPV6.Text = server.IPv6Address;
                L_nom.Text = server.Name;
                L_progress.Text = server.Progress.ToString();
                if (!(server.Progress > 0))
                {
                    L_connected.Text = server.Status.DisplayName;
                    //L_lastExec.Text = server.Launched.Value.ToString();
                }
                consoleInterface(server);
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
                Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
                consoleInterface(server);
            }
        }
    }
}