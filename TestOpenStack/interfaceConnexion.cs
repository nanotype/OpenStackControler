using System;
using System.Windows.Forms;
using System.Xml;

namespace TestOpenStack
{
    public partial class interfaceConnexion : Form
    {
        private string URI;
        private bool successfullConnection = false;
        private connect testConnexion;
        XmlDocument docXml;

        public interfaceConnexion()
        {
            InitializeComponent();
            loadSavedInformations();
        }

        private void loadSavedInformations()
        {
            // création de l'objet XML et chargement du fichier de configuration
            docXml = new XmlDocument();
            docXml.Load("config.xml");

            // lecture du fichier de configuration XML
            // /!\ Ne prend qu'une seul configuration pour le moment /!\
            try
            {
                XmlNodeList listInfra = docXml.GetElementsByTagName("infra");
                for (int i = 0; i < listInfra.Count; i++)
                {
                    URI = listInfra[i].ChildNodes[0].InnerXml;
                    TB_login.Text = listInfra[i].ChildNodes[1].InnerXml;
                    TB_password.Text = listInfra[i].ChildNodes[2].InnerXml;
                    TB_project.Text = listInfra[i].ChildNodes[3].InnerXml;
                }

                if(TB_login.Text!="" || TB_password.Text!="" || TB_project.Text != "")
                {
                    CB_saveInfo.Checked = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void B_launchConnection_Click(object sender, EventArgs e)
        {
            PB_waitingGIF.Visible = true;
            B_launchConnection.Visible = false;
            testConnexion = new connect(URI, TB_login.Text, TB_password.Text, TB_project.Text);
            if (testConnexion.error == false)
            {
                MessageBox.Show("Vous etes connecté" + "\n" + "Bienvenu.");
                if (CB_saveInfo.Checked)
                {
                    saveConnectionInformations(TB_login.Text, TB_password.Text, TB_project.Text);
                }
                successfullConnection = true;
                Close();
            }
            else
            {
                MessageBox.Show("Les informations renseignées lors de la connection sont incorrectes.", "Erreur Système Couche 8");
                PB_waitingGIF.Visible = false;
                B_launchConnection.Visible = true;
            }
        }

        private void connexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (successfullConnection == true)
            {
                DialogResult = DialogResult.Yes;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }

        public connect getConnection()
        {
            return testConnexion;
        }

        private void saveConnectionInformations(string login, string password, string project)
        {
            docXml.GetElementsByTagName("infra")[0].ChildNodes[1].InnerXml = login;
            docXml.GetElementsByTagName("infra")[0].ChildNodes[2].InnerXml = password;
            docXml.GetElementsByTagName("infra")[0].ChildNodes[3].InnerXml = project;
            docXml.Save("config.xml");
        }
    }
}
