using System.Windows.Forms;
using System.Xml;
using System;
using net.openstack.Core.Domain;
using System.Collections.Generic;

namespace TestOpenStack
{
    public partial class Form1 : Form
    {
        private connect connexion;
        private Glance G;
        private Nova N;

        public Form1()
        {
            InitializeComponent();
            connectToServer();
        }

        public void connectToServer()
        {
            // création de l'objet XML et chargement du fichier de configuration
            XmlDocument docXml = new XmlDocument();
            docXml.Load("config.xml");

            // lecture du fichier de configuration XML
            // /!\ Ne prend qu'une seul configuration pour le moment /!\
            try
            {
                XmlNodeList listInfra = docXml.GetElementsByTagName("infra");
                for (int i = 0; i < listInfra.Count; i++)
                {
                    string URI = listInfra[i].ChildNodes[0].InnerXml;
                    string login = listInfra[i].ChildNodes[1].InnerXml;
                    string password = listInfra[i].ChildNodes[2].InnerXml;
                    string project = listInfra[i].ChildNodes[3].InnerXml;

                    connexion = new connect(URI, login, password, project);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // fonction de création des interfaces
            //glanceInterface();
            novaInterface();

        }

        public void glanceInterface()
        {
            G = new Glance();
            G.Visible = true;
            SM_affiche_glance.Checked = true;
        }

        public void novaInterface()
        {
            N = new Nova();
            N.Visible = true;
            SM_affiche_nova.Checked = true;
        }

        private void changeStateNova(object sender, System.EventArgs e)
        {
            if(N.Visible == true)
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