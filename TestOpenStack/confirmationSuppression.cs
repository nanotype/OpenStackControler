using OpenStack;
using OpenStack.Compute.v2_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOpenStack
{
    public partial class confirmationSuppression : Form
    {
        Server server;

        public confirmationSuppression(Server S)
        {
            InitializeComponent();
            server = S;
            L_ID.Text = server.Id.ToString();
            L_nom.Text = server.Name;
        }

        private void TB_zone_deverouillage_TextChanged(object sender, EventArgs e)
        {
            if (TB_zone_deverouillage.Text == L_nom.Text)
            {
                B_supprimer.Enabled = true;
            }
            else
            {
                B_supprimer.Enabled = false;
            }
        }

        private async void B_supprimer_Click(object sender, EventArgs e)
        {
            /* message de confirmation */
            DialogResult result = MessageBox.Show("Attention, vous etes sur le point de supprimer l'instance '"+L_nom.Text+"' du serveur." + '\n' + "Voulez vous vraiment la supprimer ?", "Demande de suppression d'instance virtuelle", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                await server.DeleteAsync();
                Close();
            }
        }

        private void B_annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
