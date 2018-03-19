using System.Windows.Forms;
using System.Xml;
using System;
using net.openstack.Core.Domain;
using System.Drawing;

namespace TestOpenStack
{
    public partial class Form1 : Form
    {
        private connect connexion;
        private Glance G;
        private Nova N;

        public Form1(connect connection)
        {
            InitializeComponent();
            connexion = connection;
            connectToServer();
        }

        public void connectToServer()
        {
            // fonction de création des interfaces
            glanceInterface();
            novaInterface();
        }

        public void glanceInterface()
        {
            G = new Glance();
            G.Visible = false;
            SM_affiche_glance.Checked = false;
        }

        public void novaInterface()
        {
            //N.Visible = true;
            // ferme toutes les fenetres MdiChild active et amène le panel d'accueil au dernier plan

            if (ActiveMdiChild != null) ActiveMdiChild.Close();

            N = new Nova();
            N.TopLevel = false;
            N.Parent = P_interface;
            N.TopLevel = false;
            N.Size = P_interface.ClientSize;
            N.Dock = DockStyle.Fill;
            N.BringToFront();
            N.Show();
            N.Location = new Point(0, 0);

            SM_affiche_nova.Checked = true;
        }

        private void changeStateNova(object sender, System.EventArgs e)
        {
            if (N.Visible == true)
            {
                //si la fenetre de nova est visible, on la cache
                N.Close();
                N.Visible = false;
                SM_affiche_nova.Checked = false;
            }
            else
            {
                //sinon on l'affiche
                N = new Nova();
                N.Visible = true;
                SM_affiche_nova.Checked = true;
            }
        }

        private void changeStateGlance(object sender, System.EventArgs e)
        {
            if (G.Visible == true)
            {
                //si la fenetre de nova est visible, on la cache
                G.Close();
                G.Visible = false;
                SM_affiche_glance.Checked = false;
            }
            else
            {
                //sinon on l'affiche
                G = new Glance();
                G.Visible = true;
                SM_affiche_glance.Checked = true;
            }
        }

        private void verrifWindowsOpen(object sender, EventArgs e)
        {
            //Nova
            if (N == null || N.Visible == false)
            {
                //si la fenetre de nova n'est pas visible, on décoche la case
                SM_affiche_nova.Checked = false;
            }

            //Glance
            if (G == null || G.Visible == false)
            {
                //si la fenetre de Glance n'est pas visible, on décoche la case
                SM_affiche_glance.Checked = false;
            }
        }

        private void fonctionTest()
        {
            MessageBox.Show(ServerState.Active + "/" + ServerState.Build + "/" + ServerState.Deleted + "/" + ServerState.Error + "/" + ServerState.HardReboot + "/" + ServerState.Migrating + "/" + ServerState.Password + "/" + ServerState.Reboot + "/" + ServerState.Rebuild + "/" + ServerState.Suspended);
        }
    }
}