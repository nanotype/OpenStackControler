using System;
using System.Windows.Forms;

namespace TestOpenStack
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            interfaceConnexion IC = new interfaceConnexion();
            DialogResult successfullConnection = IC.ShowDialog();
            if(successfullConnection == DialogResult.Yes)
            {
                Application.Run(new Form1(IC.getConnection()));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
