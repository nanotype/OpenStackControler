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
        private ComputeService compute = new ComputeService(connect.GetConnection(),"regionOne");
        private NetworkingService networking = new NetworkingService(connect.GetConnection(), "regionOne");

        public Nova()
        {
            InitializeComponent();
            listVM();
        }

        public async void listVM()
        {
            //DGV_listVM.Rows.Clear();
            IPage<Server> listServer = await compute.ListServersAsync();
            DataGridView newDGV = DGV_listVM;
            newDGV.Rows.Clear();
            foreach (Server server in listServer)
            {
                newDGV.Rows.Add(server.Id, server.Name);
                //DGV_listVM.Rows.Add(server.Id, server.Name);
            }
            DGV_listVM = newDGV;
        }

        private async void B_suppr_VM_Click(object sender, EventArgs e)
        {
            /* message de confirmation */
            DialogResult result = MessageBox.Show("Attention, vous etes sur le point de supprimer une instance d'un serveur." + '\n' + "Voulez vous vraiment la supprimer ?", "Demande de suppression d'instance virtuelle", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
                await server.DeleteAsync();
            }

            TBar_deverouille.Value = 0;
        }

        private void B_ajout_VM_Click(object sender, EventArgs e)
        {
            preCreationInstance PCI = new preCreationInstance();
            PCI.Visible = true;
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

        private async void selectVM(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_listVM.SelectedRows != null)
            {
                //on demande au serveur de nous renvoyer la liste des serveur suivant les options recherche spécifié
                Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
                //MessageBox.Show("nom: " + server.Name + " // etat server: " + server.Status);
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
                catch (Exception ex){}

                try{
                    L_created.Text = server.Created.Value.ToString();
                }catch (Exception ex)
                {
                    L_created.Text = "Non renseigné";
                }

                try{
                    L_configDisk.Text = server.DiskConfig.DisplayName;
                }catch (Exception ex)
                {
                    L_configDisk.Text = "Non renseigné";
                }

                //récupérer le flavor
                try
                {
                    Flavor F = await compute.GetFlavorAsync(server.Flavor.Id);
                    L_flavor.Text = F.Name;
                }catch(Exception ex)
                {
                    L_flavor.Text = "Non rensigné";
                }

                try
                {
                    L_id.Text = server.Id.ToString();
                }catch(Exception ex)
                {
                    L_id.Text = "Non rensigné";
                }

                //récupérer l'image
                try
                {
                    Image I = await compute.GetImageAsync(server.Image.Id);
                    L_image.Text = I.Name;
                }catch(Exception ex)
                {
                    L_image.Text = "Non renseigné";
                }

                try
                {
                    L_IPV4.Text = server.IPv4Address;
                }catch(Exception ex)
                {
                    L_IPV4.Text = "Non renseigné";
                }

                try
                {
                    L_IPV6.Text = server.IPv6Address;
                }catch(Exception ex)
                {
                    L_IPV6.Text = "Non rensigné";
                }

                try
                {
                    L_nom.Text = server.Name;
                }catch(Exception ex)
                {
                    L_nom.Text = "Non renseigné";
                }

                try
                {
                    L_progress.Text = server.Progress.ToString();
                }catch(Exception ex)
                {
                    L_progress.Text = "Non renseigné";
                }

                try
                {
                    L_connected.Text = server.Status.DisplayName;
                }catch(Exception ex)
                {
                    L_connected.Text = "Non renseigné";
                }

                try
                {
                    L_lastExec.Text = server.Launched.Value.ToString();
                }catch(Exception ex)
                {
                    L_lastExec.Text = "Non rensigné";
                }

                try
                {
                    consoleInterface(server);
                }catch(Exception ex){}

                TBar_deverouille.Value = 0;
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
                    Server server = await compute.GetServerAsync((Identifier)DGV_listVM.SelectedRows[0].Cells[0].Value);
                    consoleInterface(server);
                }catch(Exception ex){}
            }
        }
    }
}